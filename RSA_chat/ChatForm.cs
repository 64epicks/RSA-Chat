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
using System.Threading;
using System.Security;
using System.Security.Cryptography;
using System.IO;

/* 
List of protocol letter types:
T = Encrypted readable message to user.
H = Heartbeat request / heartbeat confirmation.
K = Public key send.
O = Remote public key accept.
R = Connection request to remote.
*/


namespace RSA_chat
{
    public partial class ChatForm : Form
    {
        #region var

        delegate void AddMessage(string message);

        private static Random random = new Random();

        string userName;

        bool est = false;

        bool ready = false;

        bool ongoingHeartBeat = false;

        string reUsrName;

        string reIP;

        int rePort;

        static int port;
        static string broadcastAddress;

        static string heartBeatString;

        static string localIP = GetPublicIP();

        private string pubKeyString;
        private string privKeyString;

        private string remotePubKeyString;

        //Adding the udp clients
        static UdpClient receivingClient;
        static UdpClient sendingClient;
        static UdpClient heartBeatSendingClient;

        Thread receivingThread;
        #endregion
        #region Init
        public ChatForm()
        {
            //Initializing the program
            InitializeComponent();
            this.Load += new EventHandler(ChatForm_Load);
            btnSend.Click += new EventHandler(btnSend_Click);
        }

        void ChatForm_Load(object sender, EventArgs e)
        {
            InitializeReceiver();
            //this.Hide();

            //using (LoginForm loginForm = new LoginForm())
            //{
            //    loginForm.ShowDialog();

            //    if (loginForm.UserName == "") 
            //    this.Close();
            //    else
            //    {
            //        userName = loginForm.UserName;
            //        this.Show();
            //    }
            //}

        }
        //Initializing the sender
        private void InitializeSender(string initAdrss, int initPort)
        {
            sendingClient = new UdpClient(initAdrss, initPort);
            sendingClient.EnableBroadcast = true;
        }

        //Heartbeat client does not initialize on startup. It will when the heartbeat protocol is triggered
        private void InitializeHeartBeatSender(string heartBeatIP, int heartBeatPort)
        {
            heartBeatSendingClient = new UdpClient(heartBeatIP, heartBeatPort);
            heartBeatSendingClient.EnableBroadcast = true;
        }

