using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Proj
{
    internal class NotifyEvent
    {

        public delegate void AddStudentEventHandler(object sender, EventArgs e);

        public event AddStudentEventHandler OnAddStudent;

        public virtual void RaiseOnAddStudent()
        {
            var handler = OnAddStudent;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }

        }

    }
}
