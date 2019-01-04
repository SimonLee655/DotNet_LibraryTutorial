using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace client_Form
{
    public partial class Form1 : Form
    {
		//string serverIP = "localhost";
		string serverIP = "192.168.1.61";
		int port = 8080;

        public Form1()
        {
            InitializeComponent();

        }

        private void submit_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(serverIP, port);
           
            int byteCount = Encoding.ASCII.GetByteCount(message.Text);
            byte[] sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes(message.Text);
            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
            stream.Close();
            //client.Close();

        }
    }
}
          

