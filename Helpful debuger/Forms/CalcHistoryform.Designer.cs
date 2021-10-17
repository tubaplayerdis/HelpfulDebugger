
namespace Helpful_debugger.Forms
{
    partial class CalcHistoryform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcHistoryform));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Calchistorybox = new System.Windows.Forms.TextBox();
            this.UpdateCalcHistoryBox = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(776, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close Calculator History";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete Calculator History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calchistorybox
            // 
            this.Calchistorybox.Location = new System.Drawing.Point(12, 12);
            this.Calchistorybox.Multiline = true;
            this.Calchistorybox.Name = "Calchistorybox";
            this.Calchistorybox.ReadOnly = true;
            this.Calchistorybox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Calchistorybox.Size = new System.Drawing.Size(776, 473);
            this.Calchistorybox.TabIndex = 5;
            // 
            // UpdateCalcHistoryBox
            // 
            this.UpdateCalcHistoryBox.WorkerSupportsCancellation = true;
            this.UpdateCalcHistoryBox.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UpdateCalcHistoryBox_DoWork);
            // 
            // CalcHistoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.Calchistorybox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 612);
            this.Name = "CalcHistoryform";
            this.Text = "Helpful Debugger - Calculator History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalcHistoryform_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Calchistorybox;
        public System.ComponentModel.BackgroundWorker UpdateCalcHistoryBox;
    }
}