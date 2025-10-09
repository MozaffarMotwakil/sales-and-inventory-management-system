using System;

namespace BusinessLogic.Interfaces
{
    public class EntitySavedEventArgs
    {
        public int EntityID { get; }
        public string EntityName { get; }
        public enMode OperationMode { get; }
        public DateTime Timestamp { get; }
        public int UserID { get; }

        public EntitySavedEventArgs(int entityID, string entityName, enMode mode)
        {
            EntityID = entityID;
            EntityName = entityName;
            OperationMode = mode;
            Timestamp = DateTime.Now;
            UserID = clsAppSettings.CurrentUser.UserID;
        }
    }
}