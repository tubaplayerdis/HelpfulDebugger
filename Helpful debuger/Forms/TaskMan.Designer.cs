
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup3", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup4", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("t");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("y");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("u");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("i");
            this.listView1 = new System.Windows.Forms.ListView();
            this.askadminlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            listViewGroup1.Header = "ListViewGroup1";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup2";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup3";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "ListViewGroup4";
            listViewGroup4.Name = "listViewGroup4";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView1.HideSelection = false;
            listViewItem1.Group = listViewGroup4;
            listViewItem2.Group = listViewGroup3;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(904, 424);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // askadminlabel
            // 
            this.askadminlabel.AutoSize = true;
            this.askadminlabel.Location = new System.Drawing.Point(922, 442);
            this.askadminlabel.Name = "askadminlabel";
            this.askadminlabel.Size = new System.Drawing.Size(204, 13);
            this.askadminlabel.TabIndex = 5;
            this.askadminlabel.Text = "To recieve more information, run as admin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(904, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TaskMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.askadminlabel);
            this.Controls.Add(this.listView1);
            this.Name = "TaskMan";
            this.Text = "TaskMan";
            this.Load += new System.EventHandler(this.TaskMan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label askadminlabel;
        private System.Windows.Forms.Button button1;
    }
}