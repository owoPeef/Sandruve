
namespace Sandruve
{
    partial class ClientForm
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
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sendMsgBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.NickBox = new System.Windows.Forms.TextBox();
            this.SelectImageToSendBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTxt
            // 
            this.outputTxt.Enabled = false;
            this.outputTxt.Location = new System.Drawing.Point(12, 120);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(776, 318);
            this.outputTxt.TabIndex = 5;
            // 
            // HostBox
            // 
            this.HostBox.Location = new System.Drawing.Point(313, 37);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(100, 20);
            this.HostBox.TabIndex = 6;
            this.HostBox.Text = "127.0.0.1:8910";
            this.HostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(419, 37);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(97, 20);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Подключиться";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(345, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Хост:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sendMsgBox
            // 
            this.sendMsgBox.Enabled = false;
            this.sendMsgBox.Location = new System.Drawing.Point(12, 64);
            this.sendMsgBox.Multiline = true;
            this.sendMsgBox.Name = "sendMsgBox";
            this.sendMsgBox.Size = new System.Drawing.Size(776, 21);
            this.sendMsgBox.TabIndex = 7;
            // 
            // sendBtn
            // 
            this.sendBtn.Enabled = false;
            this.sendBtn.Location = new System.Drawing.Point(713, 91);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Отправить";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // NickBox
            // 
            this.NickBox.Location = new System.Drawing.Point(207, 37);
            this.NickBox.Name = "NickBox";
            this.NickBox.Size = new System.Drawing.Size(100, 20);
            this.NickBox.TabIndex = 6;
            this.NickBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectImageToSendBtn
            // 
            this.SelectImageToSendBtn.Enabled = false;
            this.SelectImageToSendBtn.Location = new System.Drawing.Point(621, 91);
            this.SelectImageToSendBtn.Name = "SelectImageToSendBtn";
            this.SelectImageToSendBtn.Size = new System.Drawing.Size(86, 23);
            this.SelectImageToSendBtn.TabIndex = 4;
            this.SelectImageToSendBtn.Text = "Изображение";
            this.SelectImageToSendBtn.UseVisualStyleBackColor = true;
            this.SelectImageToSendBtn.Click += new System.EventHandler(this.SelectImageToSendBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.Location = new System.Drawing.Point(522, 37);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(87, 20);
            this.disconnectBtn.TabIndex = 4;
            this.disconnectBtn.Text = "Отключиться";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendMsgBox);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.NickBox);
            this.Controls.Add(this.HostBox);
            this.Controls.Add(this.SelectImageToSendBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandruve - Клиент";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sendMsgBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox NickBox;
        private System.Windows.Forms.Button SelectImageToSendBtn;
        private System.Windows.Forms.Button disconnectBtn;
    }
}