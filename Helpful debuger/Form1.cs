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

namespace Helpful_debuger
{
    

    public partial class Form1 : Form
    {
        string nl = "\r\n";
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            var t1 = Task.Run(() => CursorLOL());
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CursorPosBox.Visible = !CursorPosBox.Visible;
            CursorPosBox.Enabled = !CursorPosBox.Enabled;
            CursorPosBox2.Visible = !CursorPosBox2.Visible;
            CursorPosBox2.Enabled = !CursorPosBox2.Enabled;

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

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject obj in myVideoObject.Get())
            {
                SystemInfoBox.AppendText("Name  -  " + obj["Name"] + nl);
                SystemInfoBox.AppendText("Status  -  " + obj["Status"] + nl);
                SystemInfoBox.AppendText("Caption  -  " + obj["Caption"] + nl);
                SystemInfoBox.AppendText("DeviceID  -  " + obj["DeviceID"] + nl);
                SystemInfoBox.AppendText("AdapterRAM  -  " + obj["AdapterRAM"] + nl);
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
            MessageBox.Show("Successfully cleared text"); // 8===== > {()} 69 nine lol
            
        }

        private void Requestdrivebutton_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                SystemInfoBox.Text = "Name  -  " + obj["Name"] + nl + "DeviceID  -  " + obj["DeviceID"] + nl + "Manufacturer  -  " + obj["Manufacturer"] + "CurrentClockSpeed  -  " + obj["CurrentClockSpeed"] + nl + "Caption  -  " + obj["Caption"] + nl + "Caption  -  " + obj["Caption"] + nl + "NumberOfCores  -  " + obj["NumberOfCores"] + nl + "NumberOfEnabledCore(s)  -  " + obj["NumberOfEnabledCore"] + nl + "NumberOfLogicalProcessors  -  " + obj["NumberOfLogicalProcessors"] + nl + "Architecture  -  " + obj["Architecture"] + nl + "Family  -  " + obj["Family"] + nl + "ProcessorType  -  " + obj["ProcessorType"] + nl + "Characteristics  -  " + obj["Characteristics"] + nl + "AddressWidth  -  " + obj["AddressWidth"];

            }


        }

        private void RequestOSinfobutton_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                SystemInfoBox.Text = "Caption  -  " + obj["Caption"] + nl + "WindowsDirectory  -  " + obj["WindowsDirectory"] + nl + "ProductType  -  " + obj["ProductType"] + nl + "SerialNumber  -  " + obj["SerialNumber"] + nl + "SystemDirectory  -  " + obj["SystemDirectory"] + nl + "CountryCode  -  " + obj["CountryCode"] + nl + "CurrentTimeZone  -  " + obj["CurrentTimeZone"] + nl + "EncryptionLevel  -  " + obj["EncryptionLevel"] + nl + "OSType  -  " + obj["OSType"] + nl + "Version  -  " + obj["Version"];
            }
        }

        private void ntrebut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
