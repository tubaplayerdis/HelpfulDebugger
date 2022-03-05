namespace Helpful_debugger.Forms
{
    partial class Scripting
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
            this.EditorBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.RunScriptButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.RefeshLog = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // EditorBox
            // 
            this.EditorBox.Location = new System.Drawing.Point(12, 10);
            this.EditorBox.Multiline = true;
            this.EditorBox.Name = "EditorBox";
            this.EditorBox.Size = new System.Drawing.Size(1097, 642);
            this.EditorBox.TabIndex = 0;
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(1115, 126);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(301, 526);
            this.OutputBox.TabIndex = 1;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(1115, 79);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(102, 33);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "Output";
            // 
            // RunScriptButton
            // 
            this.RunScriptButton.Location = new System.Drawing.Point(1115, 10);
            this.RunScriptButton.Name = "RunScriptButton";
            this.RunScriptButton.Size = new System.Drawing.Size(232, 43);
            this.RunScriptButton.TabIndex = 3;
            this.RunScriptButton.Text = "Run Script";
            this.RunScriptButton.UseVisualStyleBackColor = true;
            this.RunScriptButton.Click += new System.EventHandler(this.RunScriptButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(1353, 10);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(62, 42);
            this.InfoButton.TabIndex = 4;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            // 
            // RefeshLog
            // 
            this.RefeshLog.Enabled = true;
            this.RefeshLog.Interval = 10;
            this.RefeshLog.Tick += new System.EventHandler(this.RefeshLog_Tick);
            // 
            // Scripting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 664);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.RunScriptButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.EditorBox);
            this.Name = "Scripting";
            this.Text = "Scripting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditorBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button RunScriptButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Timer RefeshLog;
    }
}