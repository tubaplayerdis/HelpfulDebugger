
namespace Helpful_debugger.Forms
{
    partial class TaskMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskMan));
            this.GODList = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdKillbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.la = new System.Windows.Forms.Label();
            this.Killbynamebox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GODList
            // 
            this.GODList.GridLines = true;
            this.GODList.HideSelection = false;
            this.GODList.Location = new System.Drawing.Point(12, 12);
            this.GODList.Name = "GODList";
            this.GODList.Size = new System.Drawing.Size(1047, 657);
            this.GODList.TabIndex = 4;
            this.GODList.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1047, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1065, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kill with ID:";
            // 
            // IdKillbox
            // 
            this.IdKillbox.Location = new System.Drawing.Point(1069, 37);
            this.IdKillbox.Name = "IdKillbox";
            this.IdKillbox.Size = new System.Drawing.Size(237, 20);
            this.IdKillbox.TabIndex = 8;
            this.IdKillbox.Text = "Enter process ID here";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1069, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 232);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kill(ID)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(1065, 298);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(160, 22);
            this.la.TabIndex = 10;
            this.la.Text = "Kill with Name:";
            // 
            // Killbynamebox
            // 
            this.Killbynamebox.Location = new System.Drawing.Point(1069, 323);
            this.Killbynamebox.Name = "Killbynamebox";
            this.Killbynamebox.Size = new System.Drawing.Size(237, 20);
            this.Killbynamebox.TabIndex = 11;
            this.Killbynamebox.Text = "Enter process name here";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1069, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 232);
            this.button3.TabIndex = 12;
            this.button3.Text = "Kill(Name)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TaskMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 721);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Killbynamebox);
            this.Controls.Add(this.la);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IdKillbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GODList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskMan";
            this.Text = "TaskMan";
            this.Load += new System.EventHandler(this.TaskMan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView GODList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdKillbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox Killbynamebox;
        private System.Windows.Forms.Button button3;
    }
}