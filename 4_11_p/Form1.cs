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
            if (textBox_port.Text != null)//port不為空時 進入下列程式
            {
                int port = int.Parse(textBox_port.Text);
                U = new UdpClient(port);
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                while (true)
                {
                    byte[] B = U.Receive(ref EP);
                    string A = Encoding.Default.GetString(B);
                    string[] Q = A.Split('/');
                    Point[] R = new Point[Q.Length];
                    for(int i =0;i<Q.Length;i++)
                    {
                        string[] K = Q[i].Split(',');
                        R[i].X = int.Parse(K[0]);
                        R[i].Y = int.Parse(K[1]);

                    }
                    for (int i = 0; i < Q.Length-1; i++)
                    {
                        LineShape L = new LineShape();
                        L.StartPoint = R[i];
                        L.EndPoint = R[i + 1];
                        L.Parent = D;
                    }
                }
            }


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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            StartP = e.Location;
            p =StartP.X.ToString()+","+StartP.Y.ToString();

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==System.Windows.Forms.MouseButtons.Left)
            {
                LineShape L = new LineShape();
                L.StartPoint = StartP;
                L.EndPoint = e.Location;
                L.Parent = C;
                StartP = e.Location;
                p += "/" + StartP.X.ToString() + "," + StartP.Y.ToString();

            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int port = int.Parse(textBox_targetPort.Text);
            byte[] B = Encoding.Default.GetBytes(p);
            UdpClient S = new UdpClient(textbox_targetIP.Text,port);
            S.Send(B, B.Length);
            S.Close();
        }
    }
}
