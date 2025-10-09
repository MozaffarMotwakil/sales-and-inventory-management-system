using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
