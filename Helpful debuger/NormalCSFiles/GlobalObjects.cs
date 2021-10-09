using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using Helpful_debugger;



namespace Helpful_debuger
{
    public class Functions
    {
        Vars vars = new Vars();

        public void ErrorBoxShow(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void InfoBoxShow(string Message)
        {
            MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void WarnBoxShow(string Message)
        {
            MessageBox.Show(Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public bool QuestionBoxShow(string Message)
        {
            if (MessageBox.Show(Message, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                return true;

            }
            else
            {

                return false;
            }
        }

        public bool ErrorBoxYesNo(string Message)
        {
            if (MessageBox.Show(Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

                return true;

            }
            else
            {

                return false;
            }
        }

        string cahsefile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Helpful_Debgger_Data\cashe\chache1.txt";

        public void AddToOutputCashe(string content)
        {
            try
            {
                File.AppendAllText(cahsefile, content + "\r\n");
            } catch (Exception e)
            {
                if(ErrorBoxYesNo("Slow down buddy, also do you want to see the error"))
                {
                    ErrorBoxShow(e.ToString());
                    MessageBox.Show("l");                   
                }
            }
            
        }

        public string ReadOutputCashe()
        {
            try
            {
                return File.ReadAllText(cahsefile).ToString();
            }
            catch
            {
                return "Could not acces the file due to it bieng used by another thread, slow down buddy";
            }
            
            
            
        }
        
        public void ClearOutputCashe()
        {
            try
            {
                File.WriteAllText(cahsefile, "\n");
            } catch
            {

            }
            
        }
    }

    
    public class Vars
    {
       
        string AppDataFolder;
        
        public void CreateAppDataFolder()
        {
            string preappdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //MessageBox.Show(preappdata);
            AppDataFolder = preappdata + @"\Helpful_Debgger_Data";
            if (Directory.Exists(AppDataFolder))
            {

            } else
            {
                Directory.CreateDirectory(AppDataFolder);
            }
            
        }
        
        public void CreateCahseFolderAndDocument()
        {
            string directory = AppDataFolder + @"\cashe";
            if (AppDataFolder.Length == 0)
            {
                MessageBox.Show("The cashe folder was not created because the appdata folder does not exist");
            }
            else
            {
                if (Directory.Exists(directory))
                {
                    if (File.Exists(directory + @"\chache1.txt"))
                    {

                    }
                    else
                    {
                        File.Create(directory + @"\chache1.txt");
                    }
                }
                else
                {
                    
                    Directory.CreateDirectory(directory);
                    if (File.Exists(directory + @"\chache1.txt"))
                    {

                    } else
                    {
                        File.Create(directory + @"\chache1.txt");
                    }
                    
                }
            }
        }


        
    }

    public class Imports
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("msvcrt.dll")]
        public static extern int system(string format);

        [DllImport("msvcrt.dll")]
        public static extern int sleep(int milliseconds);
    }
}