        //Initializing the receiver
        private void InitializeReceiver()
        {
            receivingClient = new UdpClient(port);

            ThreadStart start = new ThreadStart(Receiver);
            receivingThread = new Thread(start);
            receivingThread.IsBackground = true;
            receivingThread.Start();
        }
        private void btnEntr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIP.Text) || string.IsNullOrEmpty(tbPORT.Text) || string.IsNullOrEmpty(tbUsr.Text))
            {
                MessageBox.Show("Please enter all values");
                return;
            }
            else
            {
                broadcastAddress = tbIP.Text;
                port = Int32.Parse(tbPORT.Text);
                userName = tbUsr.Text;

                tbSend.Focus();

                enterChatMode();


                rtbChat.Text += "Connecting to " + broadcastAddress + "...\n";

                InitializeSender(broadcastAddress, port);

                conRe();
            }
        }
        #endregion
        #region Receiver
        public void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            AddMessage messageDelegate = MessageReceived;

            while (true)
            {
                byte[] data = receivingClient.Receive(ref endPoint);
                var message = Encoding.ASCII.GetString(data);
                string messageType = message[0].ToString();
                string messageWOPro = message.Substring(1);
                if(messageType == "R")
                {
                    if (est != true)
                    {
                        reUsrName = ExtractString(messageWOPro, "username");
                        reIP = ExtractString(messageWOPro, "ip");
                        string rePortString = ExtractString(messageWOPro, "port");
                        rePort = Int32.Parse(rePortString);

                        lbReName.Text = reUsrName;
                        lbReIP.Text = reIP + ":" + rePort;

                        lbRe.Show();
                        lbReName.Show();
                        lbReIP.Show();
                        btnReAc.Show();
                        btnReDe.Show();
                    }
                }
                if(messageType == "A")
                {
                    rtbChat.Text += "Remote accepted!\n";

                    int bitlength = 2048;
                    est = true;
                    rtbChat.Text += "Generating " + bitlength + "-bit key...\n";

                    generateKey(bitlength);

                    rtbChat.Text += "Success!\n";
                }
                if(messageType == "D")
                {
                    rtbChat.Text += "Remote denyed request\n";
                }
                if (messageType == "H")
                {
                    ongoingHeartBeat = true;
                    if (message == heartBeatString)
                    {
                        

                        rtbChat.Text += "Success!\n";
                    }
                    else
                    {
                        ongoingHeartBeat = true;
                        string sendToWOPro = message.Substring(1);
                        string sendTo = sendToWOPro.Remove(sendToWOPro.Length - 5);
                        int sendToPort = Int32.Parse(message.TrimStart(Convert.ToChar("H" + sendTo)));
                        InitializeHeartBeatSender(sendTo, sendToPort);
                        byte[] heartBeatBack = Encoding.ASCII.GetBytes(message);

                        heartBeatSendingClient.Send(heartBeatBack, heartBeatBack.Length);

                    }
                }
                if (ready == true)
                {
                    if (ongoingHeartBeat == true)
                    {
                        ongoingHeartBeat = false;
                    }
                    else
                    {
                        //get a stream from the string
                        var sr = new System.IO.StringReader(privKeyString);
                        //we need a deserializer
                        var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                        //get the object back from the stream
                        var privKey = (RSAParameters)xs.Deserialize(sr);

                        var bytesCypherText = Convert.FromBase64String(message);

                        var csp = new RSACryptoServiceProvider();
                        csp.ImportParameters(privKey);

                        var bytesPlainTextData = csp.Decrypt(bytesCypherText, false);

                        var plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);

                        message = plainTextData;
                    }
                }
                messageType = message[0].ToString();
                if (messageType == "K")
                {
                    remotePubKeyString = message.Substring(1);
                    ready = true;
                    string acceptToSend = "O" + pubKeyString;
                    byte[] acceptData = Encoding.ASCII.GetBytes(acceptToSend);
                    sendingClient.Send(acceptData, acceptData.Length);
                }
                if (messageType == "O")
                {
                    ready = true;
                    remotePubKeyString = message.Substring(1);
                    rtbChat.Text += "Remote accepted\n";
                    rtbChat.Text += "Remote public key is: " + remotePubKeyString + "\n";
                    rtbChat.Text += "Your public key is: " + pubKeyString + "\n";
                    rtbChat.Text += "Your private key is: " + privKeyString + "\n";
                }
                if (messageType == "T")
                {
                    string messageShow = message.Substring(1);
                    Invoke(messageDelegate, messageShow);
                }
            }
        }

        private void MessageReceived(string message)
        {
            rtbChat.Text += message + "\n";
        }
        #endregion  
        #region Sender
        void btnSend_Click(object sender, EventArgs e)
        {
            tbSend.Text = tbSend.Text.TrimEnd();

            if (!string.IsNullOrEmpty(tbSend.Text))
            {
                if (ready == true)
                {


                    //get a stream from the string
                    var sr = new System.IO.StringReader(remotePubKeyString);
                    //we need a deserializer
                    var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                    //get the object back from the stream
                    var pubKey = (RSAParameters)xs.Deserialize(sr);

                    var csp = new RSACryptoServiceProvider();
                    csp.ImportParameters(pubKey);

                    string toSend = "T" + userName + ": " + tbSend.Text;
                    string toShow = toSend.Substring(1);

                    var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(toSend);

                    var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

                    string cypherText = Convert.ToBase64String(bytesCypherText);

                    rtbChat.Text += toShow + "\n";
                    byte[] data = Encoding.ASCII.GetBytes(cypherText);
                    sendingClient.Send(data, data.Length);
                    tbSend.Text = "";
                }
            }

            tbSend.Focus();
        }
        #endregion
        #region Heartbeat
        public static void heartBeat()
        {
            heartBeatString = "H" + localIP + port;

            byte[] heartBeatData = Encoding.ASCII.GetBytes(heartBeatString);

            sendingClient.Send(heartBeatData, heartBeatData.Length);

        }
        private void btnHeartBeat_Click(object sender, EventArgs e)
        {
            rtbChat.Text += "Doing a heartbeat to " + broadcastAddress + "...\n";
            heartBeat();
        }
        #endregion
        #region Connection request
        void conRe()
        {
            string conReToSend = "R" + "<ip>" + localIP + "</ip><port>" + port + "</port><username>" + userName + "</username>";
            byte[] reData = Encoding.ASCII.GetBytes(conReToSend);
            sendingClient.Send(reData, reData.Length);
        }
        #endregion
        #region Other
        void enterChatMode()
        {
            lbIP.Hide();
            lbPor.Hide();
            lbPORT.Hide();
            lbUsr.Hide();
            tbIP.Hide();
            tbPORT.Hide();
            tbUsr.Hide();
            btnEntr.Hide();

            rtbChat.Show();
            tbSend.Show();
            tbCngIP.Show();
            tbCngPort.Show();
            btnCng.Show();
            btnSend.Show();
            btnHeartBeat.Show();
            //btnCnt.Show();
            lbPortCng.Show();

            tbCngIP.Text = broadcastAddress;
            tbCngPort.Text = port.ToString();
        }
        public static string GetPublicIP()
        {
            String direction = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                direction = stream.ReadToEnd();
            }

            //Search for the ip in the html
            int first = direction.IndexOf("Address: ") + 9;
            int last = direction.LastIndexOf("</body>");
            direction = direction.Substring(first, last - first);

            return direction;
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        string ExtractString(string s, string tag)
        {
            // You should check for errors in real-world code, omitted for brevity
            var startTag = "<" + tag + ">";
            int startIndex = s.IndexOf(startTag) + startTag.Length;
            int endIndex = s.IndexOf("</" + tag + ">", startIndex);
            return s.Substring(startIndex, endIndex - startIndex);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void rtbChat_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtbChat.SelectionStart = rtbChat.Text.Length;
            // scroll it automatically
            rtbChat.ScrollToCaret();
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void tbSend_Enter(object sender, EventArgs e)
        {

        }
        private void ChatForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbSend_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnReAc_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbUsr.Text))
            {
                MessageBox.Show("Please enter a username");
                return;
            }
            else
            {
                broadcastAddress = reIP;
                port = rePort;
                InitializeSender(broadcastAddress, port);

                lbRe.Hide();
                lbReName.Hide();
                lbReIP.Hide();
                btnReAc.Hide();
                btnReDe.Hide();

                enterChatMode();

                byte[] acData = Encoding.ASCII.GetBytes("A");
                sendingClient.Send(acData, acData.Length);

                est = true;
            }

        }

        private void btnReDe_Click(object sender, EventArgs e)
        {
            lbRe.Hide();
            lbReName.Hide();
            lbReIP.Hide();
            btnReAc.Hide();
            btnReDe.Hide();

            byte[] deData = Encoding.ASCII.GetBytes("D");
            InitializeSender(reIP, rePort);
            sendingClient.Send(deData, deData.Length);
        }
        void generateKey(int keylength)
        {
            #region Key generation and exchange

            var csp = new RSACryptoServiceProvider(keylength);

            var privKey = csp.ExportParameters(true);

            var pubKey = csp.ExportParameters(false);

            string pubKeyStringLocal;
            {
                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xsw = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xsw.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyStringLocal = sw.ToString();
                pubKeyString = pubKeyStringLocal;
            }
            string privKeyStringLocal;
            {
                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xsx = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xsx.Serialize(sw, privKey);
                //get the string from the stream
                privKeyStringLocal = sw.ToString();
                privKeyString = privKeyStringLocal;
            }

            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(pubKey);

            string keyToSend = "K" + pubKeyString;
            byte[] keydata = Encoding.ASCII.GetBytes(keyToSend);

            rtbChat.Text += "Sending public key to remote...\n";

            sendingClient.Send(keydata, keydata.Length);

            #endregion
        }
    }
}
