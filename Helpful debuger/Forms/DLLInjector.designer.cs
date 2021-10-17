
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.comboProcess = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.bInject = new System.Windows.Forms.Button();
            this.bSearchDll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textDll = new System.Windows.Forms.TextBox();
            this.picProcess = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeProcess = new System.Windows.Forms.Button();
            this.minimizeProcess = new System.Windows.Forms.Button();
            this.bOptions = new System.Windows.Forms.Button();
            this.bSaveSelection = new System.Windows.Forms.Button();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.boxInjectOnStartup = new System.Windows.Forms.Button();
            this.boxCloseOnInject = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeProcess1 = new System.Windows.Forms.Button();
            this.minimizeProcess1 = new System.Windows.Forms.Button();
            this.bMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.l_closeOnInject = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMenu);
            this.tabControl.Controls.Add(this.tabOptions);
            this.tabControl.Location = new System.Drawing.Point(-30, -30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(403, 400);
            this.tabControl.TabIndex = 2;
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tabMenu.Controls.Add(this.comboProcess);
            this.tabMenu.Controls.Add(this.label4);
            this.tabMenu.Controls.Add(this.comboId);
            this.tabMenu.Controls.Add(this.bInject);
            this.tabMenu.Controls.Add(this.bSearchDll);
            this.tabMenu.Controls.Add(this.label3);
            this.tabMenu.Controls.Add(this.textDll);
            this.tabMenu.Controls.Add(this.picProcess);
            this.tabMenu.Controls.Add(this.label2);
            this.tabMenu.Controls.Add(this.comboMethod);
            this.tabMenu.Controls.Add(this.label1);
            this.tabMenu.Controls.Add(this.panel1);
            this.tabMenu.ForeColor = System.Drawing.Color.Cornsilk;
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(395, 374);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "1";
            this.tabMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // comboProcess
            // 
            this.comboProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProcess.FormattingEnabled = true;
            this.comboProcess.Location = new System.Drawing.Point(42, 108);
            this.comboProcess.Name = "comboProcess";
            this.comboProcess.Size = new System.Drawing.Size(165, 21);
            this.comboProcess.TabIndex = 18;
            this.comboProcess.DropDown += new System.EventHandler(this.ComboProcess_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(241, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Process Id:";
            // 
            // comboId
            // 
            this.comboId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(245, 108);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(105, 21);
            this.comboId.TabIndex = 15;
            this.comboId.DropDown += new System.EventHandler(this.ComboId_DropDown);
            // 
            // bInject
            // 
            this.bInject.BackColor = System.Drawing.Color.Transparent;
            this.bInject.Font = new System.Drawing.Font("MS Reference Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bInject.Location = new System.Drawing.Point(17, 291);
            this.bInject.Name = "bInject";
            this.bInject.Size = new System.Drawing.Size(369, 77);
            this.bInject.TabIndex = 13;
            this.bInject.Text = "inject";
            this.bInject.UseVisualStyleBackColor = false;
            this.bInject.Click += new System.EventHandler(this.bInject_Click);
            // 
            // bSearchDll
            // 
            this.bSearchDll.ForeColor = System.Drawing.Color.Black;
            this.bSearchDll.Location = new System.Drawing.Point(142, 215);
            this.bSearchDll.Name = "bSearchDll";
            this.bSearchDll.Size = new System.Drawing.Size(65, 23);
            this.bSearchDll.TabIndex = 12;
            this.bSearchDll.Text = "Search";
            this.bSearchDll.UseVisualStyleBackColor = true;
            this.bSearchDll.Click += new System.EventHandler(this.bSearchDll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(42, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "DLL Path:";
            // 
            // textDll
            // 
            this.textDll.BackColor = System.Drawing.Color.Silver;
            this.textDll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDll.Location = new System.Drawing.Point(42, 242);
            this.textDll.Name = "textDll";
            this.textDll.Size = new System.Drawing.Size(165, 20);
            this.textDll.TabIndex = 10;
            // 
            // picProcess
            // 
            this.picProcess.Image = global::Helpful_debugger.Properties.Resources.Wrong;
            this.picProcess.Location = new System.Drawing.Point(219, 86);
            this.picProcess.Name = "picProcess";
            this.picProcess.Size = new System.Drawing.Size(19, 19);
            this.picProcess.TabIndex = 9;
            this.picProcess.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(38, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Injection Method:";
            // 
            // comboMethod
            // 
            this.comboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMethod.FormattingEnabled = true;
            this.comboMethod.Location = new System.Drawing.Point(42, 173);
            this.comboMethod.Name = "comboMethod";
            this.comboMethod.Size = new System.Drawing.Size(165, 21);
            this.comboMethod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Process:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.closeProcess);
            this.panel1.Controls.Add(this.minimizeProcess);
            this.panel1.Controls.Add(this.bOptions);
            this.panel1.Controls.Add(this.bSaveSelection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 56);
            this.panel1.TabIndex = 16;
            // 
            // closeProcess
            // 
            this.closeProcess.BackColor = System.Drawing.SystemColors.Control;
            this.closeProcess.FlatAppearance.BorderSize = 0;
            this.closeProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeProcess.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeProcess.ForeColor = System.Drawing.Color.Red;
            this.closeProcess.Location = new System.Drawing.Point(321, 5);
            this.closeProcess.Name = "closeProcess";
            this.closeProcess.Size = new System.Drawing.Size(51, 49);
            this.closeProcess.TabIndex = 7;
            this.closeProcess.Text = "x";
            this.closeProcess.UseVisualStyleBackColor = false;
            this.closeProcess.Click += new System.EventHandler(this.closeProcess_Click);
            // 
            // minimizeProcess
            // 
            this.minimizeProcess.BackColor = System.Drawing.SystemColors.Control;
            this.minimizeProcess.FlatAppearance.BorderSize = 0;
            this.minimizeProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeProcess.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeProcess.ForeColor = System.Drawing.Color.Black;
            this.minimizeProcess.Location = new System.Drawing.Point(264, 5);
            this.minimizeProcess.Name = "minimizeProcess";
            this.minimizeProcess.Size = new System.Drawing.Size(51, 49);
            this.minimizeProcess.TabIndex = 6;
            this.minimizeProcess.Text = "_";
            this.minimizeProcess.UseVisualStyleBackColor = false;
            this.minimizeProcess.Click += new System.EventHandler(this.minimizeProcess_Click);
            // 
            // bOptions
            // 
            this.bOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.bOptions.Enabled = false;
            this.bOptions.FlatAppearance.BorderSize = 0;
            this.bOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOptions.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOptions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bOptions.Location = new System.Drawing.Point(23, 48);
            this.bOptions.Name = "bOptions";
            this.bOptions.Size = new System.Drawing.Size(109, 10);
            this.bOptions.TabIndex = 5;
            this.bOptions.Text = "Options";
            this.bOptions.UseVisualStyleBackColor = false;
            this.bOptions.Visible = false;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            // 
            // bSaveSelection
            // 
            this.bSaveSelection.Enabled = false;
            this.bSaveSelection.FlatAppearance.BorderSize = 0;
            this.bSaveSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveSelection.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.bSaveSelection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSaveSelection.Location = new System.Drawing.Point(138, 33);
            this.bSaveSelection.Name = "bSaveSelection";
            this.bSaveSelection.Size = new System.Drawing.Size(120, 21);
            this.bSaveSelection.TabIndex = 4;
            this.bSaveSelection.Text = "Save selection";
            this.bSaveSelection.UseVisualStyleBackColor = true;
            this.bSaveSelection.Visible = false;
            this.bSaveSelection.Click += new System.EventHandler(this.bSaveSelection_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.tabOptions.Controls.Add(this.boxInjectOnStartup);
            this.tabOptions.Controls.Add(this.boxCloseOnInject);
            this.tabOptions.Controls.Add(this.label6);
            this.tabOptions.Controls.Add(this.bSave);
            this.tabOptions.Controls.Add(this.panel2);
            this.tabOptions.Controls.Add(this.button2);
            this.tabOptions.Controls.Add(this.button1);
            this.tabOptions.Controls.Add(this.l_closeOnInject);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(395, 374);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.Text = "2";
            this.tabOptions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // boxInjectOnStartup
            // 
            this.boxInjectOnStartup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.boxInjectOnStartup.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.boxInjectOnStartup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxInjectOnStartup.ForeColor = System.Drawing.Color.White;
            this.boxInjectOnStartup.Location = new System.Drawing.Point(199, 113);
            this.boxInjectOnStartup.Name = "boxInjectOnStartup";
            this.boxInjectOnStartup.Size = new System.Drawing.Size(27, 28);
            this.boxInjectOnStartup.TabIndex = 24;
            this.boxInjectOnStartup.UseVisualStyleBackColor = false;
            this.boxInjectOnStartup.Click += new System.EventHandler(this.boxInjectOnStartup_Click);
            // 
            // boxCloseOnInject
            // 
            this.boxCloseOnInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.boxCloseOnInject.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.boxCloseOnInject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxCloseOnInject.ForeColor = System.Drawing.Color.White;
            this.boxCloseOnInject.Location = new System.Drawing.Point(199, 76);
            this.boxCloseOnInject.Name = "boxCloseOnInject";
            this.boxCloseOnInject.Size = new System.Drawing.Size(27, 28);
            this.boxCloseOnInject.TabIndex = 23;
            this.boxCloseOnInject.UseVisualStyleBackColor = false;
            this.boxCloseOnInject.Click += new System.EventHandler(this.boxCloseOnInject_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Inject on startup:";
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.Transparent;
            this.bSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bSave.Location = new System.Drawing.Point(17, 291);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(369, 77);
            this.bSave.TabIndex = 18;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.closeProcess1);
            this.panel2.Controls.Add(this.minimizeProcess1);
            this.panel2.Controls.Add(this.bMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 56);
            this.panel2.TabIndex = 17;
            // 
            // closeProcess1
            // 
            this.closeProcess1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.closeProcess1.FlatAppearance.BorderSize = 0;
            this.closeProcess1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeProcess1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeProcess1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeProcess1.ForeColor = System.Drawing.Color.Red;
            this.closeProcess1.Location = new System.Drawing.Point(321, 5);
            this.closeProcess1.Name = "closeProcess1";
            this.closeProcess1.Size = new System.Drawing.Size(51, 49);
            this.closeProcess1.TabIndex = 7;
            this.closeProcess1.Text = "x";
            this.closeProcess1.UseVisualStyleBackColor = false;
            this.closeProcess1.Click += new System.EventHandler(this.closeProcess_Click);
            // 
            // minimizeProcess1
            // 
            this.minimizeProcess1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.minimizeProcess1.FlatAppearance.BorderSize = 0;
            this.minimizeProcess1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeProcess1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeProcess1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeProcess1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizeProcess1.Location = new System.Drawing.Point(264, 5);
            this.minimizeProcess1.Name = "minimizeProcess1";
            this.minimizeProcess1.Size = new System.Drawing.Size(51, 49);
            this.minimizeProcess1.TabIndex = 6;
            this.minimizeProcess1.Text = "_";
            this.minimizeProcess1.UseVisualStyleBackColor = false;
            this.minimizeProcess1.Click += new System.EventHandler(this.minimizeProcess_Click);
            // 
            // bMenu
            // 
            this.bMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.bMenu.FlatAppearance.BorderSize = 0;
            this.bMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMenu.Location = new System.Drawing.Point(23, 5);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(109, 50);
            this.bMenu.TabIndex = 5;
            this.bMenu.Text = "Menu";
            this.bMenu.UseVisualStyleBackColor = false;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            // 
            // l_closeOnInject
            // 
            this.l_closeOnInject.AutoSize = true;
            this.l_closeOnInject.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_closeOnInject.ForeColor = System.Drawing.Color.White;
            this.l_closeOnInject.Location = new System.Drawing.Point(38, 79);
            this.l_closeOnInject.Name = "l_closeOnInject";
            this.l_closeOnInject.Size = new System.Drawing.Size(139, 20);
            this.l_closeOnInject.TabIndex = 10;
            this.l_closeOnInject.Text = "Close on inject:";
            // 
            // injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "injector";
            this.Text = "Injector by Triggerhex";
            this.Load += new System.EventHandler(this.injector_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.Button bSaveSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.PictureBox picProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDll;
        private System.Windows.Forms.Button bSearchDll;
        private System.Windows.Forms.Button bInject;
        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.Label l_closeOnInject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeProcess;
        private System.Windows.Forms.Button minimizeProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeProcess1;
        private System.Windows.Forms.Button minimizeProcess1;
        private System.Windows.Forms.Button bMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bSave;
        private Label label6;
        private Button boxCloseOnInject;
        private Button boxInjectOnStartup;
        private ComboBox comboProcess;
    }
}

