namespace BluetoothApp
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.escapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPortOutCon = new System.Windows.Forms.Label();
            this.comboBoxPortOut = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBaudOut = new System.Windows.Forms.ComboBox();
            this.buttonMode = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.buttonOpenWindow = new System.Windows.Forms.Button();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.serialPortOutgoing = new System.IO.Ports.SerialPort(this.components);
            this.buttonConOut = new System.Windows.Forms.Button();
            this.buttonDisconOut = new System.Windows.Forms.Button();
            this.buttonFanOn = new System.Windows.Forms.Button();
            this.buttonFanOff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.escapeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.toolStripMenuItem1.Text = "Info";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // escapeToolStripMenuItem
            // 
            this.escapeToolStripMenuItem.Name = "escapeToolStripMenuItem";
            this.escapeToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.escapeToolStripMenuItem.Text = "Escape";
            this.escapeToolStripMenuItem.Click += new System.EventHandler(this.escapeToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn cổng ra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái:";
            // 
            // labelPortOutCon
            // 
            this.labelPortOutCon.AutoSize = true;
            this.labelPortOutCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortOutCon.ForeColor = System.Drawing.Color.Red;
            this.labelPortOutCon.Location = new System.Drawing.Point(212, 163);
            this.labelPortOutCon.Name = "labelPortOutCon";
            this.labelPortOutCon.Size = new System.Drawing.Size(117, 25);
            this.labelPortOutCon.TabIndex = 3;
            this.labelPortOutCon.Text = "chưa kết nối";
            // 
            // comboBoxPortOut
            // 
            this.comboBoxPortOut.FormattingEnabled = true;
            this.comboBoxPortOut.Location = new System.Drawing.Point(217, 66);
            this.comboBoxPortOut.Name = "comboBoxPortOut";
            this.comboBoxPortOut.Size = new System.Drawing.Size(249, 24);
            this.comboBoxPortOut.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Baud rate:";
            // 
            // comboBoxBaudOut
            // 
            this.comboBoxBaudOut.FormattingEnabled = true;
            this.comboBoxBaudOut.Location = new System.Drawing.Point(217, 113);
            this.comboBoxBaudOut.Name = "comboBoxBaudOut";
            this.comboBoxBaudOut.Size = new System.Drawing.Size(249, 24);
            this.comboBoxBaudOut.TabIndex = 10;
            // 
            // buttonMode
            // 
            this.buttonMode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMode.Location = new System.Drawing.Point(518, 144);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(154, 44);
            this.buttonMode.TabIndex = 11;
            this.buttonMode.Text = "Chế độ";
            this.buttonMode.UseVisualStyleBackColor = false;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.ForeColor = System.Drawing.Color.Lime;
            this.labelMode.Location = new System.Drawing.Point(720, 150);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(65, 29);
            this.labelMode.TabIndex = 12;
            this.labelMode.Text = "Auto";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOpenWindow
            // 
            this.buttonOpenWindow.BackColor = System.Drawing.Color.Lime;
            this.buttonOpenWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenWindow.Location = new System.Drawing.Point(81, 34);
            this.buttonOpenWindow.Name = "buttonOpenWindow";
            this.buttonOpenWindow.Size = new System.Drawing.Size(154, 44);
            this.buttonOpenWindow.TabIndex = 13;
            this.buttonOpenWindow.Text = "Mở cửa";
            this.buttonOpenWindow.UseVisualStyleBackColor = false;
            this.buttonOpenWindow.Click += new System.EventHandler(this.buttonOpenWindow_Click);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonCloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCloseWindow.Location = new System.Drawing.Point(81, 121);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(154, 44);
            this.buttonCloseWindow.TabIndex = 14;
            this.buttonCloseWindow.Text = "Đóng cửa";
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // buttonConOut
            // 
            this.buttonConOut.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonConOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConOut.Location = new System.Drawing.Point(518, 62);
            this.buttonConOut.Name = "buttonConOut";
            this.buttonConOut.Size = new System.Drawing.Size(154, 44);
            this.buttonConOut.TabIndex = 21;
            this.buttonConOut.Text = "Kết nối";
            this.buttonConOut.UseVisualStyleBackColor = false;
            this.buttonConOut.Click += new System.EventHandler(this.buttonConOut_Click);
            // 
            // buttonDisconOut
            // 
            this.buttonDisconOut.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDisconOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDisconOut.Location = new System.Drawing.Point(678, 62);
            this.buttonDisconOut.Name = "buttonDisconOut";
            this.buttonDisconOut.Size = new System.Drawing.Size(154, 44);
            this.buttonDisconOut.TabIndex = 22;
            this.buttonDisconOut.Text = "Ngắt kết nối";
            this.buttonDisconOut.UseVisualStyleBackColor = false;
            this.buttonDisconOut.Click += new System.EventHandler(this.buttonDisconOut_Click);
            // 
            // buttonFanOn
            // 
            this.buttonFanOn.BackColor = System.Drawing.Color.Lime;
            this.buttonFanOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFanOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFanOn.Location = new System.Drawing.Point(80, 34);
            this.buttonFanOn.Name = "buttonFanOn";
            this.buttonFanOn.Size = new System.Drawing.Size(154, 44);
            this.buttonFanOn.TabIndex = 27;
            this.buttonFanOn.Text = "Bật quạt";
            this.buttonFanOn.UseVisualStyleBackColor = false;
            this.buttonFanOn.Click += new System.EventHandler(this.buttonFanOn_Click);
            // 
            // buttonFanOff
            // 
            this.buttonFanOff.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonFanOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFanOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFanOff.Location = new System.Drawing.Point(80, 120);
            this.buttonFanOff.Name = "buttonFanOff";
            this.buttonFanOff.Size = new System.Drawing.Size(154, 44);
            this.buttonFanOff.TabIndex = 28;
            this.buttonFanOff.Text = "Tắt quạt";
            this.buttonFanOff.UseVisualStyleBackColor = false;
            this.buttonFanOff.Click += new System.EventHandler(this.buttonFanOff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.buttonOpenWindow);
            this.groupBox1.Controls.Add(this.buttonCloseWindow);
            this.groupBox1.Location = new System.Drawing.Point(67, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 200);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.buttonFanOn);
            this.groupBox2.Controls.Add(this.buttonFanOff);
            this.groupBox2.Location = new System.Drawing.Point(507, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 200);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDisconOut);
            this.Controls.Add(this.buttonConOut);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.comboBoxBaudOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPortOut);
            this.Controls.Add(this.labelPortOutCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(892, 582);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(892, 582);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth Smoke Detection System Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escapeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPortOutCon;
        private System.Windows.Forms.ComboBox comboBoxPortOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBaudOut;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button buttonOpenWindow;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.IO.Ports.SerialPort serialPortOutgoing;
        private System.Windows.Forms.Button buttonConOut;
        private System.Windows.Forms.Button buttonDisconOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button buttonFanOn;
        private System.Windows.Forms.Button buttonFanOff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

