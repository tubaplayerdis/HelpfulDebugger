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


namespace Helpful_debuger
{
    

    public partial class Form1 : Form
    {
        string nl = "\r\n";
        string qu = "\"";

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public bool clickingAblilty = false;
        public int intervals = 1000;
        public int parsedvalue;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            var t1 = Task.Run(() => CursorLOL());
            var t2 = Task.Run(() => UpdateBoxWithApps());
            var t4 = Task.Run(() => Autoclicker());
            var t5 = Task.Run(() => Keypres());
            
            
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CursorDebugCheckBox.Checked)
            {
                CursorPosBox.Visible = true;
                CursorPosBox.Enabled = true;
                CursorPosBox2.Visible = true;
                CursorPosBox2.Enabled = true;
            }
            else
            {
                CursorPosBox.Visible = false;
                CursorPosBox.Enabled = false;
                CursorPosBox2.Visible = false;
                CursorPosBox2.Enabled = false;
            }
            //69 8======= > {()}
            

        }

        
        public void CursorLOL()
        {
            
            while (true)
            {
                int posX = MousePosition.X;
                int posY = MousePosition.Y;
                CursorPosBox.Text = "Xpos: " + posX.ToString();
                CursorPosBox2.Text = "Ypos: " + posY.ToString();
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

       

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SystemInfoBox.Text = "";
            MessageBox.Show("Successfully cleared text"); 
            
        }

        private void Requestdrivebutton_Click(object sender, EventArgs e)
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


        }

        private void RequestOSinfobutton_Click(object sender, EventArgs e)
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
        }

        private void ntrebut_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdateBoxWithApps()
        {
            Process[] currentprocces = Process.GetProcesses();

            foreach (Process process in currentprocces)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {

                    curappopbox.AppendText("Procces: " + process.ProcessName + nl);
                    curappopbox.AppendText("    ID   :" + process.Id + nl);
                    curappopbox.AppendText("    Title:" + process.MainWindowTitle + nl);
                    curappopbox.AppendText(nl);
                }
            }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            var t3 = Task.Run(() => UpdateBoxWithApps());
            MessageBox.Show("Successfully Refreshed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string proccesname = Killbynamebox.Text;
            Process[] getbyname = Process.GetProcessesByName(proccesname);
            if (getbyname.Length == 0)
            {
                
                MessageBox.Show("The process name " + qu + proccesname + qu + " does not exist");
            }
            else
            {
                foreach(var proccesvar in getbyname)
                {
                    try
                    {
                        proccesvar.Kill();
                        MessageBox.Show("Killed " + qu + proccesname + qu);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Process " + qu + proccesname + qu + "does not exist therefore it cannot be terminated, if you are seeing this it is a bug");
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
                    MessageBox.Show("Killed " + qu + value + qu + "Successfully");
                }
                catch (Exception)
                {
                    MessageBox.Show("The process id " + qu + value + qu + " does not exist");
                }

                               
            }
            else
            {
                MessageBox.Show("Please enter a 5 digit number");
            }
        }

        private void Infobutton_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Drive " + qu + d + qu + " Was not ready, the drive may be corrupted or missing, let the request finish then request again");
                    SystemInfoBox.AppendText(nl);
                }
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            SystemInfoBox.Text = "";
            if (nics == null || nics.Length < 1)
            {
                SystemInfoBox.AppendText("No network interfaces found.");
                MessageBox.Show("No network interfaces were found, either this program is blocked from the internet or your ethernet/wifi or both is not on");
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
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
        }

        private void button6_Click(object sender, EventArgs e)
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
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
                MessageBox.Show("Successfully opened " + qu + filepathtostart + qu);
            }
            catch (Exception)
            {
                MessageBox.Show("make sure the file is a file that can be opened by the filesystem");
            }
        }

        public void Autoclicker()
        {
            while (true)
            {
                if (clickingAblilty == true)
                {
                    mouse_event(dwFlags: MOUSEEVENTF_LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    mouse_event(dwFlags: MOUSEEVENTF_LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
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
                
            }
        }

        

        private void button10_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Intervalsbox.Text, out parsedvalue))
            {
                MessageBox.Show("You need to enter a valid real number");
                return;
            }
            else
            {
                if(parsedvalue < 1)
                {
                    MessageBox.Show("You need to enter a number that is not a negative interger or zero");
                    return;
                }
                else
                {
                    intervals = int.Parse(Intervalsbox.Text);
                    MessageBox.Show("Successfully applied number");
                }
                
            }
        }

        private void startautobutton_Click(object sender, EventArgs e)
        {
            clickingAblilty = true;
        }

        private void stopautobutton_Click(object sender, EventArgs e)
        {
            clickingAblilty = false;
        }

       

        public void Keypres()
        {
            while (true)
            {
                if (Autoclickercheck.Checked)
                {
                    if (GetAsyncKeyState(Keys.F9) < 0)
                    {
                        clickingAblilty = false;
                    }
                    else if (GetAsyncKeyState(Keys.F8) < 0)
                    {
                        clickingAblilty = true;
                    }
                    Thread.Sleep(1);
                }
            }
        }
    }
}
