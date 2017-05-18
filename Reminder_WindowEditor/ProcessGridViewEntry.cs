using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder_WindowEditor
{
    public class ProcessGridViewEntry
    {
        public ProcessGridViewEntry(DataGridViewRow dataGridViewRow, Process proc)
        {
            this.ProcessRow = dataGridViewRow;
            this.Process = proc;
        }

        public DataGridViewRow ProcessRow { get; }
        public Process Process { get; }
    }
}
