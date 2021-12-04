using SimpleTCP;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

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
                client = new SimpleTcpClient();
                client.StringEncoder = Encoding.UTF8;
                client.DataReceived += Client_DataReceived;
                client.Connect(ip, port);
                NickBox.Invoke((MethodInvoker)delegate {
                    nick = NickBox.Text;
                });
                client.WriteLine(string.Format("nickname: {0}", nick));
                Text = string.Format("Sandruve - Клиент (Подключен к {0})", ip);
            } catch (SocketException) {
                MessageBox.Show(string.Format("Подключение не установлено, так как конечный компьютер отверг запрос на подключение {0}.", ip + ":" + port), "Неизвестный хост", MessageBoxButtons.OK, MessageBoxIcon.Error);
                client = null;
                nick = string.Empty;
            }
        }

        public void DisconnectFromTCPServer()
        {
            client.Disconnect();
            client = null;
            nick = string.Empty;
            Text = "Sandruve - Клиент";
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Thread updateTh = new Thread(() => update());
            updateTh.Start();

            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public void update()
        {
            while (true)
            {
                if (client == null)
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
                    outputTxt.Invoke((MethodInvoker)delegate {
                        outputTxt.Enabled = false;
                        outputTxt.Text = "";
                    });
                    sendMsgBox.Invoke((MethodInvoker)delegate {
                        sendMsgBox.Enabled = false;
                    });
                    disconnectBtn.Invoke((MethodInvoker)delegate {
                        disconnectBtn.Enabled = false;
                    });
                    sendBtn.Invoke((MethodInvoker)delegate {
                        sendBtn.Enabled = false;
                    });
                    SelectImageToSendBtn.Invoke((MethodInvoker)delegate {
                        SelectImageToSendBtn.Enabled = false;
                    });
                    HostBox.Invoke((MethodInvoker)delegate {
                        HostBox.ReadOnly = false;
                    });
                    NickBox.Invoke((MethodInvoker)delegate {
                        NickBox.ReadOnly = false;
                    });
                }
                else
                {
                    connectBtn.Invoke((MethodInvoker)delegate {
                        connectBtn.Enabled = false;
                    });
                    outputTxt.Invoke((MethodInvoker)delegate {
                        outputTxt.Enabled = true;
                    });
                    sendMsgBox.Invoke((MethodInvoker)delegate {
                        sendMsgBox.Enabled = true;
                    });
                    disconnectBtn.Invoke((MethodInvoker)delegate {
                        disconnectBtn.Enabled = true;
                    });
                    sendBtn.Invoke((MethodInvoker)delegate {
                        sendBtn.Enabled = true;
                    });
                    SelectImageToSendBtn.Invoke((MethodInvoker)delegate {
                        SelectImageToSendBtn.Enabled = true;
                    });
                    HostBox.Invoke((MethodInvoker)delegate {
                        HostBox.ReadOnly = true;
                    });
                    NickBox.Invoke((MethodInvoker)delegate {
                        NickBox.ReadOnly = true;
                    });
                }
            }
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            outputTxt.Invoke((MethodInvoker)delegate {
                string text = e.MessageString;
                string reformatedStr = Utils.ReformatString(text);
                if (reformatedStr.StartsWith("ban") || reformatedStr.StartsWith("kick"))
                {
                    string[] splitedStr = reformatedStr.Split(new char[] { ':' });
                    string action = splitedStr[0];
                    string nickToAction = splitedStr[1].Replace(" ", "");
                    if (nickToAction == nick)
                    {
                        if (action == "kick" || action == "ban")
                        {
                            DisconnectFromTCPServer();
                        }
                    }
                }
                else
                {
                    outputTxt.Text = reformatedStr;
                }
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
