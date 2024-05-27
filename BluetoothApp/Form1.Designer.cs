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
            this.serialPortIncoming = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPortOutCon = new System.Windows.Forms.Label();
            this.comboBoxPortOut = new System.Windows.Forms.ComboBox();
            this.buttonConIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDisconIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBaudOut = new System.Windows.Forms.ComboBox();
            this.buttonMode = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.buttonOpenWindow = new System.Windows.Forms.Button();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.serialPortOutgoing = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPortIn = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudIn = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPortInCon = new System.Windows.Forms.Label();
            this.buttonConOut = new System.Windows.Forms.Button();
            this.buttonDisconOut = new System.Windows.Forms.Button();
            this.progressBarSensor = new System.Windows.Forms.ProgressBar();
            this.labelSensor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(90, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn cổng ra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái ra:";
            // 
            // labelPortOutCon
            // 
            this.labelPortOutCon.AutoSize = true;
            this.labelPortOutCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortOutCon.ForeColor = System.Drawing.Color.Red;
            this.labelPortOutCon.Location = new System.Drawing.Point(264, 306);
            this.labelPortOutCon.Name = "labelPortOutCon";
            this.labelPortOutCon.Size = new System.Drawing.Size(117, 25);
            this.labelPortOutCon.TabIndex = 3;
            this.labelPortOutCon.Text = "chưa kết nối";
            // 
            // comboBoxPortOut
            // 
            this.comboBoxPortOut.FormattingEnabled = true;
            this.comboBoxPortOut.Location = new System.Drawing.Point(269, 224);
            this.comboBoxPortOut.Name = "comboBoxPortOut";
            this.comboBoxPortOut.Size = new System.Drawing.Size(249, 24);
            this.comboBoxPortOut.TabIndex = 4;
            // 
            // buttonConIn
            // 
            this.buttonConIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConIn.Location = new System.Drawing.Point(579, 72);
            this.buttonConIn.Name = "buttonConIn";
            this.buttonConIn.Size = new System.Drawing.Size(123, 44);
            this.buttonConIn.TabIndex = 5;
            this.buttonConIn.Text = "Kết nối";
            this.buttonConIn.UseVisualStyleBackColor = false;
            this.buttonConIn.Click += new System.EventHandler(this.buttonConIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dữ liệu đo được:";
            // 
            // buttonDisconIn
            // 
            this.buttonDisconIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDisconIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDisconIn.Location = new System.Drawing.Point(708, 72);
            this.buttonDisconIn.Name = "buttonDisconIn";
            this.buttonDisconIn.Size = new System.Drawing.Size(123, 44);
            this.buttonDisconIn.TabIndex = 8;
            this.buttonDisconIn.Text = "Ngắt kết nối";
            this.buttonDisconIn.UseVisualStyleBackColor = false;
            this.buttonDisconIn.Click += new System.EventHandler(this.buttonDisconIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Baud rate ra:";
            // 
            // comboBoxBaudOut
            // 
            this.comboBoxBaudOut.FormattingEnabled = true;
            this.comboBoxBaudOut.Location = new System.Drawing.Point(269, 263);
            this.comboBoxBaudOut.Name = "comboBoxBaudOut";
            this.comboBoxBaudOut.Size = new System.Drawing.Size(249, 24);
            this.comboBoxBaudOut.TabIndex = 10;
            // 
            // buttonMode
            // 
            this.buttonMode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMode.Location = new System.Drawing.Point(95, 435);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(123, 44);
            this.buttonMode.TabIndex = 11;
            this.buttonMode.Text = "Chế độ";
            this.buttonMode.UseVisualStyleBackColor = false;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.ForeColor = System.Drawing.Color.Red;
            this.labelMode.Location = new System.Drawing.Point(264, 445);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(77, 25);
            this.labelMode.TabIndex = 12;
            this.labelMode.Text = "Manual";
            // 
            // buttonOpenWindow
            // 
            this.buttonOpenWindow.BackColor = System.Drawing.Color.Lime;
            this.buttonOpenWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenWindow.Location = new System.Drawing.Point(579, 435);
            this.buttonOpenWindow.Name = "buttonOpenWindow";
            this.buttonOpenWindow.Size = new System.Drawing.Size(123, 44);
            this.buttonOpenWindow.TabIndex = 13;
            this.buttonOpenWindow.Text = "Mở cửa";
            this.buttonOpenWindow.UseVisualStyleBackColor = false;
            this.buttonOpenWindow.Click += new System.EventHandler(this.buttonOpenWindow_Click);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.BackColor = System.Drawing.Color.Red;
            this.buttonCloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCloseWindow.Location = new System.Drawing.Point(708, 435);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(123, 44);
            this.buttonCloseWindow.TabIndex = 14;
            this.buttonCloseWindow.Text = "Đóng cửa";
            this.buttonCloseWindow.UseVisualStyleBackColor = false;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chọn cổng vào:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Baud rate vào:";
            // 
            // comboBoxPortIn
            // 
            this.comboBoxPortIn.FormattingEnabled = true;
            this.comboBoxPortIn.Location = new System.Drawing.Point(269, 72);
            this.comboBoxPortIn.Name = "comboBoxPortIn";
            this.comboBoxPortIn.Size = new System.Drawing.Size(249, 24);
            this.comboBoxPortIn.TabIndex = 17;
            // 
            // comboBoxBaudIn
            // 
            this.comboBoxBaudIn.FormattingEnabled = true;
            this.comboBoxBaudIn.Location = new System.Drawing.Point(269, 111);
            this.comboBoxBaudIn.Name = "comboBoxBaudIn";
            this.comboBoxBaudIn.Size = new System.Drawing.Size(249, 24);
            this.comboBoxBaudIn.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Trạng thái vào:";
            // 
            // labelPortInCon
            // 
            this.labelPortInCon.AutoSize = true;
            this.labelPortInCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortInCon.ForeColor = System.Drawing.Color.Red;
            this.labelPortInCon.Location = new System.Drawing.Point(264, 152);
            this.labelPortInCon.Name = "labelPortInCon";
            this.labelPortInCon.Size = new System.Drawing.Size(117, 25);
            this.labelPortInCon.TabIndex = 20;
            this.labelPortInCon.Text = "chưa kết nối";
            // 
            // buttonConOut
            // 
            this.buttonConOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConOut.Location = new System.Drawing.Point(579, 224);
            this.buttonConOut.Name = "buttonConOut";
            this.buttonConOut.Size = new System.Drawing.Size(123, 44);
            this.buttonConOut.TabIndex = 21;
            this.buttonConOut.Text = "Kết nối";
            this.buttonConOut.UseVisualStyleBackColor = false;
            this.buttonConOut.Click += new System.EventHandler(this.buttonConOut_Click);
            // 
            // buttonDisconOut
            // 
            this.buttonDisconOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDisconOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDisconOut.Location = new System.Drawing.Point(708, 223);
            this.buttonDisconOut.Name = "buttonDisconOut";
            this.buttonDisconOut.Size = new System.Drawing.Size(123, 44);
            this.buttonDisconOut.TabIndex = 22;
            this.buttonDisconOut.Text = "Ngắt kết nối";
            this.buttonDisconOut.UseVisualStyleBackColor = false;
            this.buttonDisconOut.Click += new System.EventHandler(this.buttonDisconOut_Click);
            // 
            // progressBarSensor
            // 
            this.progressBarSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBarSensor.Location = new System.Drawing.Point(290, 378);
            this.progressBarSensor.Name = "progressBarSensor";
            this.progressBarSensor.Size = new System.Drawing.Size(291, 30);
            this.progressBarSensor.TabIndex = 23;
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensor.ForeColor = System.Drawing.Color.Black;
            this.labelSensor.Location = new System.Drawing.Point(422, 355);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(33, 20);
            this.labelSensor.TabIndex = 24;
            this.labelSensor.Text = "0%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(587, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "100%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 535);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSensor);
            this.Controls.Add(this.progressBarSensor);
            this.Controls.Add(this.buttonDisconOut);
            this.Controls.Add(this.buttonConOut);
            this.Controls.Add(this.labelPortInCon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxBaudIn);
            this.Controls.Add(this.comboBoxPortIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCloseWindow);
            this.Controls.Add(this.buttonOpenWindow);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.comboBoxBaudOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDisconIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConIn);
            this.Controls.Add(this.comboBoxPortOut);
            this.Controls.Add(this.labelPortOutCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Smoke Detection System Bluetooth Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.IO.Ports.SerialPort serialPortIncoming;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escapeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPortOutCon;
        private System.Windows.Forms.ComboBox comboBoxPortOut;
        private System.Windows.Forms.Button buttonConIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDisconIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBaudOut;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button buttonOpenWindow;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.IO.Ports.SerialPort serialPortOutgoing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPortIn;
        private System.Windows.Forms.ComboBox comboBoxBaudIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPortInCon;
        private System.Windows.Forms.Button buttonConOut;
        private System.Windows.Forms.Button buttonDisconOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ProgressBar progressBarSensor;
        private System.Windows.Forms.Label labelSensor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

