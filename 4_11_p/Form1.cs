using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic.PowerPacks;

namespace _4_11_p
{
    public partial class Form1 : Form
    {
        UdpClient U;
        Thread Th;
        ShapeContainer C;
        ShapeContainer D;
        Point StartP;
        string p;

        public Form1()
        {
            InitializeComponent();
        }
        private void Listen()
        {
            /*if (textBox_port.Text != null)//port不為空時 進入下列程式
            {
                int port = int.Parse(textBox_port.Text);
                U = new UdpClient(port);
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                while (true)
                {
                    byte[] B = U.Receive(ref EP);
                    textBox_ReceiveText.Text = Encoding.Default.GetString(B);
                }
            }*/


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C = new ShapeContainer();
            this.Controls.Add(C);
            D = new ShapeContainer();
            this.Controls.Add(D);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Th = new Thread(Listen);
            Th.Start();
            button1.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Th.Abort();
                U.Close();
            }
            catch
            {

            }
        }
    }
}
