﻿namespace RSA_chat
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
            this.btnEntr = new System.Windows.Forms.Button();
            this.btnHeartBeat = new System.Windows.Forms.Button();
            this.btnCng = new System.Windows.Forms.Button();
            this.tbCngPort = new System.Windows.Forms.TextBox();
            this.lbPortCng = new System.Windows.Forms.Label();
            this.tbCngIP = new System.Windows.Forms.TextBox();
            this.lbRe = new System.Windows.Forms.Label();
            this.lbReName = new System.Windows.Forms.Label();
            this.lbReIP = new System.Windows.Forms.Label();
            this.btnReAc = new System.Windows.Forms.Button();
            this.btnReDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSend
            // 
            this.tbSend.Enabled = false;
            this.tbSend.Location = new System.Drawing.Point(12, 488);
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
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(646, 488);
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
            this.rtbChat.Location = new System.Drawing.Point(12, 38);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(764, 444);
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
            this.lbIP.Location = new System.Drawing.Point(189, 142);
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
            this.lbUsr.Location = new System.Drawing.Point(182, 110);
            this.lbUsr.Name = "lbUsr";
            this.lbUsr.Size = new System.Drawing.Size(81, 18);
            this.lbUsr.TabIndex = 5;
            this.lbUsr.Text = "Username:";
            this.lbUsr.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.Location = new System.Drawing.Point(269, 142);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(235, 26);
            this.tbIP.TabIndex = 6;
            // 
            // tbPORT
            // 
            this.tbPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPORT.Location = new System.Drawing.Point(269, 174);
            this.tbPORT.Name = "tbPORT";
            this.tbPORT.Size = new System.Drawing.Size(235, 26);
            this.tbPORT.TabIndex = 7;
            // 
            // tbUsr
            // 
            this.tbUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsr.Location = new System.Drawing.Point(269, 110);
            this.tbUsr.Name = "tbUsr";
            this.tbUsr.Size = new System.Drawing.Size(235, 26);
            this.tbUsr.TabIndex = 8;
            // 
            // lbPor
            // 
            this.lbPor.AutoSize = true;
            this.lbPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPor.Location = new System.Drawing.Point(223, 174);
            this.lbPor.Name = "lbPor";
            this.lbPor.Size = new System.Drawing.Size(40, 18);
            this.lbPor.TabIndex = 9;
            this.lbPor.Text = "Port:";
            // 
            // btnEntr
            // 
            this.btnEntr.Location = new System.Drawing.Point(269, 207);
            this.btnEntr.Name = "btnEntr";
            this.btnEntr.Size = new System.Drawing.Size(235, 23);
            this.btnEntr.TabIndex = 10;
            this.btnEntr.Text = "Connect";
            this.btnEntr.UseVisualStyleBackColor = true;
            this.btnEntr.Click += new System.EventHandler(this.btnEntr_Click);
            // 
            // btnHeartBeat
            // 
            this.btnHeartBeat.Location = new System.Drawing.Point(12, 12);
            this.btnHeartBeat.Name = "btnHeartBeat";
            this.btnHeartBeat.Size = new System.Drawing.Size(130, 21);
            this.btnHeartBeat.TabIndex = 11;
            this.btnHeartBeat.Text = "Check connection";
            this.btnHeartBeat.UseVisualStyleBackColor = true;
            this.btnHeartBeat.Visible = false;
            this.btnHeartBeat.Click += new System.EventHandler(this.btnHeartBeat_Click);
            // 
            // btnCng
            // 
            this.btnCng.Location = new System.Drawing.Point(647, 12);
            this.btnCng.Name = "btnCng";
            this.btnCng.Size = new System.Drawing.Size(130, 21);
            this.btnCng.TabIndex = 13;
            this.btnCng.Text = "Change";
            this.btnCng.UseVisualStyleBackColor = true;
            this.btnCng.Visible = false;
            // 
            // tbCngPort
            // 
            this.tbCngPort.Location = new System.Drawing.Point(542, 12);
            this.tbCngPort.MaxLength = 968;
            this.tbCngPort.Name = "tbCngPort";
            this.tbCngPort.Size = new System.Drawing.Size(99, 20);
            this.tbCngPort.TabIndex = 14;
            this.tbCngPort.TabStop = false;
            this.tbCngPort.Visible = false;
            // 
            // lbPortCng
            // 
            this.lbPortCng.AutoSize = true;
            this.lbPortCng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPortCng.Location = new System.Drawing.Point(524, 12);
            this.lbPortCng.Name = "lbPortCng";
            this.lbPortCng.Size = new System.Drawing.Size(12, 18);
            this.lbPortCng.TabIndex = 15;
            this.lbPortCng.Text = ":";
            this.lbPortCng.Visible = false;
            // 
            // tbCngIP
            // 
            this.tbCngIP.Location = new System.Drawing.Point(369, 13);
            this.tbCngIP.MaxLength = 968;
            this.tbCngIP.Name = "tbCngIP";
            this.tbCngIP.Size = new System.Drawing.Size(149, 20);
            this.tbCngIP.TabIndex = 16;
            this.tbCngIP.TabStop = false;
            this.tbCngIP.Visible = false;
            // 
            // lbRe
            // 
            this.lbRe.AutoSize = true;
            this.lbRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRe.Location = new System.Drawing.Point(334, 49);
            this.lbRe.Name = "lbRe";
            this.lbRe.Size = new System.Drawing.Size(102, 18);
            this.lbRe.TabIndex = 17;
            this.lbRe.Text = "Request from:";
            this.lbRe.Visible = false;
            // 
            // lbReName
            // 
            this.lbReName.AutoSize = true;
            this.lbReName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReName.Location = new System.Drawing.Point(334, 67);
            this.lbReName.Name = "lbReName";
            this.lbReName.Size = new System.Drawing.Size(84, 15);
            this.lbReName.TabIndex = 18;
            this.lbReName.Text = "Request from:";
            this.lbReName.Visible = false;
            // 
            // lbReIP
            // 
            this.lbReIP.AutoSize = true;
            this.lbReIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReIP.Location = new System.Drawing.Point(334, 82);
            this.lbReIP.Name = "lbReIP";
            this.lbReIP.Size = new System.Drawing.Size(84, 15);
            this.lbReIP.TabIndex = 19;
            this.lbReIP.Text = "Request from:";
            this.lbReIP.Visible = false;
            // 
            // btnReAc
            // 
            this.btnReAc.Enabled = false;
            this.btnReAc.Location = new System.Drawing.Point(269, 67);
            this.btnReAc.Name = "btnReAc";
            this.btnReAc.Size = new System.Drawing.Size(59, 33);
            this.btnReAc.TabIndex = 20;
            this.btnReAc.Text = "Yes";
            this.btnReAc.UseVisualStyleBackColor = true;
            this.btnReAc.Visible = false;
            this.btnReAc.Click += new System.EventHandler(this.btnReAc_Click);
            // 
            // btnReDe
            // 
            this.btnReDe.Enabled = false;
            this.btnReDe.Location = new System.Drawing.Point(424, 67);
            this.btnReDe.Name = "btnReDe";
            this.btnReDe.Size = new System.Drawing.Size(59, 33);
            this.btnReDe.TabIndex = 21;
            this.btnReDe.Text = "No";
            this.btnReDe.UseVisualStyleBackColor = true;
            this.btnReDe.Visible = false;
            this.btnReDe.Click += new System.EventHandler(this.btnReDe_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 520);
            this.Controls.Add(this.btnReDe);
            this.Controls.Add(this.btnReAc);
            this.Controls.Add(this.lbReIP);
            this.Controls.Add(this.lbReName);
            this.Controls.Add(this.lbRe);
            this.Controls.Add(this.tbCngIP);
            this.Controls.Add(this.lbPortCng);
            this.Controls.Add(this.tbCngPort);
            this.Controls.Add(this.btnCng);
            this.Controls.Add(this.btnHeartBeat);
            this.Controls.Add(this.btnEntr);
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
        private System.Windows.Forms.Button btnEntr;
        private System.Windows.Forms.Button btnHeartBeat;
        private System.Windows.Forms.Button btnCng;
        private System.Windows.Forms.TextBox tbCngPort;
        private System.Windows.Forms.Label lbPortCng;
        private System.Windows.Forms.TextBox tbCngIP;
        private System.Windows.Forms.Label lbRe;
        private System.Windows.Forms.Label lbReName;
        private System.Windows.Forms.Label lbReIP;
        private System.Windows.Forms.Button btnReAc;
        private System.Windows.Forms.Button btnReDe;
    }
}