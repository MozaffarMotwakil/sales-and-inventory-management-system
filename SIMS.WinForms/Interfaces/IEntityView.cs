using System;
using System.Windows.Forms;

namespace SIMS.WinForms.Interfaces
{
    public interface IEntityView<T> where T : class
    {
        T Entity { get; set; }
    }
}
