
using System.Windows.Forms;

namespace Helpful_debuger
{
    partial class injector
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(injector));
            this.label1 = new System.Windows.Forms.Label();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picProcess = new System.Windows.Forms.PictureBox();
            this.textDll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bSearchDll = new System.Windows.Forms.Button();
            this.bInject = new System.Windows.Forms.Button();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboProcess = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Process:";
            // 
            // comboMethod
            // 
            this.comboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Location = new System.Drawing.Point(16, 175);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(165, 21);
            this.comboMethod.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Injection Method:";
            // 
            // picProcess
            // 
            this.picProcess.Image = global::Helpful_debugger.Properties.Resources.Wrong;
            this.picProcess.Location = new System.Drawing.Point(198, 12);
            this.picProcess.Name = "picProcess";
            this.picProcess.Size = new System.Drawing.Size(19, 19);
            this.picProcess.TabIndex = 9;
            this.picProcess.TabStop = false;
            // 
            // textDll
            // 
            this.textDll.BackColor = System.Drawing.Color.Silver;
            this.textDll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDll.Location = new System.Drawing.Point(16, 256);
            this.textDll.Name = "textDll";
            this.textDll.Size = new System.Drawing.Size(165, 20);
            this.textDll.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "DLL Path:";
            // 
            // bSearchDll
            // 
            this.bSearchDll.ForeColor = System.Drawing.Color.Black;
            this.bSearchDll.Location = new System.Drawing.Point(116, 230);
            this.bSearchDll.Name = "bSearchDll";
            this.bSearchDll.Size = new System.Drawing.Size(65, 23);
            this.bSearchDll.TabIndex = 12;
            this.bSearchDll.Text = "Search";
            this.bSearchDll.UseVisualStyleBackColor = true;
            this.bSearchDll.Click += new System.EventHandler(this.bSearchDll_Click);
            // 
            // bInject
            // 
            this.bInject.BackColor = System.Drawing.Color.Transparent;
            this.bInject.Font = new System.Drawing.Font("MS Reference Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bInject.Location = new System.Drawing.Point(12, 335);
            this.bInject.Name = "bInject";
            this.bInject.Size = new System.Drawing.Size(299, 50);
            this.bInject.TabIndex = 13;
            this.bInject.Text = "inject";
            this.bInject.UseVisualStyleBackColor = false;
            this.bInject.Click += new System.EventHandler(this.bInject_Click);
            // 
            // comboId
            // 
            this.comboId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(16, 105);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(105, 21);
            this.comboId.TabIndex = 15;
            this.comboId.DropDown += new System.EventHandler(this.ComboId_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Process Id:";
            // 
            // comboProcess
            // 
            this.comboProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProcess.FormattingEnabled = true;
            this.comboProcess.Location = new System.Drawing.Point(16, 34);
            this.comboProcess.Name = "comboProcess";
            this.comboProcess.Size = new System.Drawing.Size(165, 21);
            this.comboProcess.TabIndex = 18;
            this.comboProcess.DropDown += new System.EventHandler(this.ComboProcess_DropDown);
            // 
            // injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(323, 397);
            this.Controls.Add(this.bSearchDll);
            this.Controls.Add(this.bInject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboId);
            this.Controls.Add(this.textDll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "injector";
            this.Text = "Helpful Debugger - DLL Injector";
            this.Load += new System.EventHandler(this.injector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboMethod;
        private Label label2;
        private PictureBox picProcess;
        private TextBox textDll;
        private Label label3;
        private Button bSearchDll;
        private Button bInject;
        private ComboBox comboId;
        private Label label4;
        private ComboBox comboProcess;
    }
}

