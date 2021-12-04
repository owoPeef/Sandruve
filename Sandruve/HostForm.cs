﻿using SimpleTCP;
using System;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sandruve
{
    public partial class HostForm : Form
    {
        public HostForm()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        string clientsText = string.Empty;
        int[] exceptionCodes = { 0 };
        string[] exceptionMessages = { "Обычно разрешается только одно использование адреса сокета (протокол/сетевой адрес/порт)" };

        int listeningCount = 0;
        List<EndPoint> listeningEndPoints = new List<EndPoint>();
        List<IPAddress> listeningAddresses = new List<IPAddress>();
        List<int> listeningPorts = new List<int>();
        List<string> listeningNicknames = new List<string>();

        private void HostForm_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
        }

        private void Server_ClientDisconnected(object sender, TcpClient e)
        {
            string txt = string.Format("{0} отключился.{1}", e.Client.RemoteEndPoint, Environment.NewLine);
            int i = 0;
            foreach (EndPoint lep in listeningEndPoints)
            {
                if (lep == e.Client.RemoteEndPoint)
                {
                    listeningEndPoints.Remove(lep);
                    listeningAddresses.Remove(listeningAddresses[i]);
                    listeningPorts.Remove(listeningPorts[i]);
                    listeningNicknames.Remove(listeningNicknames[i]);
                    listeningCount--;
                    listeningsCountLabel.Invoke((MethodInvoker)delegate {
                        listeningsCountLabel.Text = string.Format("Подключено: {0}", listeningCount);
                    });
                    break;
                }
                i++;
            }
            ClientUpdate();
            outputTxt.Invoke((MethodInvoker)delegate {
                if (clientsText.Length == 0)
                {
                    clientsText += txt;
                }
                else if (clientsText.Length > 0)
                {
                    clientsText += Environment.NewLine + txt;
                }
                outputTxt.Text += Environment.NewLine + txt;
                server.BroadcastLine(clientsText);
            });
        }

        private void Server_ClientConnected(object sender, TcpClient e)
        {
            listeningEndPoints.Add(e.Client.RemoteEndPoint);
            string[] splitedStr = e.Client.RemoteEndPoint.ToString().Split(new char[] { ':' });
            IPAddress ip = IPAddress.Parse(splitedStr[0]);
            int port = int.Parse(splitedStr[1]);
            listeningAddresses.Add(IPAddress.Parse(ip.ToString()));
            listeningPorts.Add(port);
            string txt = string.Format("{0} подключился.", e.Client.RemoteEndPoint);
            listeningCount++;
            listeningsCountLabel.Invoke((MethodInvoker)delegate {
                listeningsCountLabel.Text = string.Format("Подключено: {0}", listeningCount);
            });
            outputTxt.Invoke((MethodInvoker)delegate {
                if (clientsText.Length == 0)
                {
                    clientsText += txt;
                }
                else if (clientsText.Length > 0)
                {
                    clientsText += Environment.NewLine + txt;
                }
                outputTxt.Text += Environment.NewLine + txt;
                server.BroadcastLine(clientsText);
            });
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            string formatedStr = Utils.ReformatString(e.MessageString);
            if (formatedStr.StartsWith("nickname"))
            {
                string a = formatedStr.Split(new char[] { ':' })[1].Replace(" ", "");
                listeningNicknames.Add(a);
                Console.WriteLine(string.Format("new listener ({0}:{1}, {2})", listeningAddresses[listeningAddresses.Count-1], listeningPorts[listeningPorts.Count-1], listeningNicknames[listeningNicknames.Count-1]));
                ClientUpdate();
            }
            else
            {
                string txt = formatedStr + Environment.NewLine;
                if (e.Data != null)
                {
                    byte[] byteData = e.Data;
                    string fileExt = Utils.GetMimeTypeFromImageByteArray(byteData);
                    if (fileExt != null)
                    {
                        if (fileExt == "image/png" || fileExt == "image/jpeg")
                        {
                            using (var ms = new MemoryStream(byteData))
                            {
                                string savedFileExt = fileExt.Split(new char[] { '/' })[1].Replace("e", string.Empty);
                                using (var fs = new FileStream(string.Format(@"E:\GitHub\VisualStudio\Sandruve\Sandruve\bin\Debug\test.{0}", savedFileExt), FileMode.Create))
                                {
                                    ms.WriteTo(fs);
                                }
                            }
                        }
                    }
                }
                outputTxt.Invoke((MethodInvoker)delegate {
                    string userSender = string.Empty;
                    int i = 0;
                    foreach (EndPoint ep in listeningEndPoints)
                    {
                        if (ep == e.TcpClient.Client.RemoteEndPoint)
                        {
                            clientsText += string.Format("{0}{1}: {2}", Environment.NewLine, listeningNicknames[i], txt);
                            outputTxt.Text += string.Format("{0}{1}: {2}", Environment.NewLine, listeningNicknames[i], txt);
                        }
                        i++;
                    }
                    server.BroadcastLine(clientsText);
                });
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            outputTxt.Text = "Запуск Сервера...";
            char[] splitter = { ':' };
            string[] strArray = HostBox.Text.Split(splitter);
            string ipString = strArray[0];
            string portString = strArray[1];
            int portInt = Convert.ToInt32(portString);
            IPAddress ip = IPAddress.Parse(ipString);
            try
            {
                server.Start(ip, portInt);
                outputTxt.Text += Environment.NewLine + string.Format("Сервер запущен по IP: {0}", ip);
                HostBox.ReadOnly = true;
                startBtn.Enabled = false;
                listeningsCountLabel.Visible = true;
            }
            catch (Exception exc)
            {
                int i = 0;
                foreach (string excMsg in exceptionMessages)
                {
                    if (excMsg == exc.Message)
                    {
                        outputTxt.Text += Environment.NewLine + string.Format("При включении сервера произошла ошибка с кодом: {0}", exceptionCodes[i]);
                    }
                    i++;
                }
                HostBox.ReadOnly = false;
                startBtn.Enabled = true;
                listeningsCountLabel.Visible = false;
            }
        }

        public void ClientUpdate()
        {
            List<string> listeners = new List<string>();
            int f = 0;
            listeningsDisplayedList.Invoke((MethodInvoker)delegate {
                listeningsDisplayedList.Items.Clear();
            });
            foreach (string ln in listeningNicknames)
            {
                listeners.Add(string.Format("{0} ({1})", ln, listeningPorts[f]));
                f++;
            }
            foreach (string listener in listeners)
            {
                listeningsDisplayedList.Invoke((MethodInvoker)delegate {
                    listeningsDisplayedList.Items.Add(listener);
                });
            }
        }
    }
}
