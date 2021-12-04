using SimpleTCP;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sandruve
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        string nick = string.Empty;

        private void connectBtn_Click(object sender, EventArgs e)
        {
            char[] splitter = { ':' };
            string[] strArray = HostBox.Text.Split(splitter);
            string ipString = strArray[0];
            string portString = strArray[1];
            int portInt = Convert.ToInt32(portString);
            ConnectToTCPServer(ipString, portInt);
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            DisconnectFromTCPServer();
        }

        public void ConnectToTCPServer(string ip, int port)
        {
            try
            {
                client.Connect(ip, port);
                NickBox.Invoke((MethodInvoker)delegate {
                    nick = NickBox.Text;
                    NickBox.Enabled = false;
                });
                client.WriteLine(string.Format("nickname: {0}", nick));
                connectBtn.Invoke((MethodInvoker)delegate {
                    connectBtn.Enabled = false;
                });
                disconnectBtn.Invoke((MethodInvoker)delegate {
                    disconnectBtn.Enabled = true;
                });
                HostBox.Invoke((MethodInvoker)delegate {
                    HostBox.ReadOnly = true;
                });
                sendMsgBox.Invoke((MethodInvoker)delegate {
                    sendMsgBox.Enabled = true;
                });
                SelectImageToSendBtn.Invoke((MethodInvoker)delegate {
                    SelectImageToSendBtn.Enabled = true;
                });
                sendBtn.Invoke((MethodInvoker)delegate {
                    sendBtn.Enabled = true;
                });
                outputTxt.Invoke((MethodInvoker)delegate {
                    outputTxt.Enabled = true;
                });
                Text = string.Format("Sandruve - Клиент (Подключен к {0})", ip);
            } catch (SocketException) {
                MessageBox.Show(string.Format("Подключение не установлено, так как конечный компьютер отверг запрос на подключение {0}.", ip + ":" + port), "Неизвестный хост", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NickBox.Invoke((MethodInvoker)delegate {
                    nick = string.Empty;
                    NickBox.Enabled = true;
                });
                connectBtn.Invoke((MethodInvoker)delegate {
                    connectBtn.Enabled = true;
                });
                disconnectBtn.Invoke((MethodInvoker)delegate {
                    disconnectBtn.Enabled = false;
                });
                HostBox.Invoke((MethodInvoker)delegate {
                    HostBox.ReadOnly = false;
                });
                sendMsgBox.Invoke((MethodInvoker)delegate {
                    sendMsgBox.Enabled = false;
                });
                SelectImageToSendBtn.Invoke((MethodInvoker)delegate {
                    SelectImageToSendBtn.Enabled = false;
                });
                sendBtn.Invoke((MethodInvoker)delegate {
                    sendBtn.Enabled = false;
                });
                outputTxt.Invoke((MethodInvoker)delegate {
                    outputTxt.Enabled = false;
                });
            }
        }

        public void DisconnectFromTCPServer()
        {
            try
            {
                client.Disconnect();
                NickBox.Invoke((MethodInvoker)delegate {
                    nick = string.Empty;
                    NickBox.Enabled = true;
                });
                connectBtn.Invoke((MethodInvoker)delegate {
                    connectBtn.Enabled = true;
                });
                disconnectBtn.Invoke((MethodInvoker)delegate {
                    disconnectBtn.Enabled = false;
                });
                HostBox.Invoke((MethodInvoker)delegate {
                    HostBox.ReadOnly = false;
                });
                sendMsgBox.Invoke((MethodInvoker)delegate {
                    sendMsgBox.Enabled = false;
                });
                SelectImageToSendBtn.Invoke((MethodInvoker)delegate {
                    SelectImageToSendBtn.Enabled = false;
                });
                sendBtn.Invoke((MethodInvoker)delegate {
                    sendBtn.Enabled = false;
                });
                outputTxt.Invoke((MethodInvoker)delegate {
                    outputTxt.Text = "";
                });
                Text = "Sandruve - Клиент";
            }
            catch (Exception exc)
            {
                Console.WriteLine(string.Format("Exception called while DisconnectFromTCPServer()={0}", exc.StackTrace));
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Thread updateTh = new Thread(() => update());
            updateTh.Start();
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        public void update()
        {
            while (true)
            {
                if (nick.Length == 0)
                {
                    string nickname = string.Empty;
                    NickBox.Invoke((MethodInvoker)delegate {
                        nickname = NickBox.Text;
                    });
                    string host = string.Empty;
                    HostBox.Invoke((MethodInvoker)delegate {
                        host = HostBox.Text;
                    });
                    if (nickname.Length != 0 && host.Length != 0)
                    {
                        connectBtn.Invoke((MethodInvoker)delegate {
                            connectBtn.Enabled = true;
                        });
                    }
                    else
                    {
                        connectBtn.Invoke((MethodInvoker)delegate {
                            connectBtn.Enabled = false;
                        });
                    }
                }
            }
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            outputTxt.Invoke((MethodInvoker)delegate {
                string text = e.MessageString;
                string reformatedStr = Utils.ReformatString(text);
                outputTxt.Text = reformatedStr;
            });
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (client.TcpClient != null)
                client.WriteLine(string.Format("{0}", sendMsgBox.Text));
                sendMsgBox.Text = string.Empty;
        }

        private void SelectImageToSendBtn_Click(object sender, EventArgs e)
        {
            if (client.TcpClient != null)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Изображения (*.png;*.jpg)|*.png;*.jpg";
                    ofd.FilterIndex = 1;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = @ofd.FileName;
                        byte[] imgBytes = Utils.GetBytesFromFile(filePath);
                        client.Write(imgBytes);
                    }
                }
            }
        }
    }
}
