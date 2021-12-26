
namespace Helpful_debugger
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.label6 = new System.Windows.Forms.Label();
            this.FileOpenCurrently = new System.Windows.Forms.TextBox();
            this.EditScriptBox = new System.Windows.Forms.TextBox();
            this.RunScriptBTWSH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.OpenJSfile = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.Filesavedbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Edit JS script";
            // 
            // FileOpenCurrently
            // 
            this.FileOpenCurrently.Location = new System.Drawing.Point(150, 12);
            this.FileOpenCurrently.Name = "FileOpenCurrently";
            this.FileOpenCurrently.ReadOnly = true;
            this.FileOpenCurrently.Size = new System.Drawing.Size(836, 20);
            this.FileOpenCurrently.TabIndex = 42;
            this.FileOpenCurrently.Text = "Current file open:";
            // 
            // EditScriptBox
            // 
            this.EditScriptBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditScriptBox.Location = new System.Drawing.Point(12, 38);
            this.EditScriptBox.Multiline = true;
            this.EditScriptBox.Name = "EditScriptBox";
            this.EditScriptBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditScriptBox.Size = new System.Drawing.Size(1038, 415);
            this.EditScriptBox.TabIndex = 43;
            this.EditScriptBox.Click += new System.EventHandler(this.EditScriptBox_Click);
            this.EditScriptBox.TextChanged += new System.EventHandler(this.EditScriptBox_TextChanged);
            // 
            // RunScriptBTWSH
            // 
            this.RunScriptBTWSH.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunScriptBTWSH.Location = new System.Drawing.Point(12, 459);
            this.RunScriptBTWSH.Name = "RunScriptBTWSH";
            this.RunScriptBTWSH.Size = new System.Drawing.Size(1038, 34);
            this.RunScriptBTWSH.TabIndex = 44;
            this.RunScriptBTWSH.Text = "Run JS script (WSH)";
            this.RunScriptBTWSH.UseVisualStyleBackColor = true;
            this.RunScriptBTWSH.Click += new System.EventHandler(this.RunScriptBTWSH_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1038, 33);
            this.button1.TabIndex = 43;
            this.button1.Text = "Run JS script (Node.js)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1038, 33);
            this.button2.TabIndex = 39;
            this.button2.Text = "Open JS script in editor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1038, 33);
            this.button3.TabIndex = 40;
            this.button3.Text = "Save changes to JS script";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 614);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1038, 33);
            this.button4.TabIndex = 42;
            this.button4.Text = "Check if node.js is installed";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // OpenJSfile
            // 
            this.OpenJSfile.Filter = "JavaScript Files|*.js";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 653);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(1038, 33);
            this.button5.TabIndex = 45;
            this.button5.Text = "Close Editor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Filesavedbox
            // 
            this.Filesavedbox.AutoCheck = false;
            this.Filesavedbox.AutoSize = true;
            this.Filesavedbox.Location = new System.Drawing.Point(992, 15);
            this.Filesavedbox.Name = "Filesavedbox";
            this.Filesavedbox.Size = new System.Drawing.Size(63, 17);
            this.Filesavedbox.TabIndex = 46;
            this.Filesavedbox.Text = "Saved?";
            this.Filesavedbox.UseVisualStyleBackColor = true;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 690);
            this.Controls.Add(this.Filesavedbox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RunScriptBTWSH);
            this.Controls.Add(this.EditScriptBox);
            this.Controls.Add(this.FileOpenCurrently);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1080, 688);
            this.Name = "EditorForm";
            this.Text = "Helpful Debugger - Script Editor";
            this.Activated += new System.EventHandler(this.EditorForm_Activated);
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FileOpenCurrently;
        private System.Windows.Forms.TextBox EditScriptBox;
        private System.Windows.Forms.Button RunScriptBTWSH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog OpenJSfile;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.CheckBox Filesavedbox;
    }
}