using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using Helpful_debuger;


namespace Helpful_debugger
{
    public partial class PerformaceGraphsForm : Form
    {
        int x = 0;
        List<Point> cpu_pt = new List<Point>();
        List<Point> ram_pt = new List<Point>();
        List<Point> disk_pt = new List<Point>();
        List<Point> cus_pt = new List<Point>();

        Functions funcs = new Functions();


        HatchBrush CrossColorpriv = new HatchBrush(HatchStyle.Cross, Color.MediumBlue);

        Pen LineColorpriv = new Pen(new SolidBrush(Color.White));


        PerformanceCounterCategory pcc;

        PerformanceCounterCategory[] categories;

        PerformanceCounterCategory pcc1;

        PerformanceCounter[] pcc2;

        public PerformaceGraphsForm()
        {
            InitializeComponent();
        }

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
            if(MessageBox.Show(Message, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                return true;
                
            }
            else
            {
                
                return false;
            }
        }

        

        private void ReturnTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                x += 2;
                int cpu_val = picturebox1.Height * (int)Math.Round(pCPU.NextValue()) / 100;
                int ram_val = picturebox2.Height * (int)Math.Round(pRAM.NextValue()) / 100;
                int disk_val = pictureBox3.Height * (int)Math.Round(pDisk.NextValue()) / 100;
                int cus_val = pictureBox4.Height * (int)Math.Round(Custom.NextValue()) / 100;

                cpu_pt.Add(new Point(x, picturebox1.Height - cpu_val));
                ram_pt.Add(new Point(x, picturebox2.Height - ram_val));
                disk_pt.Add(new Point(x, pictureBox3.Height - disk_val));
                cus_pt.Add(new Point(x, pictureBox4.Height - cus_val));
                cpupercenlabel.Text = cpu_val.ToString() + "%";
                memeperleabel.Text = ram_val.ToString() + "%";
                Dusagela.Text = disk_val.ToString() + "%";
                CusLab.Text = cus_val.ToString();
                picturebox1.Invalidate();
                picturebox2.Invalidate();
                pictureBox3.Invalidate();
                pictureBox4.Invalidate();
            } catch(Exception error)
            {
                
                Custom.CategoryName = "Process";
                Custom.CounterName = "% User Time";
                Custom.InstanceName = "_Total";
                label8.Text = "Catagory: Process, Instance: _Total, Counter: % User Time";
                funcs.AddToOutputCashe(error.ToString());
                funcs.InfoBoxShow("The Performance counter you entered had an error");
                
            }
            
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (x > picturebox1.Width || x > picturebox2.Width || x > pictureBox3.Width || x > pictureBox4.Width)
            {
                x = 0;
                cpu_pt.Clear();
                ram_pt.Clear();
                disk_pt.Clear();
                cus_pt.Clear();
            }
            
            g.FillRectangle(CrossColorpriv, picturebox1.ClientRectangle);
            
            if (cpu_pt.Count > 1)
            {
                g.DrawLines(LineColorpriv, cpu_pt.ToArray());
                
                
            }
            
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;            
            g.FillRectangle(CrossColorpriv, picturebox1.ClientRectangle);
            if(ram_pt.Count > 1)
            {
                g.DrawLines(LineColorpriv, ram_pt.ToArray());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(CrossColorpriv, picturebox1.ClientRectangle);
            if (disk_pt.Count > 1)
            {
                g.DrawLines(LineColorpriv, disk_pt.ToArray());
            }
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.FillRectangle(CrossColorpriv, picturebox1.ClientRectangle);
            if (cus_pt.Count > 1)
            {
                g.DrawLines(LineColorpriv, cus_pt.ToArray());
            }
        }

        private void SelectDiskBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectDiskBox_DropDown(object sender, EventArgs e)
        {
            GetInstances();
        }

        
        public void GetInstances()
        {
            try
            {
                SelectDiskBox.Items.Clear();

                pcc = new PerformanceCounterCategory("PhysicalDisk");

                string[] instances = pcc.GetInstanceNames();

                foreach(string instancename in instances)
                {
                    SelectDiskBox.Items.Add(instancename);
                    
                }

                


            } catch(Exception eror)
            {
                MessageBox.Show("Error: " + eror);
            }
        }

        private void SelectDiskBox_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void SelectDiskBox_Click(object sender, EventArgs e)
        {
            
            
        }

        private void SelectDiskBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string instacnetocheck = SelectDiskBox.Text;

