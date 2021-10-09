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
using Helpful_debugger;
using System.IO;
using Helpful_debugger.Forms;



namespace Helpful_debugger.Forms
{

    public partial class PasswordCreatorForm : Form
    {
        string Passwords = "Passwords: \r\n\r\n";
        Functions funcs = new Functions();
        public PasswordCreatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NumberOFNumberic.Value == 0 || NumberOFNumberic.Value > 20000)
            {
                funcs.InfoBoxShow("You need to enter a value beetween 0 and 20000 for your # of passwords");
                
                if(LegthNumberic.Value == 0 || LegthNumberic.Value > 30)
                {
                    funcs.InfoBoxShow("You need to enter a value beetween 0 and 30 for your password Legth");
                } 
            } else
            {
                if (LegthNumberic.Value == 0 || LegthNumberic.Value > 30)
                {
                    funcs.InfoBoxShow("You need to enter a value beetween 0 and 30 for your password Legth");
                }
                else
                {
                    for (int i = 0; i < NumberOFNumberic.Value; i++)
                    {
                        Passwords += GeneratePassword(((int)LegthNumberic.Value));
                    }
                    textBox1.Text = Passwords;
                    funcs.AddToOutputCashe("Generated passwords");
                }
            }


            

            
            
        }
        Random random = new Random();
        public string GeneratePassword(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];

            
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString += "\r\n\r\n";


        }
    }
}
