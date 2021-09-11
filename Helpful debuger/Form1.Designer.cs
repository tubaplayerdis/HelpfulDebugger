
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
            this.Requestdrivebutton = new System.Windows.Forms.Button();
            this.RequestOSinfobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CursorDebugCheckBox
            // 
            this.CursorDebugCheckBox.AutoSize = true;
            this.CursorDebugCheckBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.CursorDebugCheckBox.Location = new System.Drawing.Point(12, 10);
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
            this.CursorPosBox.Location = new System.Drawing.Point(12, 39);
            this.CursorPosBox.Multiline = true;
            this.CursorPosBox.Name = "CursorPosBox";
            this.CursorPosBox.ReadOnly = true;
            this.CursorPosBox.Size = new System.Drawing.Size(136, 25);
            this.CursorPosBox.TabIndex = 1;
            this.CursorPosBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CursorPosBox.Visible = false;
            // 
            // CursorPosBox2
            // 
            this.CursorPosBox2.Enabled = false;
            this.CursorPosBox2.Location = new System.Drawing.Point(12, 72);
            this.CursorPosBox2.Multiline = true;
            this.CursorPosBox2.Name = "CursorPosBox2";
            this.CursorPosBox2.ReadOnly = true;
            this.CursorPosBox2.Size = new System.Drawing.Size(136, 25);
            this.CursorPosBox2.TabIndex = 2;
            this.CursorPosBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CursorPosBox2.Visible = false;
            // 
            // SystemInfoBox
            // 
            this.SystemInfoBox.Location = new System.Drawing.Point(154, 108);
            this.SystemInfoBox.Multiline = true;
            this.SystemInfoBox.Name = "SystemInfoBox";
            this.SystemInfoBox.ReadOnly = true;
            this.SystemInfoBox.Size = new System.Drawing.Size(319, 291);
            this.SystemInfoBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Request GPU info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(154, 405);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(319, 33);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear text";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Requestdrivebutton
            // 
            this.Requestdrivebutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requestdrivebutton.Location = new System.Drawing.Point(154, 44);
            this.Requestdrivebutton.Name = "Requestdrivebutton";
            this.Requestdrivebutton.Size = new System.Drawing.Size(319, 26);
            this.Requestdrivebutton.TabIndex = 6;
            this.Requestdrivebutton.Text = "Request CPU info";
            this.Requestdrivebutton.UseVisualStyleBackColor = true;
            this.Requestdrivebutton.Click += new System.EventHandler(this.Requestdrivebutton_Click);
            // 
            // RequestOSinfobutton
            // 
            this.RequestOSinfobutton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestOSinfobutton.Location = new System.Drawing.Point(154, 76);
            this.RequestOSinfobutton.Name = "RequestOSinfobutton";
            this.RequestOSinfobutton.Size = new System.Drawing.Size(319, 26);
            this.RequestOSinfobutton.TabIndex = 7;
            this.RequestOSinfobutton.Text = "Request OS info";
            this.RequestOSinfobutton.UseVisualStyleBackColor = true;
            this.RequestOSinfobutton.Click += new System.EventHandler(this.RequestOSinfobutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RequestOSinfobutton);
            this.Controls.Add(this.Requestdrivebutton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SystemInfoBox);
            this.Controls.Add(this.CursorPosBox2);
            this.Controls.Add(this.CursorPosBox);
            this.Controls.Add(this.CursorDebugCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Helpful Debuger Dev Build v1.0";
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
        private System.Windows.Forms.Button Requestdrivebutton;
        private System.Windows.Forms.Button RequestOSinfobutton;
    }
}

