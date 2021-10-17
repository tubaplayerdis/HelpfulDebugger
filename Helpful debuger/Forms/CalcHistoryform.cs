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
        Functions funcs = new Functions();
        public CalcHistoryform()
        {
            InitializeComponent();
            UpdateCalcHistoryBox.RunWorkerAsync();
            dowork = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dowork = false;
            System.Threading.Thread.Sleep(10);
            UpdateCalcHistoryBox.CancelAsync();
            this.Close();
        }

        

        private void UpdateCalcHistoryBox_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                try
                {
                    Calchistorybox.Text = calc.ReadCashe();
                } catch(Exception)
                {
                    funcs.AddToOutputCashe("Error creating window handle for calc his");
                }                
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
            if(funcs.QuestionBoxShow("this will delete calcualtor history are you sure"))
            {
                calc.DeleteCashe();
            }           
        }
    }
}
