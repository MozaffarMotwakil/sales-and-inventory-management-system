using BusinessLogic.Interfaces;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using DataAccess.Utilities;

namespace BusinessLogic.Utilities
{
    public static class clsActivityLog
    {
        public enum enEntityTypes
        {
            Supplier = 1,
            Product
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
            new clsSupplierService().EntitySaved += LogSupplierSaveAction;
            new clsSupplierService().EntityDeleted += LogSupplierDeleteAction;
            new clsProductService().EntitySaved += LogProductSaveAction;
            new clsProductService().EntityDeleted += LogProductDeleteAction;
        }

        public static void Initialize() { }

        private static void LogSupplierSaveAction(object sender, EntitySavedEventArgs e)
        {
            string details = e.OperationMode is enMode.Add ?
                $"تم إضافة مورد جديد: [{e.EntityName}], معرف المورد: [{e.EntityID}]." :
                $"تم تعديل بيانات المورد: [{e.EntityName}], معرف المورد: [{e.EntityID}].";

            Log(
                e.UserID,
                e.EntityID,
                (int)enEntityTypes.Supplier,
                (int)e.OperationMode,
                details
            );
        }

        private static void LogSupplierDeleteAction(object sender, EntityDeletedEventArgs e)
        {
            string details = $"تم حذف مورد: [{e.EntityName}], معرف المورد: [{e.EntityID}].";

            Log(
                e.UserID,
                e.EntityID,
                (int)enEntityTypes.Supplier,
                (int)enActivityTypes.Delete,
                details
            );
        }

        private static void LogProductSaveAction(object sender, EntitySavedEventArgs e)
        {
            string details = e.OperationMode is enMode.Add ?
                $"تم إضافة منتج جديد: [{e.EntityName}], معرف المنتج: [{e.EntityID}]." :
                $"تم تعديل بيانات المنتج: [{e.EntityName}], معرف المنتج: [{e.EntityID}].";

            Log(
                e.UserID,
                e.EntityID,
                (int)enEntityTypes.Product,
                (int)e.OperationMode,
                details
            );
        }

        private static void LogProductDeleteAction(object sender, EntityDeletedEventArgs e)
        {
            string details = $"تم حذف المنتج: [{e.EntityName}], معرف المنتج: [{e.EntityID}].";

            Log(
                e.UserID,
                e.EntityID,
                (int)enEntityTypes.Product,
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
