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
    public partial class Unblocked : Form
    {
        Functions funcs = new Functions();

        public Unblocked()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            Uri uri = new Uri(textBox1.Text);
            webBrowser1.Url = uri;
            funcs.AddToOutputCashe($"changed url to: {uri}");
        }
    }
}
