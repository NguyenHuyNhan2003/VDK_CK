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
        public Form1()
        {
            InitializeComponent();
            // serialPortIncoming.DataReceived += new SerialDataReceivedEventHandler(DataReceive);

            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };

            comboBoxBaudOut.Items.AddRange(BaudRate);
        }

        private void escapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen)
            {
                serialPortOutgoing.Write("2");
            }
            serialPortOutgoing.Close();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
            comboBoxBaudOut.SelectedIndex = 5;
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen)
            {
                if (labelMode.Text == "Manual")
                {
                    labelMode.Text = "Auto";
                    labelMode.ForeColor = Color.Lime;
                }
                else
                {
                    labelMode.Text = "Manual";
                    labelMode.ForeColor = Color.Red;
                }
                serialPortOutgoing.Write("3");
            }
            else
            {
                MessageBox.Show("( ・ω・)☞ Kết nối cổng ra trước (・ω・｀)", "No connection");
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

                    labelPortOutCon.Text = ("Đã kết nối");

                    labelPortOutCon.ForeColor = Color.Lime;

                }
                else
                {
                    MessageBox.Show("(´・ω・`) Can't connect (´・ω・`)", "error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "(_ _。)");
            }
        }

        private void buttonDisconOut_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen)
            {
                serialPortOutgoing.Write("2");
                serialPortOutgoing.Close();
                labelPortOutCon.Text = ("Chưa kết nối");
                labelPortOutCon.ForeColor = Color.Red;
                labelMode.Text = "Auto";
                labelMode.ForeColor = Color.Lime;
            }
        }

        private void buttonOpenWindow_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen){
                serialPortOutgoing.Write("1");
            }
            else
            {
                MessageBox.Show("( ・ω・)☞ Kết nối cổng ra trước (・ω・｀)", "No connection");
            }
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen){
                serialPortOutgoing.Write("0");
            }
            else
            {
                MessageBox.Show("( ・ω・)☞ Kết nối cổng ra trước (・ω・｀)", "No connection");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("( ・ω・)☞ Nothing to see here! （＞ω・)ノ♥", "");
        }

        private void buttonFanOn_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen)
            {
                serialPortOutgoing.Write("4");
            }
            else
            {
                MessageBox.Show("( ・ω・)☞ Kết nối cổng ra trước (・ω・｀)", "No connection");
            }
        }

        private void buttonFanOff_Click(object sender, EventArgs e)
        {
            if (serialPortOutgoing.IsOpen)
            {
                serialPortOutgoing.Write("5");
            }
            else
            {
                MessageBox.Show("( ・ω・)☞ Kết nối cổng ra trước (・ω・｀)", "No connection");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortOutgoing.IsOpen)
            {
                serialPortOutgoing.Write("2");
            }
            serialPortOutgoing.Close();
            MessageBox.Show("   Be safe! （＞ω・)ノ♥", "Bye!");
        }
    }

}
