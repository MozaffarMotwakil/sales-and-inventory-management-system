using System;
using BusinessLogic.Suppliers;
using DataAccess.Utilities;

namespace BusinessLogic.Utilities
{
    public static class clsActivityLog
    {
        public enum enEntityTypes
        {
            Supplier = 1
        }

        public enum enActivityTypes
        {
            Add = 1,
            Update,
            Delete,
            Login,
            Logout
        }

        static clsActivityLog()
        {
            clsSupplier.SupplierSaved += LogSupplierSaveAction;
            clsSupplier.SupplierDeleted += LogSupplierDeleteAction;
        }

        public static void Initialize() { }

        private static void LogSupplierSaveAction(object sender, clsSupplier.SupplierSavedEventArgs e)
        {
            string details = e.OperationMode is enMode.Add ?
                $"تم إضافة مورد جديد: [{e.SavedSupplier.PartyInfo.PartyName}], معرف المورد: [{e.SavedSupplier.SupplierID}]." :
                $"تم تعديل بيانات المورد: [{e.SavedSupplier.PartyInfo.PartyName}], معرف المورد: [{e.SavedSupplier.SupplierID}].";

            Log(
                e.UserID,
                e.SavedSupplier.SupplierID,
                (int)enEntityTypes.Supplier,
                (int)e.OperationMode,
                details
            );
        }

        private static void LogSupplierDeleteAction(object sender, clsSupplier.SupplierDeletedEventArgs e)
        {
            string details = $"تم حذف مورد: [{e.SupplierName}], معرف المورد: [{e.SupplierID}].";

            Log(
                e.UserID,
                e.SupplierID,
                (int)enEntityTypes.Supplier,
                (int)enActivityTypes.Delete,
                details
            );
        }

        private static void Log(int userID, int? entityID, int entityTypeID, int activityTypeID, string details)
        {
            clsActivityLogData.InsertNewLog(userID, entityID, entityTypeID, activityTypeID, details);
        }

    }
}
