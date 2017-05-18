using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder_WindowEditor
{
    public partial class SetWindowDialog : Form
    {

        public SetWindowDialog(String label1Text, String label2Text)
        {
            InitializeComponent();
            label1.Text = label1Text;
            label2.Text = label2Text;
        }

        public SetWindowDialog(String label1Text, String label2Text, int minValue)
        {
            InitializeComponent();
            label1.Text = label1Text;
            label2.Text = label2Text;
            this.numericUpDown2.Minimum = minValue;
            this.numericUpDown1.Minimum = minValue;
        }

        public int numericUpDown1Value { get; private set; }
        public int numericUpDown2Value { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1Value = Convert.ToInt32( numericUpDown1.Value);
            numericUpDown2Value = Convert.ToInt32(numericUpDown2.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
