using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Helpful_debuger;
using Helpful_debuger.Methods;
using Helpful_debugger.Forms;
using System.Diagnostics;


namespace Helpful_debugger
{
    public partial class OutputForm : Form
    {
        Vars vars = new Vars();
        Functions funcs = new Functions();
        Imports imps = new Imports();
        
        bool UpdateOutputBoxBool;
        public OutputForm()
        {
            InitializeComponent();
            funcs.AddToOutputCashe("OutputForm.cs has started");
            OutputBox.Text = funcs.ReadOutputCashe();
            UpdateOuptutBox.RunWorkerAsync();
            UpdateOutputBoxBool = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderpath;
            string filepath;
            DateTime utcDate = DateTime.UtcNow;
            
            
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Helpful_Debgger_Data"))
            {
                folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Helpful_Debgger_Data";
                string cache = utcDate.ToString("yyyy_MM_dd_tt_mm_ffff");
                
                filepath = folderpath + @"\Entry" + cache + ".txt";
                filepath.Replace("/", "_");
                

                if (File.Exists(filepath))
                {
                    if(funcs.QuestionBoxShow("File " + filepath + " already exists overwrite?"))
                    {
                        File.WriteAllText(filepath, funcs.ReadOutputCashe());
                        OutputBox.Text = "";
                        funcs.ClearOutputCashe();
                    }
                } else
                {
                    File.WriteAllText(filepath, funcs.ReadOutputCashe());
                    OutputBox.Text = "";
                    funcs.ClearOutputCashe();

                }
                

            }
            else
            {
                if(funcs.QuestionBoxShow("The appdata folder has not been created create now?"))
                {
                    vars.CreateAppDataFolder();
                    funcs.InfoBoxShow("Created Appdata folder");
                } else
                {
                    funcs.InfoBoxShow("Did not create appdata folder");
                }
            }
        }

        private void OutputForm_Activated(object sender, EventArgs e)
        {
            funcs.AddToOutputCashe("OutputForm.cs was clicked");
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funcs.AddToOutputCashe("Refreshed Data");
            OutputBox.Text = funcs.ReadOutputCashe();
        }

        public void UpdateBox()
        {
            
        }

        private void UpdateOuptutBox_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                OutputBox.Text = funcs.ReadOutputCashe();
                Thread.Sleep(10);
            } while (UpdateOutputBoxBool == true);
                

            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Helpful_Debgger_Data";
            Process.Start("explorer.exe", folderpath);
        }

        private void OutputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateOutputBoxBool = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string[] folderpath = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Helpful_Debgger_Data\", "Entry*.txt", SearchOption.AllDirectories);

                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"Helpful_Debgger_Data"))
                {
                    funcs.InfoBoxShow("The appdata folder does not exist");
                }
                else
                {                    
                    if (folderpath.Length == 0)
                    {
                        funcs.InfoBoxShow("There were no files to delete");
                    }
                    else
                    {
                        foreach (string filepath in folderpath)
                        {
                            File.Delete(filepath);
                            funcs.AddToOutputCashe($"Deleted: {filepath}");
                        }
                        funcs.AddToOutputCashe("Cleared Logs");
                    }
                }
            } catch(Exception r)
            {
                funcs.ErrorBoxShow($"There was an error: {r}");
            }
            
            
            
        }

        

        
    }
}
