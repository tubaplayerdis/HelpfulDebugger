using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpful_debuger;

namespace Helpful_debugger.Forms
{
    public partial class CalcHistoryform : Form
    {
        Calculator calc = new Calculator();
        public CalcHistoryform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MakeTheSlaveWork()
        {
            UpdateCalcHistoryBox.RunWorkerAsync();
        }

        private void UpdateCalcHistoryBox_DoWork(object sender, DoWorkEventArgs e)
        {
            Calchistorybox.Text = calc.ReadCashe();
        }
    }
}
