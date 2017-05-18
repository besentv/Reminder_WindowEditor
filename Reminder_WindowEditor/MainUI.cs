using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder_WindowEditor
{


    public partial class MainUI : Form
    {
        private List<ProcessGridViewEntry> processRows = new List<ProcessGridViewEntry>();

        private List<Process> processesInTaskbarList = new List<Process>();

        private bool isUpdating = false;
        private bool dontUpdate = false;

        public MainUI()
        {
            InitializeComponent();
            listTaskbarProcesses();
        }

        private enum ProcessModify{
            removeBorder,
            changePosition,
            changeSize
        }

        private void getProcessesInTaskbar()
        {
            processesInTaskbarList.Clear();
            Process[] procs = Process.GetProcesses();
            foreach (Process proc in procs)
            {
                if (!String.IsNullOrEmpty(proc.MainWindowTitle))
                {
                    processesInTaskbarList.Add(proc);
                }
            }
        }

        public void listTaskbarProcesses()
        {
            if (!dontUpdate)
            {
                isUpdating = true;
                getProcessesInTaskbar();
                processList.Rows.Clear();
                foreach (Process proc in processesInTaskbarList)
                {
                    processList.Rows.Add(new String[] { proc.ProcessName + ".exe", proc.Id.ToString(), proc.MainWindowTitle });
                }
                isUpdating = false;
            }
        }

        private void processList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isUpdating && (e.RowIndex >= 0))
            {
                dontUpdate = true;
                foreach (Process proc in processesInTaskbarList)
                {
                    if (String.Compare(processList.Rows[e.RowIndex].Cells["PID"].Value.ToString(), proc.Id.ToString()) == 0)
                    {
                        DialogResult result = MessageBox.Show("Do you really want to remove this window's border?", "Remove border?", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {

                            Program.removeWindowBorder(proc);

                        }
                        else
                        {
                            dontUpdate = false;
                            return;
                        }

                    }
                }
                dontUpdate = false;
            }

        }

        private void ticker_Tick(object sender, EventArgs e)
        {

            listTaskbarProcesses();

        }

        private void processList_Click(object sender, EventArgs e)
        {

        }

        private void processList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dontUpdate = true;
                DataGridView.HitTestInfo hit = processList.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    processList.ClearSelection();
                    processList[hit.ColumnIndex, hit.RowIndex].Selected = true;
                    contextMenuStripProcessList.Show(processList, e.Location);
                }
            }
        }

        private Process GetSelectedProcess()
        {
            Process ret = null;
            foreach (DataGridViewRow row in processList.SelectedRows)
            {
                foreach (Process proc in processesInTaskbarList)
                {
                    if (String.Compare(row.Cells["PID"].Value.ToString(), proc.Id.ToString()) == 0)
                    {
                        ret = proc;
                        return ret;
                    }
                }
            }
            return ret;
        }

        private void modifyProcess(Process proc, ProcessModify arg)
        {
            switch (arg)
            {
                case ProcessModify.removeBorder:
                    {
                        DialogResult result = MessageBox.Show("Do you really want to remove this window's border?", "Remove border?", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {

                            Program.removeWindowBorder(proc);

                        }
                        break;
                    }
                case ProcessModify.changePosition:
                    {
                        SetWindowDialog dialog = new SetWindowDialog("X:", "Y:");
                        dialog.ShowDialog();
                        if(dialog.DialogResult == DialogResult.OK)
                        {
                            int x = dialog.numericUpDown1Value;
                            int y = dialog.numericUpDown2Value;
                            Program.changeWindowPos(x, y, proc);
                        }
                        break;
                    }
                case ProcessModify.changeSize:
                    {
                        SetWindowDialog dialog = new SetWindowDialog("Width:", "Height:",1);
                        dialog.ShowDialog();
                        if (dialog.DialogResult == DialogResult.OK)
                        {
                            int width = Math.Abs(dialog.numericUpDown1Value);
                            int height = Math.Abs(dialog.numericUpDown2Value);
                            Program.changeWindowSize(width, height, proc);
                        }
                        break;
                    }
            }
            
        }

        private void toolStripMenuItemRemoveWindow_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                isUpdating = true;
                Process proc = GetSelectedProcess();
                if (proc != null)
                {
                    modifyProcess(proc, ProcessModify.removeBorder);
                }
                isUpdating = false;
            }
            dontUpdate = false;
        }

        private void changeWindowPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                isUpdating = true;
                Process proc = GetSelectedProcess();
                if (proc != null)
                {
                    modifyProcess(proc, ProcessModify.changePosition);
                }
                isUpdating = false;
            }
            dontUpdate = false;
        }

        private void contextMenuStripProcessList_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            dontUpdate = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void changeWindowSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isUpdating)
            {
                isUpdating = true;
                Process proc = GetSelectedProcess();
                if (proc != null)
                {
                    modifyProcess(proc, ProcessModify.changeSize);
                }
                isUpdating = false;
            }
            dontUpdate = false;
        }
    }
}

