using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Helpful_debuger;

namespace Helpful_debuger
{
    public partial class Form2 : Form
    {
        Functions funcs = new Functions();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcs.AddToOutputCashe("Closed infoform");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/tubaplayerdis/HelpfulDebuger");
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            funcs.AddToOutputCashe("Clicked Infoform");
        }
    }
}
