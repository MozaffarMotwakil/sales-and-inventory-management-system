using System;
using System.Data;

namespace BusinessLogic.Interfaces
{
    public interface IEntityListManager<T>
    {
        T Find(int id);
        bool Delete(int id);
        DataTable GetAll();

        event EventHandler<EntitySavedEventArgs> EntitySaved;
        event EventHandler<EntityDeletedEventArgs> EntityDeleted;
    }
}
