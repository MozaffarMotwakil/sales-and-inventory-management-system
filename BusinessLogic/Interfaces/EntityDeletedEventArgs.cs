using System;

namespace BusinessLogic.Interfaces
{
    public class EntityDeletedEventArgs
    {
        public int EntityID { get; }
        public string EntityName { get; }
        public DateTime Timestamp { get; }
        public int UserID { get; }

        public EntityDeletedEventArgs(int entityID, string entityName)
        {
            EntityID = entityID;
            EntityName = entityName;
            Timestamp = DateTime.Now;
            UserID = clsAppSettings.CurrentUser.UserID;
        }
    }
}