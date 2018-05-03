namespace RSA_chat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbPORT = new System.Windows.Forms.Label();
            this.lbUsr = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPORT = new System.Windows.Forms.TextBox();
            this.tbUsr = new System.Windows.Forms.TextBox();
            this.lbPor = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHeartBeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(12, 461);
            this.tbSend.MaxLength = 968;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(628, 20);
            this.tbSend.TabIndex = 1;
            this.tbSend.TabStop = false;
            this.tbSend.Visible = false;
            this.tbSend.TextChanged += new System.EventHandler(this.tbSend_TextChanged);
            this.tbSend.Enter += new System.EventHandler(this.tbSend_Enter);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(646, 461);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 20);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbChat
            // 
            this.rtbChat.Location = new System.Drawing.Point(12, 12);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(764, 443);
            this.rtbChat.TabIndex = 2;
            this.rtbChat.TabStop = false;
            this.rtbChat.Text = "";
            this.rtbChat.Visible = false;
            this.rtbChat.TextChanged += new System.EventHandler(this.rtbChat_TextChanged);
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIP.Location = new System.Drawing.Point(189, 110);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(74, 18);
            this.lbIP.TabIndex = 3;
            this.lbIP.Text = "IP adress:";
            // 
            // lbPORT
            // 
            this.lbPORT.AutoSize = true;
            this.lbPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPORT.Location = new System.Drawing.Point(217, 142);
            this.lbPORT.Name = "lbPORT";
            this.lbPORT.Size = new System.Drawing.Size(0, 18);
            this.lbPORT.TabIndex = 4;
            // 
            // lbUsr
            // 
            this.lbUsr.AutoSize = true;
            this.lbUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsr.Location = new System.Drawing.Point(182, 174);
            this.lbUsr.Name = "lbUsr";
            this.lbUsr.Size = new System.Drawing.Size(81, 18);
            this.lbUsr.TabIndex = 5;
            this.lbUsr.Text = "Username:";
            this.lbUsr.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.Location = new System.Drawing.Point(269, 110);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(235, 26);
            this.tbIP.TabIndex = 6;
            // 
            // tbPORT
            // 
            this.tbPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPORT.Location = new System.Drawing.Point(269, 142);
            this.tbPORT.Name = "tbPORT";
            this.tbPORT.Size = new System.Drawing.Size(235, 26);
            this.tbPORT.TabIndex = 7;
            // 
            // tbUsr
            // 
            this.tbUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsr.Location = new System.Drawing.Point(269, 174);
            this.tbUsr.Name = "tbUsr";
            this.tbUsr.Size = new System.Drawing.Size(235, 26);
            this.tbUsr.TabIndex = 8;
            // 
            // lbPor
            // 
            this.lbPor.AutoSize = true;
            this.lbPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPor.Location = new System.Drawing.Point(223, 142);
            this.lbPor.Name = "lbPor";
            this.lbPor.Size = new System.Drawing.Size(40, 18);
            this.lbPor.TabIndex = 9;
            this.lbPor.Text = "Port:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(269, 207);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(235, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHeartBeat
            // 
            this.btnHeartBeat.Location = new System.Drawing.Point(646, 487);
            this.btnHeartBeat.Name = "btnHeartBeat";
            this.btnHeartBeat.Size = new System.Drawing.Size(130, 21);
            this.btnHeartBeat.TabIndex = 11;
            this.btnHeartBeat.Text = "Heartbeat";
            this.btnHeartBeat.UseVisualStyleBackColor = true;
            this.btnHeartBeat.Visible = false;
            this.btnHeartBeat.Click += new System.EventHandler(this.btnHeartBeat_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 520);
            this.Controls.Add(this.btnHeartBeat);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbPor);
            this.Controls.Add(this.tbUsr);
            this.Controls.Add(this.tbPORT);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.lbUsr);
            this.Controls.Add(this.lbPORT);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbSend);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChatForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPORT;
        private System.Windows.Forms.Label lbUsr;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPORT;
        private System.Windows.Forms.TextBox tbUsr;
        private System.Windows.Forms.Label lbPor;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHeartBeat;
    }
}