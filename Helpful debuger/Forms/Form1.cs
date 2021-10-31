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
using Helpful_debuger;
using Helpful_debugger.Forms;
using System.Security.Principal;

namespace Helpful_debuger
{
    [ComVisible(true)]

    

    public partial class Form1 : Form
    {
        string nl = "\r\n";
        string qu = "\"";



        Functions funcs = new Functions();
        Calculator calcs = new Calculator();

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public bool clickingAblilty = false;
        public int intervals = 1000;
        public int parsedvalue;
        public bool pasuedoutput;

        //Does this github thing work?
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            var t1 = Task.Run(() => CursorLOL());            
            var t4 = Task.Run(() => Autoclicker());
            var t5 = Task.Run(() => Keypres());
            UpdateBoxWithApps();
            Vars vars = new Vars();
            vars.CreateAppDataFolder();
            vars.CreateCahseFolderAndDocument();
            funcs.ClearOutputCashe();
            calcs.CreateCasheDocument();
            funcs.AddToOutputCashe("Form1.cs has started");
            

        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CursorDebugCheckBox.Checked)
            {
                CursorPosBox.Visible = true;
                CursorPosBox.Enabled = true;
                CursorPosBox2.Visible = true;
                CursorPosBox2.Enabled = true;               
                printcorrdsbutton.Visible = true;
                printcorrdsbutton.Enabled = true;
                funcs.AddToOutputCashe("enabled cursor debug");
            }
            else
            {
                CursorPosBox.Visible = false;
                CursorPosBox.Enabled = false;
                CursorPosBox2.Visible = false;
                CursorPosBox2.Enabled = false;                
                printcorrdsbutton.Visible = false;
                printcorrdsbutton.Enabled = false;
                funcs.AddToOutputCashe("disabled cursor debug");
            }
            
            

        }

        
        public void CursorLOL()
        {
            
            while (true)
            {
                int posX = MousePosition.X;
                int posY = MousePosition.Y;
                CursorPosBox.Text = "Xpos: " + posX.ToString();
                CursorPosBox2.Text = "Ypos: " + posY.ToString();
                Thread.Sleep(1);
            }
        }

        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        // 8===== > {()} 69 nine lol

        /*
        try
        {

        } catch(Exception error)
        {
            MessageBox.Show("There was an Error" + nl + "Error: " + error);
        }
         */
        // funcs.AddToOutputCashe();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SystemInfoBox.Text = "";
                ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
                foreach (ManagementObject obj in myVideoObject.Get())
                {
                    SystemInfoBox.AppendText("Name  -  " + obj["Name"] + nl);
                    SystemInfoBox.AppendText("Status  -  " + obj["Status"] + nl);
                    SystemInfoBox.AppendText("Caption  -  " + obj["Caption"] + nl);
                    SystemInfoBox.AppendText("DeviceID  -  " + obj["DeviceID"] + nl);
                    SystemInfoBox.AppendText("AdapterRAM  -  " + SizeSuffix((long)Convert.ToDouble(obj["AdapterRAM"])) + nl);
                    SystemInfoBox.AppendText("AdapterDACType  -  " + obj["AdapterDACType"] + nl);
                    SystemInfoBox.AppendText("Monochrome  -  " + obj["Monochrome"] + nl);
                    SystemInfoBox.AppendText("InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"] + nl);
                    SystemInfoBox.AppendText("DriverVersion  -  " + obj["DriverVersion"] + nl);
                    SystemInfoBox.AppendText("VideoProcessor  -  " + obj["VideoProcessor"] + nl);
                    SystemInfoBox.AppendText("VideoArchitecture  -  " + obj["VideoArchitecture"] + nl);
                    SystemInfoBox.AppendText("VideoMemoryType  -  " + obj["VideoMemoryType"] + nl);
                    SystemInfoBox.AppendText(nl);
                }
                funcs.AddToOutputCashe("GPU Data Requested");
            }
            catch (Exception error)
            {
                Functions test = new Functions();
                test.ErrorBoxShow("There was an Error" + nl + "Error: " + error);

            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SystemInfoBox.Text = "";

            funcs.InfoBoxShow("Successfully cleared text");
            funcs.AddToOutputCashe("Cleared SystemInfoBox text");

        }

        private void Requestdrivebutton_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
                SystemInfoBox.Text = "";
                foreach (ManagementObject obj in myProcessorObject.Get())
                {
                    SystemInfoBox.AppendText("Name  -  " + obj["Name"] + nl);
                    SystemInfoBox.AppendText("DeviceID  -  " + obj["DeviceID"] + nl);
                    SystemInfoBox.AppendText("Manufacturer  -  " + obj["Manufacturer"] + nl);
                    SystemInfoBox.AppendText("CurrentClockSpeed  -  " + obj["CurrentClockSpeed"] + nl);
                    SystemInfoBox.AppendText("Caption  -  " + obj["Caption"] + nl);
                    SystemInfoBox.AppendText("NumberOfCores  -  " + obj["NumberOfCores"] + nl);
                    SystemInfoBox.AppendText("NumberOfEnabledCores  -  " + obj["NumberOfEnabledCore"] + nl);
                    SystemInfoBox.AppendText("NumberOfLogicalProcessors  -  " + obj["NumberOfLogicalProcessors"] + nl);
                    SystemInfoBox.AppendText("Architecture  -  " + obj["Architecture"] + nl);
                    SystemInfoBox.AppendText("Family  -  " + obj["Family"] + nl);
                    SystemInfoBox.AppendText("ProcessorType  -  " + obj["ProcessorType"] + nl);
                    SystemInfoBox.AppendText("Characteristics  -  " + obj["Characteristics"] + nl);
                    SystemInfoBox.AppendText("AddressWidth  -  " + obj["AddressWidth"] + nl);
                    SystemInfoBox.AppendText(nl);
                }
                funcs.AddToOutputCashe("Requested CPU information");
            } catch(Exception error)
            {
                funcs.ErrorBoxShow("There was an Error" + nl + "Error: " + error);
                
            }
            


        }

        private void RequestOSinfobutton_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                SystemInfoBox.Text = "";
                foreach (ManagementObject obj in myOperativeSystemObject.Get())
                {
                    SystemInfoBox.AppendText("Caption  -  " + obj["Caption"] + nl);
                    SystemInfoBox.AppendText("WindowsDirectory  -  " + obj["WindowsDirectory"] + nl);
                    SystemInfoBox.AppendText("ProductType  -  " + obj["ProductType"] + nl);
                    SystemInfoBox.AppendText("SerialNumber  -  " + obj["SerialNumber"] + nl);
                    SystemInfoBox.AppendText("SystemDirectory  -  " + obj["SystemDirectory"] + nl);
                    SystemInfoBox.AppendText("CountryCode  -  " + obj["CountryCode"] + nl);
                    SystemInfoBox.AppendText("CurrentTimeZone  -  " + obj["CurrentTimeZone"] + nl);
                    SystemInfoBox.AppendText("EncryptionLevel  -  " + obj["EncryptionLevel"] + nl);
                    SystemInfoBox.AppendText("OSType  -  " + obj["OSType"] + nl);
                    SystemInfoBox.AppendText("Version  -  " + obj["Version"] + nl);
                }
                funcs.AddToOutputCashe("Requested OS info");
            }
            catch (Exception error)
            {
                funcs.ErrorBoxShow("There was an Error" + nl + "Error: " + error);
            }
            
        }

        private void ntrebut_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdateBoxWithApps()
        {
            try
            {
                Process[] currentprocces = Process.GetProcesses();

                foreach (Process process in currentprocces)
                {
                    

                        curappopbox.AppendText("Procces: " + process.ProcessName + nl);
                        curappopbox.AppendText("    ID   :" + process.Id + nl);
                        curappopbox.AppendText("    Title:" + process.MainWindowTitle + nl);
                        curappopbox.AppendText(nl);
                    
                }
                funcs.AddToOutputCashe("Requested Current Procceses");
            }
            catch (Exception error)
            {
                funcs.ErrorBoxShow("There was an Error" + nl + "Error: " + error);
            }
            
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            curappopbox.Text = "";
            UpdateBoxWithApps();
            funcs.InfoBoxShow("Successfully Refreshed");
            funcs.AddToOutputCashe("Refreshed Processes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string proccesname = Killbynamebox.Text;
            Process[] getbyname = Process.GetProcessesByName(proccesname);
            if (getbyname.Length == 0)
            {
                funcs.ErrorBoxShow("The process name " + qu + proccesname + qu + " does not exist");               
            }
            else
            {
                foreach(var proccesvar in getbyname)
                {
                    try
                    {
                        proccesvar.Kill();                        
                        funcs.InfoBoxShow("Killed " + qu + proccesname + qu);
                        funcs.AddToOutputCashe("Killed " + proccesname);
                    }
                    catch (Exception)
                    {
                        funcs.AddToOutputCashe("Process " + qu + proccesname + qu + " does not exist therefore it cannot be terminated, if you are seeing this it is most likely bug");                        
                    }
                    
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Infobutton_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
            funcs.AddToOutputCashe("Opened InfoForm");
        }

        /*
        try
        {

        } catch(Exception error)
        {
            MessageBox.Show("There was an Error" + nl + "Error: " + error);
        }
         */

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                SystemInfoBox.Text = "";

                foreach (DriveInfo d in allDrives)
                {
                    SystemInfoBox.AppendText("Drive " + d.Name + nl);
                    SystemInfoBox.AppendText("  Drive type: " + d.DriveType + nl);
                    // optical drives dont load in time
                    if (d.IsReady == true)
                    {
                        SystemInfoBox.AppendText("  Volume label: " + d.VolumeLabel + nl);
                        SystemInfoBox.AppendText("  File system: " + d.DriveFormat + nl);
                        SystemInfoBox.AppendText("  Available space to current user: " + SizeSuffix(d.AvailableFreeSpace) + nl);
                        SystemInfoBox.AppendText("  Total available space: " + SizeSuffix(d.TotalFreeSpace) + nl);
                        SystemInfoBox.AppendText("  Total size of drive: " + SizeSuffix(d.TotalSize) + nl);
                        SystemInfoBox.AppendText("  Root Directory: " + d.RootDirectory + nl);
                        SystemInfoBox.AppendText(nl);
                    }
                    else
                    {
                        d.ToString();
                        funcs.WarnBoxShow("Drive " + qu + d + qu + " Was not ready, the drive may be corrupted or missing, let the request finish then request again");                        
                        SystemInfoBox.AppendText(nl);
                    }
                    funcs.AddToOutputCashe("requested Drive Info for drive" + d.ToString());
                }
            }
            catch (Exception error)
            {
                funcs.ErrorBoxShow("There was an Error" + nl + "Error: " + error);
                
            }
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

                SystemInfoBox.Text = "";
                if (nics == null || nics.Length < 1)
                {
                    SystemInfoBox.AppendText("No network interfaces found.");
                    MessageBox.Show("No network interfaces were found, either this program is blocked from the internet or your ethernet/wifi or both is not on", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (NetworkInterface adapter in nics)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        SystemInfoBox.AppendText(nl);
                        SystemInfoBox.AppendText(adapter.Description + nl);
                        SystemInfoBox.AppendText(string.Empty.PadLeft(adapter.Description.Length, '=') + nl);
                        SystemInfoBox.AppendText(" Interface type .......................... : " + adapter.NetworkInterfaceType + nl);
                        SystemInfoBox.AppendText(" Physical Address ........................ : " + adapter.GetPhysicalAddress().ToString() + nl);
                        SystemInfoBox.AppendText(" Operational status ...................... : " + adapter.OperationalStatus + nl);
                        SystemInfoBox.AppendText(nl);
                    }
                    funcs.AddToOutputCashe("requested network info");
                }
            }
            catch (Exception error)
            {
                funcs.ErrorBoxShow("There was an Error" + nl + "Error: " + error);
                
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher myAudioObject = new ManagementObjectSearcher("select * from Win32_SoundDevice");
                SystemInfoBox.Text = "";
                foreach (ManagementObject obj in myAudioObject.Get())
                {
                    SystemInfoBox.AppendText("Name  -  " + obj["Name"] + nl);
                    SystemInfoBox.AppendText("ProductName  -  " + obj["ProductName"] + nl);
                    SystemInfoBox.AppendText("Availability  -  " + obj["Availability"] + nl);
                    SystemInfoBox.AppendText("DeviceID  -  " + obj["DeviceID"] + nl);
                    SystemInfoBox.AppendText("PowerManagementSupported  -  " + obj["PowerManagementSupported"] + nl);
                    SystemInfoBox.AppendText("Status  -  " + obj["Status"] + nl);
                    SystemInfoBox.AppendText("StatusInfo  -  " + obj["StatusInfo"] + nl);
                    SystemInfoBox.AppendText(String.Empty.PadLeft(obj["ProductName"].ToString().Length, '=') + nl);
                }
                funcs.AddToOutputCashe("requested sound card info");
            }
            catch (Exception error)
            {
                funcs.ErrorBoxShow("There was an Error" + nl + "Error: " + error);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher myPrinterObject = new ManagementObjectSearcher("select * from Win32_Printer");
                SystemInfoBox.Text = "";
                foreach (ManagementObject obj in myPrinterObject.Get())
                {
                    SystemInfoBox.AppendText("Name  -  " + obj["Name"] + nl);
                    SystemInfoBox.AppendText("Network  -  " + obj["Network"] + nl);
                    SystemInfoBox.AppendText("Availability  -  " + obj["Availability"] + nl);
                    SystemInfoBox.AppendText("Is default printer  -  " + obj["Default"] + nl);
                    SystemInfoBox.AppendText("DeviceID  -  " + obj["DeviceID"] + nl);
                    SystemInfoBox.AppendText("Status  -  " + obj["Status"] + nl);
                    SystemInfoBox.AppendText(String.Empty.PadLeft(obj["Name"].ToString().Length, '=') + nl);
                    SystemInfoBox.AppendText(nl);
                }
                funcs.AddToOutputCashe("requested printer info");
            }
            catch (Exception error)
            {
                funcs.ErrorBoxShow("There was an Error" + nl + "Error: " + error);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will cause you to lose any unsaved work, close now?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                MessageBox.Show("Did not close", "Confirmation");
            }
                
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;

                textBox1.Text = filepath;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string filepathtostart = textBox1.Text;
                Process.Start(filepathtostart);
                MessageBox.Show("Successfully opened " + qu + filepathtostart + qu, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                funcs.AddToOutputCashe("opened " + filepathtostart);
            }
            catch (Exception error)
            {
                MessageBox.Show("Make sure the file is a file that can be opened by the filesystem" + nl + "Error: " + error, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        public void Autoclicker()
        {
            while (true)
            {
                if (clickingAblilty == true)
                {
                    Imports.mouse_event(dwFlags: MOUSEEVENTF_LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    Imports.mouse_event(dwFlags: MOUSEEVENTF_LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(intervals);
                }
                Thread.Sleep(2);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Autoclickercheck.Checked)
            {
                Intervalsbox.Visible = true;
                intervallabel.Visible = true;
                startautobutton.Visible = true;
                stopautobutton.Visible = true;
                applybutton.Visible = true;
                Intervalsbox.Enabled = true;
                intervallabel.Enabled = true;
                startautobutton.Enabled = true;
                stopautobutton.Enabled = true;
                applybutton.Enabled = true;
                funcs.AddToOutputCashe("enabled autoclicker");
            }
            else
            {
                Intervalsbox.Visible = false;
                intervallabel.Visible = false;
                startautobutton.Visible = false;
                stopautobutton.Visible = false;
                applybutton.Visible = false;
                Intervalsbox.Enabled = false;
                intervallabel.Enabled = false;
                startautobutton.Enabled = false;
                stopautobutton.Enabled = false;
                applybutton.Enabled = false;
                funcs.AddToOutputCashe("disabled autoclicker");
            }
        }

        

        private void button10_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Intervalsbox.Text, out parsedvalue))
            {
                MessageBox.Show("You need to enter a valid real number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(parsedvalue < 1)
                {
                    MessageBox.Show("You need to enter a number that is not a negative interger or zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    intervals = int.Parse(Intervalsbox.Text);
                    MessageBox.Show("Successfully applied number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void startautobutton_Click(object sender, EventArgs e)
        {
            clickingAblilty = true;
            funcs.AddToOutputCashe("started autoclicker");
        }

        private void stopautobutton_Click(object sender, EventArgs e)
        {
            clickingAblilty = false;
            funcs.AddToOutputCashe("stoped autoclicker");
        }

       

        public void Keypres()
        {
            
            while (true)
            {

                if (Autoclickercheck.Checked)
                {

                    
                    if (Imports.GetAsyncKeyState(Keys.F9) < 0)
                    {
                        clickingAblilty = false;
                    }
                    else if (Imports.GetAsyncKeyState(Keys.F8) < 0)
                    {
                        clickingAblilty = true;
                    }                                         
                    
                }
                else if (CursorDebugCheckBox.Checked)
                {
                    if (Imports.GetAsyncKeyState(Keys.F1) < 0)
                    {
                        int posX = MousePosition.X;
                        int posY = MousePosition.Y;
                        SystemInfoBox.Text = "";
                        SystemInfoBox.AppendText("Xpos: " + posX.ToString() + nl + "Ypos: " + posY.ToString() + nl);
                    }
                }
                Thread.Sleep(1);
            }
        }

        

        private void printcorrdsbutton_Click(object sender, EventArgs e)
        {
            int posX = MousePosition.X;
            int posY = MousePosition.Y;
            SystemInfoBox.AppendText("Xpos: " + posX.ToString() + nl + "Ypos: " + posY.ToString() + nl);
        }
        

        

        private void button10_Click_2(object sender, EventArgs e)
        {
            EditorForm editorwindow = new EditorForm();
            editorwindow.Show();
            funcs.AddToOutputCashe("opened Js editor");

        }

        private void ListProcces_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Process[] currentprocces = Process.GetProcesses();

                foreach (Process process in currentprocces)
                {


                    curappopbox.AppendText("Procces: " + process.ProcessName + nl);
                    curappopbox.AppendText("    ID   :" + process.Id + nl);
                    curappopbox.AppendText("    Title:" + process.MainWindowTitle + nl);
                    curappopbox.AppendText(nl);

                }
            }
            catch (Exception error)
            {
                funcs.ErrorBoxShow("There was an Error" + nl + "Error: " + error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PerformaceGraphsForm perforamcewindow = new PerformaceGraphsForm();
            perforamcewindow.Show();
            funcs.AddToOutputCashe("opened performance graphs");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CalculatorForm calcwindow = new CalculatorForm();
            calcwindow.Show();
            funcs.AddToOutputCashe("opened calculator");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            OutputForm outwindow = new OutputForm();
            outwindow.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            funcs.AddToOutputCashe("clicked Form1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            PasswordCreatorForm passwid = new PasswordCreatorForm();
            passwid.Show();
            funcs.AddToOutputCashe("Opened password generator");
        }

        

        private void button16_Click(object sender, EventArgs e)
        {
            bool isAdmin;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);

                // If is administrator, the variable updates from False to True
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            var yes = new ProcessStartInfo();
            var tokill = Process.GetCurrentProcess();
            if (isAdmin)
            {
                injector idk = new injector();
                idk.Show();
            } else
            {
                if (funcs.QuestionBoxShow("Helpful debugger does not have admin permissions and therefor cannot start the Dll Injortor note: this could cause you to lose unsaved work, Restart now?"))
                {
                    try
                    {
                        yes.UseShellExecute = true;
                        yes.WorkingDirectory = Environment.CurrentDirectory;
                        yes.FileName = Application.ExecutablePath;
                        yes.Verb = "runas";
                        Process.Start(yes);
                        tokill.Kill();
                    }
                    catch (Exception er)
                    {
                        if (funcs.ErrorBoxYesNo("Procces was either denied admin or there was an error, see error?"))
                        {
                            funcs.ErrorBoxShow(er.ToString());
                        }
                    }

                }
            }
               
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CalcHistoryform c = new CalcHistoryform();
            c.Show();
            funcs.AddToOutputCashe("Started calc history form");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TaskMan taskMan = new TaskMan();
            taskMan.Show();
        }
    }
}
