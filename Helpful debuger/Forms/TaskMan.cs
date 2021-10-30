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
            Application.EnableVisualStyles();
        }

        Functions funcs = new Functions();
        string qu = "\"";

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TaskMan_Load(object sender, EventArgs e)
        {            
            
            GODList.View = View.Details;
            GODList.Clear();
            GODList.Columns.Add("Proc Name", 200, HorizontalAlignment.Left).DisplayIndex = 0;
            GODList.Columns.Add("Proc ID", 200, HorizontalAlignment.Left).DisplayIndex = 1;
            GODList.Columns.Add("Proc Title", 200, HorizontalAlignment.Left).DisplayIndex = 2;                    
            GODList.Columns.Add("Proc Mem", 100, HorizontalAlignment.Left).DisplayIndex = 3;
            ListViewGroup Defutlgroup = new ListViewGroup { Header = "Processes" };
            GODList.Groups.Add(Defutlgroup);
            Process[] currentprocce = Process.GetProcesses();
            foreach (Process p in currentprocce)
            {

                ListViewItem ProcID = new ListViewItem { Text = $"{p.ProcessName}", Group = Defutlgroup };
                ListViewItem.ListViewSubItem procID = new ListViewItem.ListViewSubItem { Text = $"{p.Id}" };
                ListViewItem.ListViewSubItem procTitle = new ListViewItem.ListViewSubItem { Text = $"{p.MainWindowTitle}" };                        
                ListViewItem.ListViewSubItem procMem = new ListViewItem.ListViewSubItem { Text = $"{p.WorkingSet64} bytes" };
                ProcID.SubItems.Add(procID);
                ProcID.SubItems.Add(procTitle);                       
                ProcID.SubItems.Add(procMem);
                GODList.Items.Add(ProcID);

            }                    
            GODList.Refresh();
            funcs.AddToOutputCashe("started taskman");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GODList.View = View.Details;
            GODList.Clear();
            GODList.Columns.Add("Proc Name", 200, HorizontalAlignment.Left).DisplayIndex = 0;
            GODList.Columns.Add("Proc ID", 200, HorizontalAlignment.Left).DisplayIndex = 1;
            GODList.Columns.Add("Proc Title", 200, HorizontalAlignment.Left).DisplayIndex = 2;                    
            GODList.Columns.Add("Proc Mem", 100, HorizontalAlignment.Left).DisplayIndex = 3;
            ListViewGroup Defutlgroup = new ListViewGroup { Header = "Processes" };
            GODList.Groups.Add(Defutlgroup);
            Process[] currentprocce = Process.GetProcesses();
            foreach (Process p in currentprocce)
            {

                ListViewItem ProcID = new ListViewItem { Text = $"{p.ProcessName}", Group = Defutlgroup };
                ListViewItem.ListViewSubItem procID = new ListViewItem.ListViewSubItem { Text = $"{p.Id}" };
                ListViewItem.ListViewSubItem procTitle = new ListViewItem.ListViewSubItem { Text = $"{p.MainWindowTitle}" };                        
                ListViewItem.ListViewSubItem procMem = new ListViewItem.ListViewSubItem { Text = $"{p.WorkingSet64} bytes" };
                ProcID.SubItems.Add(procID);
                ProcID.SubItems.Add(procTitle);                       
                ProcID.SubItems.Add(procMem);
                GODList.Items.Add(ProcID);

            }                    
            GODList.Refresh();
            funcs.AddToOutputCashe("refreshed tasklist for taskman");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IdKillbox.Text, out int value))
            {
                try
                {
                    Process getbyId = Process.GetProcessById(value);
                    getbyId.Kill();
                    funcs.InfoBoxShow("Killed " + qu + getbyId.ProcessName + qu + " Successfully");
                    funcs.AddToOutputCashe("Killed " + getbyId.ProcessName);
                }
                catch (Exception)
                {
                    funcs.ErrorBoxShow("The process id " + qu + value + qu + " does not exist");
                }


            }
            else
            {
                funcs.WarnBoxShow("Please enter a 5 digit number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string proccesname = Killbynamebox.Text;
            Process[] getbyname = Process.GetProcessesByName(proccesname);
            if (getbyname.Length == 0)
            {
                funcs.ErrorBoxShow("The process name " + qu + proccesname + qu + " does not exist");
            }
            else
            {
                foreach (var proccesvar in getbyname)
                {
                    try
                    {
                        proccesvar.Kill();
                        funcs.InfoBoxShow("Killed " + qu + proccesname + qu);
                        funcs.AddToOutputCashe("Killed " + proccesname);
                    }
                    catch (Exception)
                    {
                        funcs.ErrorBoxShow("Process " + qu + proccesname + qu + " does not exist therefore it cannot be terminated, if you are seeing this it is most likely bug");
                    }


                }
            }
        }
    }
}
