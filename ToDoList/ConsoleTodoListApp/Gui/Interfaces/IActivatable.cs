using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTodoListApp.Gui.Interfaces
{
    interface IActivatable
    {

        public bool IsActive { get; }

        public void Activate();
        public void Deactivate();

    }
}
