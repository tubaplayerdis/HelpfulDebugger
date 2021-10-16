using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Helpful_debuger
{
    public partial class injector : Form
    {

        public injector()
        {
            InitializeComponent();
        }

        private void injector_Load(object sender, EventArgs e)
        {
            comboMethod.Items.Add("LoadLibraryEx"); // adde Methode
            comboMethod.Items.Add("NtCreateThreadEx");
            comboMethod.SelectedIndex = 0; // Setze die Auswahl auf die erste Methode       

            Thread checkProc = new Thread(checkProcess);
            checkProc.Start();

            SaveFile.loadFile();

            if (DataHolder.injectOnStartup)
                l_closeOnInject.ForeColor = ColorTranslator.FromHtml(GlobalVars.colorBlocked);

            comboProcess.Text = DataHolder.savedProcess;
            this.textDll.Text = DataHolder.savedDllPath;
            comboMethod.SelectedIndex = DataHolder.injectorMethod;
        }

        #region comboProcessUpdate

        private void ComboProcess_DropDown(object sender, EventArgs e)
        {
            comboProcess.Items.Clear();
            Process[] procList = Process.GetProcesses();
            List<Process> used = new List<Process>();
            bool repeat;

            foreach (Process proc in procList)
            {
                repeat = false;
                foreach (Process inUse in used)
                {
                    if (proc.ProcessName == inUse.ProcessName)
                        repeat = true;
                }

                if (!repeat)
                {
                    used.Add(proc);
                    comboProcess.Items.Add(proc.ProcessName);
                }

                if (this.IsDisposed)
                    break;
            }
        }

        private void ComboProcess_TextChanged(object sender, EventArgs e)
        {
            updateComboId();
        }

        private void ComboId_DropDown(object sender, EventArgs e)
        {
            updateComboId();
        }

        private void updateComboId()
        {
            bool exist = false;
            Process[] procList = Process.GetProcesses();
            foreach (Process proc in procList)
            {
                if (comboProcess.Text == proc.ProcessName)
                    exist = true;
            }

            if (exist)
            {
                Process[] procs = Process.GetProcessesByName(comboProcess.Text);
                comboId.Items.Clear();
                foreach (Process proc in procs)
                    comboId.Items.Add(proc.Id);
                comboId.SelectedIndex = 0;
            }
        }


        delegate void StringArgReturningVoidDelegate();

        private void checkProcess()
        {
            while (!this.IsDisposed)
            {
                invokeCheckProcess();
                System.Threading.Thread.Sleep(350);
            }

        }

        private void invokeCheckProcess()
        {
            if (this.comboProcess.InvokeRequired)
            {
                try
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(invokeCheckProcess);
                    this.Invoke(d);
                }
                catch
                {
                }
            }
            else
            {
                bool exist = false;
                Process[] procList = Process.GetProcesses();
                foreach (Process proc in procList)
                {
                    if (comboProcess.Text == proc.ProcessName)
                        exist = true;
                }

                Image buf = picProcess.Image;

                if (exist)
                    picProcess.Image = Helpful_debugger.Properties.Resources.Right;
                else
                    picProcess.Image = Helpful_debugger.Properties.Resources.Wrong;

                Bitmap bmpProc = new Bitmap(picProcess.Image);
                Bitmap bmpOrigin = new Bitmap(buf);
                if (bmpProc.GetPixel(8, 8) != bmpOrigin.GetPixel(8, 8)) // Check ob beide Pixel same sind
                    updateComboId();

                if ((boxInjectOnStartup.Image != null) && exist && !GlobalVars.autoInject && !String.IsNullOrEmpty(textDll.Text))
                {
                    bInject.PerformClick();
                    GlobalVars.autoInject = true;
                }


            }

        }

        #endregion comboProcessUpdate

        #region tabMethods

        private void bOptions_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            boxCloseOnInject.Image = (DataHolder.closeOnInjection) ? Helpful_debugger.Properties.Resources.tick : null;
            boxInjectOnStartup.Image = (DataHolder.injectOnStartup) ? Helpful_debugger.Properties.Resources.tick : null;


            if (DataHolder.injectOnStartup)
                l_closeOnInject.ForeColor = ColorTranslator.FromHtml(GlobalVars.colorBlocked);
            else
                l_closeOnInject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        #endregion tabMethods

        #region Dll

        private void bSearchDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "DLL|*.dll";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textDll.Text = ofd.FileName;
            }
        }

        private void bInject_Click(object sender, EventArgs e)
        {
            if (GlobalVars.inject)
                return;

            Bitmap bmpProc = new Bitmap(picProcess.Image);
            Bitmap bmpRight = new Bitmap(Helpful_debugger.Properties.Resources.Right);
            if (bmpProc.GetPixel(8, 8) != bmpRight.GetPixel(8, 8)) // Check ob beide Pixel same sind
                return;

            if (!File.Exists(textDll.Text))
                return;

            IntPtr hProcess = Imports.OpenProcess(0x1F0FFF, true, Int32.Parse(comboId.Text));
            if (hProcess == (IntPtr)null)
                return;

            if (x86Support.cpuEquals(hProcess, textDll.Text))
            {
                Imports.kernelErrMsg("Your Dll isn't compatible with the target process");
                return;
            }

            bool bIsWow32 = false;
            Imports.IsWow64Process(hProcess, ref bIsWow32);
            IntPtr loadLibAddy = IntPtr.Zero;
            if (bIsWow32)
                loadLibAddy = x86Support.GetLoadLibAddy32();




            switch (comboMethod.Text)
            {
                case "LoadLibraryEx":
                    GlobalVars.inject = LoadLibraryEx.LoadLibrary(hProcess, textDll.Text, loadLibAddy);
                    break;
                case "NtCreateThreadEx":
                    GlobalVars.inject = NtCreateThreadEx.NtCreateThread(hProcess, textDll.Text, loadLibAddy);
                    break;

            }

            if (DataHolder.closeOnInjection && !DataHolder.injectOnStartup)
                Process.GetCurrentProcess().Kill();

            if (GlobalVars.inject)
            {
                bInject.ForeColor = ColorTranslator.FromHtml(GlobalVars.colorBlocked);
                bInject.Enabled = false;
            }
                

        }

        #endregion Dll

        #region click

        private void bSaveSelection_Click(object sender, EventArgs e)
        {
            DataHolder.savedDllPath = textDll.Text;
            DataHolder.savedProcess = comboProcess.Text;
            DataHolder.injectorMethod = comboMethod.SelectedIndex;
            SaveFile.saveFile();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            DataHolder.injectOnStartup = (boxInjectOnStartup.Image != null) ? true : false;
            DataHolder.closeOnInjection = (boxCloseOnInject.Image != null) ? true : false;
            SaveFile.saveFile();
            tabControl.SelectedIndex = 0;

        }

        private void closeProcess_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void minimizeProcess_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion click

        #region moveWindow

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        #endregion moveWindow

        #region buttonCheckbox

        private void boxCloseOnInject_Click(object sender, EventArgs e)
        {
            if (boxCloseOnInject.Image == null)
                boxCloseOnInject.Image = Helpful_debugger.Properties.Resources.tick;
            else
                boxCloseOnInject.Image = null;
        }

        private void boxInjectOnStartup_Click(object sender, EventArgs e)
        {
            if (boxInjectOnStartup.Image == null)
            {
                boxInjectOnStartup.Image = Helpful_debugger.Properties.Resources.tick;
                l_closeOnInject.ForeColor = ColorTranslator.FromHtml(GlobalVars.colorBlocked);
            }
            else
            {
                boxInjectOnStartup.Image = null;
                l_closeOnInject.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }

        #endregion buttonCheckbox


    }
}
