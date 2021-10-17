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
        bool dowork;
        public CalcHistoryform()
        {
            InitializeComponent();
            UpdateCalcHistoryBox.RunWorkerAsync();
            dowork = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void UpdateCalcHistoryBox_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                Calchistorybox.Text = calc.ReadCashe();
                System.Threading.Thread.Sleep(10);
            } while (dowork == true);
           
        }

        private void CalcHistoryform_FormClosing(object sender, FormClosingEventArgs e)
        {
            dowork = false;
            System.Threading.Thread.Sleep(10);
            UpdateCalcHistoryBox.CancelAsync();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            calc.DeleteCashe();
        }
    }
}
