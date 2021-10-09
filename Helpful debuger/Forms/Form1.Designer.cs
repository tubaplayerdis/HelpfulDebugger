
namespace Helpful_debuger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CursorDebugCheckBox = new System.Windows.Forms.CheckBox();
            this.CursorPosBox = new System.Windows.Forms.TextBox();
            this.CursorPosBox2 = new System.Windows.Forms.TextBox();
            this.SystemInfoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RequestCPUbutton = new System.Windows.Forms.Button();
            this.RequestOSinfobutton = new System.Windows.Forms.Button();
            this.curappopbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Killbynamebox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IdKillbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Infobutton = new System.Windows.Forms.Button();
            this.harddriveinfo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.Autoclickercheck = new System.Windows.Forms.CheckBox();
            this.Intervalsbox = new System.Windows.Forms.TextBox();
            this.intervallabel = new System.Windows.Forms.Label();
            this.startautobutton = new System.Windows.Forms.Button();
            this.stopautobutton = new System.Windows.Forms.Button();
            this.applybutton = new System.Windows.Forms.Button();
            this.printcorrdsbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.ListProccesWorker = new System.ComponentModel.BackgroundWorker();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CursorDebugCheckBox
            // 
            this.CursorDebugCheckBox.AutoSize = true;
            this.CursorDebugCheckBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.CursorDebugCheckBox.Location = new System.Drawing.Point(878, 314);
            this.CursorDebugCheckBox.Name = "CursorDebugCheckBox";
            this.CursorDebugCheckBox.Size = new System.Drawing.Size(136, 23);
            this.CursorDebugCheckBox.TabIndex = 0;
            this.CursorDebugCheckBox.Text = "Cursor debug";
            this.CursorDebugCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CursorDebugCheckBox.UseVisualStyleBackColor = true;
            this.CursorDebugCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CursorPosBox
            // 
            this.CursorPosBox.Enabled = false;
            this.CursorPosBox.Location = new System.Drawing.Point(878, 343);
            this.CursorPosBox.Multiline = true;
            this.CursorPosBox.Name = "CursorPosBox";
            this.CursorPosBox.ReadOnly = true;
            this.CursorPosBox.Size = new System.Drawing.Size(75, 20);
            this.CursorPosBox.TabIndex = 1;
            this.CursorPosBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CursorPosBox.Visible = false;
            // 
            // CursorPosBox2
            // 
            this.CursorPosBox2.Enabled = false;
            this.CursorPosBox2.Location = new System.Drawing.Point(959, 343);
            this.CursorPosBox2.Multiline = true;
            this.CursorPosBox2.Name = "CursorPosBox2";
            this.CursorPosBox2.ReadOnly = true;
            this.CursorPosBox2.Size = new System.Drawing.Size(75, 20);
            this.CursorPosBox2.TabIndex = 2;
            this.CursorPosBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CursorPosBox2.Visible = false;
            // 
            // SystemInfoBox
            // 
            this.SystemInfoBox.Location = new System.Drawing.Point(177, 39);
            this.SystemInfoBox.Multiline = true;
            this.SystemInfoBox.Name = "SystemInfoBox";
            this.SystemInfoBox.ReadOnly = true;
            this.SystemInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SystemInfoBox.Size = new System.Drawing.Size(319, 358);
            this.SystemInfoBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Request GPU info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(177, 405);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(319, 33);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear text";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RequestCPUbutton
            // 
            this.RequestCPUbutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestCPUbutton.Location = new System.Drawing.Point(8, 95);
            this.RequestCPUbutton.Name = "RequestCPUbutton";
            this.RequestCPUbutton.Size = new System.Drawing.Size(159, 50);
            this.RequestCPUbutton.TabIndex = 6;
            this.RequestCPUbutton.Text = "Request CPU info";
            this.RequestCPUbutton.UseVisualStyleBackColor = true;
            this.RequestCPUbutton.Click += new System.EventHandler(this.Requestdrivebutton_Click);
            // 
            // RequestOSinfobutton
            // 
            this.RequestOSinfobutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestOSinfobutton.Location = new System.Drawing.Point(8, 151);
            this.RequestOSinfobutton.Name = "RequestOSinfobutton";
            this.RequestOSinfobutton.Size = new System.Drawing.Size(159, 43);
            this.RequestOSinfobutton.TabIndex = 7;
            this.RequestOSinfobutton.Text = "Request OS info";
            this.RequestOSinfobutton.UseVisualStyleBackColor = true;
            this.RequestOSinfobutton.Click += new System.EventHandler(this.RequestOSinfobutton_Click);
            // 
            // curappopbox
            // 
            this.curappopbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curappopbox.Location = new System.Drawing.Point(502, 39);
            this.curappopbox.Multiline = true;
            this.curappopbox.Name = "curappopbox";
            this.curappopbox.ReadOnly = true;
            this.curappopbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.curappopbox.Size = new System.Drawing.Size(366, 358);
            this.curappopbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current processes running";
            // 
            // refreshbutton
            // 
            this.refreshbutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbutton.Location = new System.Drawing.Point(502, 405);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(366, 33);
            this.refreshbutton.TabIndex = 10;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Info box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(874, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kill process by name";
            // 
            // Killbynamebox
            // 
            this.Killbynamebox.Location = new System.Drawing.Point(878, 44);
            this.Killbynamebox.Name = "Killbynamebox";
            this.Killbynamebox.Size = new System.Drawing.Size(371, 20);
            this.Killbynamebox.TabIndex = 13;
            this.Killbynamebox.Text = "Enter processes name here";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(878, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(371, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Kill by name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(874, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kill process by ID";
            // 
            // IdKillbox
            // 
            this.IdKillbox.Location = new System.Drawing.Point(878, 128);
            this.IdKillbox.Name = "IdKillbox";
            this.IdKillbox.Size = new System.Drawing.Size(371, 20);
            this.IdKillbox.TabIndex = 16;
            this.IdKillbox.Text = "Enter processes ID here";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(878, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(371, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Kill by ID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Infobutton
            // 
            this.Infobutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infobutton.Location = new System.Drawing.Point(878, 405);
            this.Infobutton.Name = "Infobutton";
            this.Infobutton.Size = new System.Drawing.Size(185, 33);
            this.Infobutton.TabIndex = 18;
            this.Infobutton.Text = "Information";
            this.Infobutton.UseVisualStyleBackColor = true;
            this.Infobutton.Click += new System.EventHandler(this.Infobutton_Click);
            // 
            // harddriveinfo
            // 
            this.harddriveinfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddriveinfo.Location = new System.Drawing.Point(8, 200);
            this.harddriveinfo.Name = "harddriveinfo";
            this.harddriveinfo.Size = new System.Drawing.Size(159, 56);
            this.harddriveinfo.TabIndex = 19;
            this.harddriveinfo.Text = "Request Drive(s) info";
            this.harddriveinfo.UseVisualStyleBackColor = true;
            this.harddriveinfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(8, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 58);
            this.button4.TabIndex = 20;
            this.button4.Text = "Request Network info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(8, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 50);
            this.button5.TabIndex = 21;
            this.button5.Text = "Request Sound Card(s) info";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(8, 382);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 56);
            this.button6.TabIndex = 22;
            this.button6.Text = "Request Printer(s) info";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(276, 444);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(333, 33);
            this.button7.TabIndex = 23;
            this.button7.Text = "Close Helpful Debugger";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(878, 275);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(371, 33);
            this.button9.TabIndex = 25;
            this.button9.Text = "Start process";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(874, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Start process by filepath";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(878, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Enter executable filepath here";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Executable Files|*.exe";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(878, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(371, 27);
            this.button8.TabIndex = 28;
            this.button8.Text = "Select process";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Autoclickercheck
            // 
            this.Autoclickercheck.AutoSize = true;
            this.Autoclickercheck.Font = new System.Drawing.Font("Consolas", 12F);
            this.Autoclickercheck.Location = new System.Drawing.Point(1043, 314);
            this.Autoclickercheck.Name = "Autoclickercheck";
            this.Autoclickercheck.Size = new System.Drawing.Size(136, 23);
            this.Autoclickercheck.TabIndex = 29;
            this.Autoclickercheck.Text = "Auto Clicker";
            this.Autoclickercheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autoclickercheck.UseVisualStyleBackColor = true;
            this.Autoclickercheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Intervalsbox
            // 
            this.Intervalsbox.Enabled = false;
            this.Intervalsbox.Location = new System.Drawing.Point(1043, 343);
            this.Intervalsbox.Name = "Intervalsbox";
            this.Intervalsbox.Size = new System.Drawing.Size(65, 20);
            this.Intervalsbox.TabIndex = 30;
            this.Intervalsbox.Text = "1000";
            this.Intervalsbox.Visible = false;
            // 
            // intervallabel
            // 
            this.intervallabel.AutoSize = true;
            this.intervallabel.Enabled = false;
            this.intervallabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervallabel.Location = new System.Drawing.Point(1114, 347);
            this.intervallabel.Name = "intervallabel";
            this.intervallabel.Size = new System.Drawing.Size(85, 13);
            this.intervallabel.TabIndex = 31;
            this.intervallabel.Text = "Intervals(ms)";
            this.intervallabel.Visible = false;
            // 
            // startautobutton
            // 
            this.startautobutton.Enabled = false;
            this.startautobutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startautobutton.Location = new System.Drawing.Point(1043, 369);
            this.startautobutton.Name = "startautobutton";
            this.startautobutton.Size = new System.Drawing.Size(101, 33);
            this.startautobutton.TabIndex = 32;
            this.startautobutton.Text = "Start(F8)";
            this.startautobutton.UseVisualStyleBackColor = true;
            this.startautobutton.Visible = false;
            this.startautobutton.Click += new System.EventHandler(this.startautobutton_Click);
            // 
            // stopautobutton
            // 
            this.stopautobutton.Enabled = false;
            this.stopautobutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopautobutton.Location = new System.Drawing.Point(1150, 369);
            this.stopautobutton.Name = "stopautobutton";
            this.stopautobutton.Size = new System.Drawing.Size(99, 33);
            this.stopautobutton.TabIndex = 33;
            this.stopautobutton.Text = "Stop(F9)";
            this.stopautobutton.UseVisualStyleBackColor = true;
            this.stopautobutton.Visible = false;
            this.stopautobutton.Click += new System.EventHandler(this.stopautobutton_Click);
            // 
            // applybutton
            // 
            this.applybutton.Enabled = false;
            this.applybutton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applybutton.Location = new System.Drawing.Point(1200, 343);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(49, 20);
            this.applybutton.TabIndex = 34;
            this.applybutton.Text = "Apply";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Visible = false;
            this.applybutton.Click += new System.EventHandler(this.button10_Click);
            // 
            // printcorrdsbutton
            // 
            this.printcorrdsbutton.Enabled = false;
            this.printcorrdsbutton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printcorrdsbutton.Location = new System.Drawing.Point(878, 369);
            this.printcorrdsbutton.Name = "printcorrdsbutton";
            this.printcorrdsbutton.Size = new System.Drawing.Size(156, 33);
            this.printcorrdsbutton.TabIndex = 35;
            this.printcorrdsbutton.Text = "Print coords(F1)";
            this.printcorrdsbutton.UseVisualStyleBackColor = true;
            this.printcorrdsbutton.Visible = false;
            this.printcorrdsbutton.Click += new System.EventHandler(this.printcorrdsbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Helpful Debugger";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(1069, 405);
            this.button10.MinimumSize = new System.Drawing.Size(179, 33);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(180, 33);
            this.button10.TabIndex = 47;
            this.button10.Text = "Open JS editor";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_2);
            // 
            // ListProccesWorker
            // 
            this.ListProccesWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ListProcces_DoWork);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(8, 444);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(262, 33);
            this.button12.TabIndex = 48;
            this.button12.Text = "Open Performace Graphs";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(929, 444);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(320, 33);
            this.button13.TabIndex = 49;
            this.button13.Text = "Open Calculator";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(615, 444);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(308, 33);
            this.button11.TabIndex = 50;
            this.button11.Text = "Open Output Log";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 484);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.printcorrdsbutton);
            this.Controls.Add(this.applybutton);
            this.Controls.Add(this.stopautobutton);
            this.Controls.Add(this.startautobutton);
            this.Controls.Add(this.intervallabel);
            this.Controls.Add(this.Intervalsbox);
            this.Controls.Add(this.Autoclickercheck);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.harddriveinfo);
            this.Controls.Add(this.Infobutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.IdKillbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Killbynamebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.curappopbox);
            this.Controls.Add(this.RequestOSinfobutton);
            this.Controls.Add(this.RequestCPUbutton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SystemInfoBox);
            this.Controls.Add(this.CursorPosBox2);
            this.Controls.Add(this.CursorPosBox);
            this.Controls.Add(this.CursorDebugCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1276, 523);
            this.Name = "Form1";
            this.Text = "Helpful Debugger Release 1.0";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CursorDebugCheckBox;
        private System.Windows.Forms.TextBox CursorPosBox;
        private System.Windows.Forms.TextBox CursorPosBox2;
        private System.Windows.Forms.TextBox SystemInfoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RequestCPUbutton;
        private System.Windows.Forms.Button RequestOSinfobutton;
        private System.Windows.Forms.TextBox curappopbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Killbynamebox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdKillbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Infobutton;
        private System.Windows.Forms.Button harddriveinfo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.CheckBox Autoclickercheck;
        private System.Windows.Forms.TextBox Intervalsbox;
        private System.Windows.Forms.Label intervallabel;
        private System.Windows.Forms.Button startautobutton;
        private System.Windows.Forms.Button stopautobutton;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.Button printcorrdsbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.ComponentModel.BackgroundWorker ListProccesWorker;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
    }
}

