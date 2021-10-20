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
    public partial class Consoleform : Form
    {
        Functions funcs = new Functions();
        public Consoleform()
        {
            InitializeComponent();
        }

        public void WriteLine(string value)
        {
            string cashetex;
            cashetex = richTextBox1.Text;
            cashetex += $"{value}\r\n";
            richTextBox1.Text = cashetex;           
            cashetex = "";
            funcs.AddToOutputCashe("tried to append text");
            
        }

        public void Clear()
        {
            richTextBox1.Text = "";
        }

        public void ChangeBackColor(Color color)
        {
            richTextBox1.BackColor = color;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string current = WriteLIneBox.Text;
            WriteLine(current);
        }
    }
}
