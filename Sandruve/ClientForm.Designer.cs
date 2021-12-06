
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
            this.label2 = new System.Windows.Forms.Label();
            this.SelectVideoToSendBtn = new System.Windows.Forms.Button();
            this.VideoUploadingProgress = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.VideoUploadingProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTxt
            // 
            this.outputTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.outputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTxt.Enabled = false;
            this.outputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.outputTxt.Location = new System.Drawing.Point(12, 145);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTxt.Size = new System.Drawing.Size(776, 310);
            this.outputTxt.TabIndex = 5;
            // 
            // HostBox
            // 
            this.HostBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.HostBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HostBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.HostBox.Location = new System.Drawing.Point(12, 62);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(100, 15);
            this.HostBox.TabIndex = 6;
            this.HostBox.Text = "127.0.0.1:8910";
            this.HostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connectBtn
            // 
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.connectBtn.Location = new System.Drawing.Point(121, 9);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(115, 29);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Подключиться";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Хост:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sendMsgBox
            // 
            this.sendMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.sendMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendMsgBox.Enabled = false;
            this.sendMsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMsgBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.sendMsgBox.Location = new System.Drawing.Point(11, 82);
            this.sendMsgBox.Name = "sendMsgBox";
            this.sendMsgBox.Size = new System.Drawing.Size(776, 22);
            this.sendMsgBox.TabIndex = 7;
            // 
            // sendBtn
            // 
            this.sendBtn.Enabled = false;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.sendBtn.Location = new System.Drawing.Point(690, 108);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(98, 31);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Отправить";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // NickBox
            // 
            this.NickBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.NickBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NickBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NickBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.NickBox.Location = new System.Drawing.Point(12, 25);
            this.NickBox.Name = "NickBox";
            this.NickBox.Size = new System.Drawing.Size(100, 15);
            this.NickBox.TabIndex = 6;
            this.NickBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectImageToSendBtn
            // 
            this.SelectImageToSendBtn.Enabled = false;
            this.SelectImageToSendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectImageToSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectImageToSendBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.SelectImageToSendBtn.Location = new System.Drawing.Point(571, 108);
            this.SelectImageToSendBtn.Name = "SelectImageToSendBtn";
            this.SelectImageToSendBtn.Size = new System.Drawing.Size(113, 31);
            this.SelectImageToSendBtn.TabIndex = 4;
            this.SelectImageToSendBtn.Text = "Изображение";
            this.SelectImageToSendBtn.UseVisualStyleBackColor = true;
            this.SelectImageToSendBtn.Click += new System.EventHandler(this.SelectImageToSendBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disconnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.disconnectBtn.Location = new System.Drawing.Point(121, 46);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(115, 29);
            this.disconnectBtn.TabIndex = 4;
            this.disconnectBtn.Text = "Отключиться";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ник:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectVideoToSendBtn
            // 
            this.SelectVideoToSendBtn.Enabled = false;
            this.SelectVideoToSendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectVideoToSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectVideoToSendBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.SelectVideoToSendBtn.Location = new System.Drawing.Point(452, 108);
            this.SelectVideoToSendBtn.Name = "SelectVideoToSendBtn";
            this.SelectVideoToSendBtn.Size = new System.Drawing.Size(113, 31);
            this.SelectVideoToSendBtn.TabIndex = 4;
            this.SelectVideoToSendBtn.Text = "Видео";
            this.SelectVideoToSendBtn.UseVisualStyleBackColor = true;
            this.SelectVideoToSendBtn.Click += new System.EventHandler(this.SelectVideoToSendBtn_Click);
            // 
            // VideoUploadingProgress
            // 
            this.VideoUploadingProgress.LargeChange = 1;
            this.VideoUploadingProgress.Location = new System.Drawing.Point(242, 31);
            this.VideoUploadingProgress.Maximum = 100;
            this.VideoUploadingProgress.Name = "VideoUploadingProgress";
            this.VideoUploadingProgress.Size = new System.Drawing.Size(545, 45);
            this.VideoUploadingProgress.TabIndex = 8;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.VideoUploadingProgress);
            this.Controls.Add(this.sendMsgBox);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.NickBox);
            this.Controls.Add(this.HostBox);
            this.Controls.Add(this.SelectVideoToSendBtn);
            this.Controls.Add(this.SelectImageToSendBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandruve - Клиент";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideoUploadingProgress)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectVideoToSendBtn;
        private System.Windows.Forms.TrackBar VideoUploadingProgress;
    }
}