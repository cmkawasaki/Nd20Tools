using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace mIRCBotCmdHarness
{
    class genericIRCBot
    {
        private int port;
        private string serverName;
        private System.Timers.Timer pingTimer;
        private TcpClient client;
        private bool isConnected;
        private Thread inputThread;

        protected TextWriter writer;
        protected TextReader reader;

        public string textNickname;

        public static object messageLock = new object();
        public List<IRCMessage> messageQueue = new List<IRCMessage>();

        public genericIRCBot (string ServerName, int Port, string nickname)
	    {
            this.port = Port;
            this.serverName = ServerName;
            this.textNickname = nickname;
            this.isConnected = false;
            this.messageQueue = new List<IRCMessage>();
	    }

        //Server: irc.otherworlders.org
        //Port: 6668
        public void ConnectServer()
        {
            if (!this.isConnected)
            {
                this.client = new TcpClient(this.serverName, this.port);
                //client.Connect(this.serverName, this.port);

                NetworkStream stream = client.GetStream();
                this.writer = new StreamWriter(stream);
                this.reader = new StreamReader(stream);

                pingTimer = new System.Timers.Timer(15000);
                pingTimer.Elapsed += pingTimer_Elapsed;
                pingTimer.Start();

                // Give server our information
                writer.WriteLine("NICK " + this.textNickname);
                writer.Flush();
                this.writer.WriteLine("USER " + this.textNickname + " 8 * :Test Dice Bot");
                writer.Flush();

                Thread pipingThread = new Thread((ThreadStart)delegate()
                {
                    string line;

                    do
                    {
                        line = this.reader.ReadLine();
                        Console.WriteLine(line);
                        IRCMessage message = new IRCMessage(line);
                        lock (genericIRCBot.messageLock)
                        {
                            this.messageQueue.Add(message);
                        }
                    }
                    while (line != null);
                });

                pipingThread.Start();

                WaitForMessage("001");

                this.isConnected = true;
            }

        }

        private void WaitForMessage(string messageName)
        {
            bool conditionFound = false;

            while (conditionFound == false)
            {
                lock (genericIRCBot.messageLock)
                {
                    for (int i = 0; i < this.messageQueue.Count; i++)
                    {
                        if (this.messageQueue[i].CommandName == messageName)
                        {
                            conditionFound = true;
                            this.messageQueue.RemoveAt(i);
                            i--;
                            break;
                        }
                        else
                        {
                            this.messageQueue.RemoveAt(i);
                            i--;
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }
        public void DisconnectServer()
        {
            if (this.isConnected)
            {
                this.isConnected = false;
                this.inputThread.Abort();
                this.writer.WriteLine("QUIT :Have a nice day!");
                writer.Flush();
                pingTimer.Stop();
                this.client.Close();
            }
        }

        void pingTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.isConnected)
            {
                this.writer.WriteLine("PING :" + this.serverName);
                this.writer.Flush();
                Console.WriteLine("PING Sent!");
            }
        }

        public void JoinChannel(string channelName)
        {
            this.writer.WriteLine("JOIN " + channelName);
            writer.Flush();
        }

        public void PartChannel(string channelName)
        {
            this.writer.WriteLine("PART " + channelName);
            writer.Flush();
        }

        public void messageChannel(string channelName, string message)
        {
            this.writer.WriteLine("PRIVMSG  " + channelName + " :" + message);
            writer.Flush();
        }

        public void messagePerson(string userName, string message)
        {
            this.writer.WriteLine("PRIVMSG  " + userName + " :" + message);
            writer.Flush();
        }
    }
}
