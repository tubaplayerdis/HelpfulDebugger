
namespace Helpful_debugger
{
    partial class PerformaceGraphsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformaceGraphsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.picturebox2 = new System.Windows.Forms.PictureBox();
            this.ReturnTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cpupercenlabel = new System.Windows.Forms.Label();
            this.memeperleabel = new System.Windows.Forms.Label();
            this.pDisk = new System.Diagnostics.PerformanceCounter();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Dusagela = new System.Windows.Forms.Label();
            this.DiskTimer = new System.Windows.Forms.Timer(this.components);
            this.SelectDiskBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ChooseBackroundColor = new System.Windows.Forms.ColorDialog();
            this.ChooseBackroundcolor_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ChooseGraphLineColor = new System.Windows.Forms.ColorDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Custom = new System.Diagnostics.PerformanceCounter();
            this.CusLab = new System.Windows.Forms.Label();
            this.ChooseBeckround = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Custom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Performance Graphs";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor Information";
            this.pCPU.CounterName = "% Processor Utility";
            this.pCPU.InstanceName = "_Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU usage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Memory usage:";
            // 
            // picturebox1
            // 
            this.picturebox1.BackColor = System.Drawing.Color.Black;
            this.picturebox1.Location = new System.Drawing.Point(15, 79);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(406, 52);
            this.picturebox1.TabIndex = 3;
            this.picturebox1.TabStop = false;
            this.picturebox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // picturebox2
            // 
            this.picturebox2.BackColor = System.Drawing.Color.Black;
            this.picturebox2.Location = new System.Drawing.Point(15, 159);
            this.picturebox2.Name = "picturebox2";
            this.picturebox2.Size = new System.Drawing.Size(406, 52);
            this.picturebox2.TabIndex = 4;
            this.picturebox2.TabStop = false;
            this.picturebox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // ReturnTimer
            // 
            this.ReturnTimer.Enabled = true;
            this.ReturnTimer.Interval = 500;
            this.ReturnTimer.Tick += new System.EventHandler(this.ReturnTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1035, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpupercenlabel
            // 
            this.cpupercenlabel.AutoSize = true;
            this.cpupercenlabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpupercenlabel.Location = new System.Drawing.Point(427, 79);
            this.cpupercenlabel.Name = "cpupercenlabel";
            this.cpupercenlabel.Size = new System.Drawing.Size(46, 24);
            this.cpupercenlabel.TabIndex = 6;
            this.cpupercenlabel.Text = "CPU";
            // 
            // memeperleabel
            // 
            this.memeperleabel.AutoSize = true;
            this.memeperleabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memeperleabel.Location = new System.Drawing.Point(427, 159);
            this.memeperleabel.Name = "memeperleabel";
            this.memeperleabel.Size = new System.Drawing.Size(46, 24);
            this.memeperleabel.TabIndex = 7;
            this.memeperleabel.Text = "Mem";
            // 
            // pDisk
            // 
            this.pDisk.CategoryName = "PhysicalDisk";
            this.pDisk.CounterName = "% Disk Time";
            this.pDisk.InstanceName = "0 C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disk 0 C: usage:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(15, 239);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(406, 52);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // Dusagela
            // 
            this.Dusagela.AutoSize = true;
            this.Dusagela.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dusagela.Location = new System.Drawing.Point(427, 239);
            this.Dusagela.Name = "Dusagela";
            this.Dusagela.Size = new System.Drawing.Size(58, 24);
            this.Dusagela.TabIndex = 10;
            this.Dusagela.Text = "Disk";
            // 
            // DiskTimer
            // 
            this.DiskTimer.Enabled = true;
            this.DiskTimer.Interval = 500;
            // 
            // SelectDiskBox
            // 
            this.SelectDiskBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectDiskBox.FormattingEnabled = true;
            this.SelectDiskBox.Location = new System.Drawing.Point(763, 54);
            this.SelectDiskBox.Name = "SelectDiskBox";
            this.SelectDiskBox.Size = new System.Drawing.Size(284, 21);
            this.SelectDiskBox.TabIndex = 11;
            this.SelectDiskBox.DropDown += new System.EventHandler(this.SelectDiskBox_DropDown);
            this.SelectDiskBox.DropDownClosed += new System.EventHandler(this.SelectDiskBox_DropDownClosed);
            this.SelectDiskBox.TextChanged += new System.EventHandler(this.SelectDiskBox_TextChanged);
            this.SelectDiskBox.Click += new System.EventHandler(this.SelectDiskBox_Click);
            this.SelectDiskBox.Leave += new System.EventHandler(this.SelectDiskBox_Leave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(763, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Apply disk";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(759, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Disk to show in graph";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(759, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(750, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Interval to request new data(ms)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(763, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(763, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 25);
            this.button3.TabIndex = 17;
            this.button3.Text = "Apply Interval";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChooseBackroundColor
            // 
            this.ChooseBackroundColor.AnyColor = true;
            this.ChooseBackroundColor.ShowHelp = true;
            this.ChooseBackroundColor.SolidColorOnly = true;
            // 
            // ChooseBackroundcolor_button
            // 
            this.ChooseBackroundcolor_button.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseBackroundcolor_button.Location = new System.Drawing.Point(763, 365);
            this.ChooseBackroundcolor_button.Name = "ChooseBackroundcolor_button";
            this.ChooseBackroundcolor_button.Size = new System.Drawing.Size(284, 26);
            this.ChooseBackroundcolor_button.TabIndex = 19;
            this.ChooseBackroundcolor_button.Text = "Choose Cross Pattern Color";
            this.ChooseBackroundcolor_button.UseVisualStyleBackColor = true;
            this.ChooseBackroundcolor_button.Click += new System.EventHandler(this.ChooseBackroundcolor_button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(763, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(284, 26);
            this.button4.TabIndex = 20;
            this.button4.Text = "Choose Graph Line Color";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ChooseGraphLineColor
            // 
            this.ChooseGraphLineColor.AnyColor = true;
            this.ChooseGraphLineColor.ShowHelp = true;
            this.ChooseGraphLineColor.SolidColorOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(580, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Catagory: Process, Instance: _Total, Counter: % User Time";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(15, 319);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(406, 52);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(849, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(759, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Catagory for customizable graph";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(763, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(768, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Instance for customizable graph";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(763, 307);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(284, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.DropDown += new System.EventHandler(this.comboBox2_DropDown);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(763, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(284, 25);
            this.button5.TabIndex = 28;
            this.button5.Text = "Apply custom graph";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(763, 261);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(284, 21);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.DropDown += new System.EventHandler(this.comboBox3_DropDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(768, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(279, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "counter for customizable graph";
            // 
            // Custom
            // 
            this.Custom.CategoryName = "Process";
            this.Custom.CounterName = "% User Time";
            this.Custom.InstanceName = "_Total";
            // 
            // CusLab
            // 
            this.CusLab.AutoSize = true;
            this.CusLab.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusLab.Location = new System.Drawing.Point(427, 319);
            this.CusLab.Name = "CusLab";
            this.CusLab.Size = new System.Drawing.Size(82, 24);
            this.CusLab.TabIndex = 31;
            this.CusLab.Text = "Custom";
            // 
            // ChooseBeckround
            // 
            this.ChooseBeckround.AnyColor = true;
            this.ChooseBeckround.ShowHelp = true;
            this.ChooseBeckround.SolidColorOnly = true;
            // 
            // PerformaceGraphsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 463);
            this.Controls.Add(this.CusLab);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ChooseBackroundcolor_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SelectDiskBox);
            this.Controls.Add(this.Dusagela);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memeperleabel);
            this.Controls.Add(this.cpupercenlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picturebox2);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1075, 489);
            this.Name = "PerformaceGraphsForm";
            this.Text = "Helpful Debugger - Performace Graphs";
            this.Activated += new System.EventHandler(this.PerformaceGraphsForm_Activated);
            this.Load += new System.EventHandler(this.PerformaceGraphsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Custom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.PictureBox picturebox2;
        private System.Windows.Forms.Timer ReturnTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cpupercenlabel;
        private System.Windows.Forms.Label memeperleabel;
        private System.Diagnostics.PerformanceCounter pDisk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Dusagela;
        private System.Windows.Forms.Timer DiskTimer;
        private System.Windows.Forms.ComboBox SelectDiskBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog ChooseBackroundColor;
        private System.Windows.Forms.Button ChooseBackroundcolor_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog ChooseGraphLineColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;
        private System.Diagnostics.PerformanceCounter Custom;
        private System.Windows.Forms.Label CusLab;
        private System.Windows.Forms.ColorDialog ChooseBeckround;
    }
}