using System;

namespace BusinessLogic.Interfaces
{
    public interface IEntityActivity
    {
        bool GetActivityStatus();

        bool MarkAsActive();

        bool MarkAsInActive();
    }
}
