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
        ////string serverIP = "localhost";
        //string serverIP = "192.168.1.61";//61";
        ////string serverIP = "127.0.0.1";//61";
        //TcpClient client = new TcpClient();
        //int port = 8080;
        int i = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void submit_Click(object sender, EventArgs e)
        {
            i++;
            message.Text = "hello";
            //Console.WriteLine("Get Response: {response}");
            string uri = "http://192.168.1.166/"+ textBox1.Text;
            //test get method
            var response = HttpUtility.HttpGet(uri);
            //message.Text = $"Get Response: {response}";
            message.Text = $"{response}";

            this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
            this.listBox1.SelectedIndex = -1;

            listBox1.Items.Add($"{response} " + i.ToString());
            //Console.WriteLine($"Get Response: {response}");
            //Console.ReadKey();

        }
    }
}

          

