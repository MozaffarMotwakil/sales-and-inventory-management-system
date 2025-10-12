using BusinessLogic.Interfaces;
using BusinessLogic.Products;
using BusinessLogic.Suppliers;
using BusinessLogic.Warehouses;
using DataAccess.Utilities;

namespace BusinessLogic.Utilities
{
    public static class clsActivityLog
    {
        public enum enEntityTypes
        {
            Supplier = 1,
            Product,
            Warehouse
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
           clsSupplierService.GetInstance().EntitySaved += LogSupplierSaveAction;
           clsSupplierService.GetInstance().EntityDeleted += LogSupplierDeleteAction;
           clsProductService.GetInstance().EntitySaved += LogProductSaveAction;
           clsProductService.GetInstance().EntityDeleted += LogProductDeleteAction;
           clsWarehouseService.GetInstance().EntitySaved += LogWarehouseSaveAction;
           clsWarehouseService.GetInstance().EntityDeleted += LogWarehouseDeleteAction;
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

        private static void LogWarehouseSaveAction(object sender, EntitySavedEventArgs e)
        {
            string details = e.OperationMode is enMode.Add ?
                $"تم إضافة مخزن جديد: [{e.EntityName}], معرف المخزن: [{e.EntityID}]." :
                $"تم تعديل بيانات المخزن: [{e.EntityName}], معرف المخزن: [{e.EntityID}].";

            Log(
                e.UserID,
                e.EntityID,
                (int)enEntityTypes.Warehouse,
                (int)e.OperationMode,
                details
            );
        }

        private static void LogWarehouseDeleteAction(object sender, EntityDeletedEventArgs e)
        {
            string details = $"تم حذف المنتج: [{e.EntityName}], معرف المنتج: [{e.EntityID}].";

            Log(
                e.UserID,
                e.EntityID,
                (int)enEntityTypes.Warehouse,
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
