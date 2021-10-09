﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpful_debuger;

namespace Helpful_debugger
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
            
        }

        Functions funcs = new Functions();

        //Variables
        string jsfilepath;
        string nl = "\r\n";
        string qu = "\"";
        bool Editing = false;
        bool Saved = false;


        public void TryToRunFile()
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
                info.Arguments = $"/K node {jsfilepath}";
                if (String.IsNullOrEmpty(jsfilepath))
                {
                    MessageBox.Show("The filepath you gave does not exist or you have not selected one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Process.Start(info);
                    MessageBox.Show("File was run, if there is a blank node box then there was no file specified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funcs.AddToOutputCashe("Ran JS File");
                }



            }
            catch (Exception error)
            {
                MessageBox.Show("There was an error, this is most likey caused by the fact the filepath you provided does not exist or you have not selected one" + nl + "Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckIfNode()
        {
            if (MessageBox.Show("This will look thourgh program files, do you want to check?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Directory.Exists(@"C:\\Program Files\\nodejs"))
                {
                    if (File.Exists(@"C:\\Program Files\\nodejs\\node.exe"))
                    {
                        MessageBox.Show("Node.js is installed", "Instalation checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("The node.exe file does not exist", "Instalation checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Node.js is not installed", "Instalation checker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                funcs.AddToOutputCashe("Checked for Node.js installation");
            }
            else
            {
                MessageBox.Show("Operation not completed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }



        private void RunScriptBTWSH_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(jsfilepath);
                MessageBox.Show("Successfully ran file with windows script host", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                funcs.AddToOutputCashe("Ran file with WSH");
            }
            catch (Exception error)
            {
                MessageBox.Show("There was an Error" + nl + "Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var trytorunfile = Task.Run(() => TryToRunFile());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var checknode = Task.Run(() => CheckIfNode());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Please confirm before saving" + "\n" + "Do you want to save ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.WriteAllText(jsfilepath, EditScriptBox.Text.ToString());
                    MessageBox.Show("File was saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Saved = true;
                    funcs.AddToOutputCashe("saved Js file");
                }
                else
                {
                    MessageBox.Show("File was not saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception error)
            {
                MessageBox.Show("Error this might be your antivirus or you have no file selected" + nl + "Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenJSfile.ShowDialog() == DialogResult.OK)
                {
                    string filepathofJS = OpenJSfile.FileName;
                    jsfilepath = filepathofJS;
                    string contentsoffile = File.ReadAllText(filepathofJS);
                    EditScriptBox.Text = contentsoffile;
                    FileOpenCurrently.Text = "Current file open: " + jsfilepath;
                    Saved = false;


                }
            } catch(Exception er)
            {
                MessageBox.Show($"Error: {nl} {er}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will cause you to lose any unsaved work, close editor now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcs.AddToOutputCashe("closed JS editor");
                this.Close();
            }
            else
            {
                MessageBox.Show("Did not close editor", "Confirmation");
            }

                
            
        }

        

        private void EditScriptBox_TextChanged(object sender, EventArgs e)
        {
            Saved = false;
        }

        private void EditorForm_Activated(object sender, EventArgs e)
        {
            funcs.AddToOutputCashe("Clicked EditorForm");
        }
    }
}