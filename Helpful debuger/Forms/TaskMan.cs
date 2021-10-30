using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpful_debuger;

namespace Helpful_debugger.Forms
{
    public partial class TaskMan : Form
    {
        public TaskMan()
        {
            InitializeComponent();
        }

        Functions funcs = new Functions();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TaskMan_Load(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            bool isAdmin;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);

                // If is administrator, the variable updates from False to True
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            //switch (isAdmin)
            //{
                //case true:
                /*
                    Process[] currentprocces = Process.GetProcesses();
                    foreach (Process p in currentprocces)
                    {
                        ListViewGroup columnHeader = new ListViewGroup($"{p.ProcessName}", HorizontalAlignment.Left);
                        columnHeader.Items.Add($"ID: {p.Id}");
                        columnHeader.Items.Add($"Title: {p.MainWindowTitle}");
                        columnHeader.Items.Add($"Handle: {p.Handle}");
                        columnHeader.Items.Add($"Memory size: {p.VirtualMemorySize64}");
                        columnHeader.Items.Add($"CPU usage: {p.UserProcessorTime}%");
                        listView1.Groups.Add(columnHeader);
                        askadminlabel.Visible = false;
                    }
                */
                    //break;

                //case false:
                
                    Process[] currentprocce = Process.GetProcesses();
                    foreach (Process p in currentprocce)
                    {
                        ListViewGroup columnHeader = new ListViewGroup($"{p.ProcessName}", HorizontalAlignment.Left);                                               
                        listView1.Groups.Add(columnHeader);
                        askadminlabel.Visible = true;

                    }
            //break;
            /*
             * columnHeader.Items.Add($"ID: {p.Id}");
                columnHeader.Items.Add($"Title: {p.MainWindowTitle}");
                //columnHeader.Items.Add($"Handle: {p.Handle}");
                columnHeader.Items.Add($"Memory size: {p.VirtualMemorySize64}");
                //columnHeader.Items.Add($"CPU usage: {p.UserProcessorTime}%");
             */
            //}



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process[] currentprocce = Process.GetProcesses();
            foreach (Process p in currentprocce)
            {

                //listView1.BeginUpdate();
                funcs.AddToOutputCashe(p.ProcessName);
                ListViewGroup columnHeader = new ListViewGroup($"{p.ProcessName}", HorizontalAlignment.Left);
                listView1.Groups.Add(new ListViewGroup($"{p.ProcessName}", HorizontalAlignment.Left));
                
                askadminlabel.Visible = true;
                System.Threading.Thread.Sleep(10);
                //listView1.EndUpdate();

            }
            listView1.View = View.Details;
        }
    }
}
