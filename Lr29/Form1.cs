using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lr29
{
    public partial class Form1 : Form
    {
        bool alive = false; // чи буде працювати потік для приймання
        UdpClient client;
        const int LOCALPORT = 8001; // порт для приймання повідомлень
        const int REMOTEPORT = 8001; // порт для передавання повідомлень
        const int TTL = 20;
        const string HOST = "235.5.5.1"; // хост для групового розсилання
        IPAddress groupAddress; // адреса для групового розсилання
        string userName; // ім’я користувача в чаті
        public Form1()
        {
            InitializeComponent();
            loginButton.Enabled = true; // кнопка входу
            logoutButton.Enabled = false; // кнопка виходу
            sendButton.Enabled = false; // кнопка отправки
            chatTextBox.ReadOnly = true; // поле для повідомлень
            groupAddress = IPAddress.Parse(HOST);
        }

        // обробник натискання кнопок loginButton
        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            userNameTextBox.ReadOnly = true;
            try
            {
                client = new UdpClient(LOCALPORT);
                //підєднання до групового розсилання
                client.JoinMulticastGroup(groupAddress, TTL);

                // задача на приймання повідомлень
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();
                // перше повідомлення про вхід нового користувача
                string message = userName + " увійшов до чату";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // метод приймання повідомлення
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
                    // додаємо отримане повідомлення в текстове поле
                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        chatTextBox.Text = time + " " + message + "\r\n"
                        + chatTextBox.Text;
                    }));
                    // зберігаємо повідомлення в файл
                    string time1 = DateTime.Now.ToShortTimeString();
                    string logMessage = time1 + " " + message + "\r\n";
                    string fileName = "log.txt";
                    if (!System.IO.File.Exists(fileName))
                    {
                        using (System.IO.File.Create(fileName)) { }
                    }
                    System.IO.File.AppendAllText(fileName, logMessage);
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // обробник натискання кнопки sendButton
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName,
               messageTextBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // обробник натискання кнопки logoutButton
        private void logoutButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }
        private void ExitChat()
        {
            string message = userName + " виходить з чату";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);
            alive = false;
            client.Close();
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
        }
        // обробник події закриття форми
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }
        private void ConfigureChat()
        {
            try
            {
                IPAddress address;
                if (!IPAddress.TryParse(addressTextBox.Text, out address))
                {
                    MessageBox.Show("Невірна адреса");
                    return;
                }

                int port;
                if (!int.TryParse(portTextBox.Text, out port) || port < 1 || port > 65535)
                {
                    MessageBox.Show("Невірний номер порту");
                    return;
                }

                groupAddress = address;
                 port= REMOTEPORT;
                client.Close();
                client = new UdpClient(LOCALPORT);
                client.JoinMulticastGroup(groupAddress, TTL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = chatTextBox.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                chatTextBox.Font = fontDialog.Font;
                chatTextBox.ForeColor = fontDialog.Color;
            }
        }

        private void configureButton_Click(object sender, EventArgs e)
        {
            ConfigureChat();
        }
    }
}

