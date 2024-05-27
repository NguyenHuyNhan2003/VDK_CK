using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BluetoothApp
{
    public partial class Form1 : Form
    {
        string InputData = String.Empty;
        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            serialPortIncoming.DataReceived += new SerialDataReceivedEventHandler(DataReceive);

            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };

            comboBoxBaudOut.Items.AddRange(BaudRate);
            comboBoxBaudIn.Items.AddRange(BaudRate);
            progressBarSensor.Maximum = 1023;
            progressBarSensor.Minimum = 0;
            progressBarSensor.Value = 0;
        }
        private void SetText(string text)

        {

            if (this.labelSensor.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText

                this.Invoke(d, new object[] { text });

            }

            else
            {
                this.labelSensor.Text = text + "%";
                this.progressBarSensor.Value = int.Parse(text);
            }

        }
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)

        {

            InputData = serialPortIncoming.ReadExisting();

            if (InputData != String.Empty)

            {
                
                SetText(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.

            }



        }

        private void escapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!serialPortIncoming.IsOpen)

            {



                labelPortInCon.Text = ("Chưa kết nối");

                labelPortInCon.ForeColor = Color.Red;

            }

            else if (serialPortIncoming.IsOpen)

            {



                labelPortInCon.Text = ("Đã kết nối");

                labelPortInCon.ForeColor = Color.Lime;



            }
            if (!serialPortOutgoing.IsOpen)

            {



                labelPortOutCon.Text = ("Chưa kết nối");

                labelPortOutCon.ForeColor = Color.Red;

            }

            else if (serialPortOutgoing.IsOpen)

            {



                labelPortOutCon.Text = ("Đã kết nối");

                labelPortOutCon.ForeColor = Color.Lime;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPortOut.DataSource = SerialPort.GetPortNames();
            comboBoxBaudOut.SelectedIndex = 3;
            comboBoxPortIn.DataSource = SerialPort.GetPortNames();
            comboBoxBaudIn.SelectedIndex = 3;
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            if(labelMode.Text == "Manual")
            {
                labelMode.Text = "Auto";
                labelMode.ForeColor = Color.Lime;
            }
            else
            {
                labelMode.Text = "Manual";
                labelMode.ForeColor = Color.Red;
            }

            if (serialPortOutgoing.IsOpen)
            {
                serialPortOutgoing.Write("2");
            }

        }

        private void buttonConIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPortIncoming.IsOpen)
                {
                    serialPortIncoming.PortName = comboBoxPortOut.Text;

                    serialPortIncoming.BaudRate = Convert.ToInt32(comboBoxBaudOut.Text);

                    serialPortIncoming.Open();

                }
            }
            catch
            {

            }
        }

        private void buttonDisconIn_Click(object sender, EventArgs e)
        {
            if (serialPortIncoming.IsOpen)
            {
                serialPortIncoming.Close();
            }
        }

        private void buttonConOut_Click(object sender, EventArgs e)
        {
            try {
                if (!serialPortOutgoing.IsOpen)
                {
                    serialPortOutgoing.PortName = comboBoxPortOut.Text;

                    serialPortOutgoing.BaudRate = Convert.ToInt32(comboBoxBaudOut.Text);

                    serialPortOutgoing.Open();

                }
            }catch {
                
            }
        }

        private void buttonDisconOut_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen)
            {
                serialPortOutgoing.Close();
            }
        }

        private void buttonOpenWindow_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen){
                serialPortOutgoing.Write("1");
            }
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen){
                serialPortOutgoing.Write("0");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming Port: COM... \nOutgoing Port: COM...", "Connection Port");
        }
    }

}