                if (instacnetocheck == null)
                {
                    MessageBox.Show("You need to select an option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (pcc == null)
                    {
                        MessageBox.Show("Instances have not been made yet, please select a option from the combobox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (pcc.InstanceExists(instacnetocheck))
                        {
                            pDisk.InstanceName = SelectDiskBox.Text;
                            label4.Text = "Disk " + SelectDiskBox.Text + " usage:";
                        }
                        else
                        {
                            MessageBox.Show("That instance name: " + SelectDiskBox.Text + " does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("There was an error " + error.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int result))
            {
                if(result > 10000 || result < 100)
                {
                    WarnBoxShow("Please enter a number inbetween 10,000 and 100");
                }
                else
                {
                    if(QuestionBoxShow("This will change the request interval for the graphs, are you sure?"))
                    {
                        ReturnTimer.Interval = result;
                        funcs.AddToOutputCashe("set new interval");
                    }
                    else
                    {
                        InfoBoxShow("Did not change request interval");
                    }
                }
            }
            else
            {
                ErrorBoxShow("Number could not be parsed, this is probably because the number is to high");
            }
        }

        

        private void ChooseBackroundcolor_button_Click(object sender, EventArgs e)
        {
            if(ChooseBackroundColor.ShowDialog() == DialogResult.OK)
            {
                
                CrossColorpriv = new HatchBrush(HatchStyle.Cross, ChooseBackroundColor.Color);
                InfoBoxShow("Changed color to: " + ChooseBackroundColor.Color.ToString());
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(ChooseGraphLineColor.ShowDialog() == DialogResult.OK)
            {
                LineColorpriv = new Pen(new SolidBrush(ChooseGraphLineColor.Color));
                InfoBoxShow("Changed color to: " + LineColorpriv.Color.ToString());
            }
        }

        private void PerformaceGraphsForm_Activated(object sender, EventArgs e)
        {
            funcs.AddToOutputCashe("clicked Performancegrpahs");
        }

        private void PerformaceGraphsForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            GetCatagoryNames();
        }

        public void GetCatagoryNames()
        {
            comboBoxCounter.Items.Clear();
            comboBoxInstance.Items.Clear();
            categories = PerformanceCounterCategory.GetCategories();

            comboBoxCatagory.Items.Clear();

            foreach (PerformanceCounterCategory category in categories)
            {
                comboBoxCatagory.Items.Add(category.CategoryName);
            }
        }

        public void GetCounterNames()
        {
            comboBoxCounter.Items.Clear();

            if (comboBoxCatagory.Text.Length == 0)
            {
                funcs.InfoBoxShow("You need to select a catagory first");
            }
            else
            {
                pcc1 = new PerformanceCounterCategory(comboBoxCatagory.Text);

                if (pcc1.InstanceExists(comboBoxInstance.Text))
                {
                    pcc2 = pcc1.GetCounters(comboBoxInstance.Text);

                    

                    foreach (PerformanceCounter counter in pcc2)
                    {
                        comboBoxCounter.Items.Add(counter.CounterName);
                    }
                }
                else
                {

                }

                
            }
            

        }

        public void GetINstancesNames()
        {
            comboBoxInstance.Items.Clear();
            comboBoxCounter.Items.Clear();
            if (comboBoxCatagory.Text.Length == 0)
            {
                funcs.InfoBoxShow("You need to select a catagory first");
            }
            else
            {
                
                pcc1 = new PerformanceCounterCategory(comboBoxCatagory.Text);

                string[] instances = pcc1.GetInstanceNames();

                foreach (string instance in instances)
                {
                    comboBoxInstance.Items.Add(instance);
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                PerformanceCounterCategory performance;
                performance = new PerformanceCounterCategory(comboBoxCatagory.Text);
                if(comboBoxCatagory.Text.Length == 0 || !performance.InstanceExists(comboBoxInstance.Text) || !performance.CounterExists(comboBoxCounter.Text))
                {
                    funcs.InfoBoxShow("you need to enter in the information first");
                } else
                {
                    Custom.CategoryName = comboBoxCatagory.Text;
                    Custom.InstanceName = comboBoxInstance.Text;
                    Custom.CounterName = comboBoxCounter.Text;
                    label8.Text = $"Catagory: {comboBoxCatagory.Text}, Instance: {comboBoxInstance.Text}, Counter: {comboBoxCounter.Text}";
                    cus_pt.Clear();
                    funcs.InfoBoxShow("sucsessflly applied settings");
                }
            } catch (Exception ex)
            {
                funcs.ErrorBoxShow("There was an error: " + ex.ToString());
                funcs.AddToOutputCashe("error with performance graphs");
            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            GetCounterNames();
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            GetINstancesNames();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }




        // add option to select which driv you want and it will change the performacnce counter if so
    }
}
