
namespace Sandruve
{
    partial class HostForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.listeningsCountLabel = new System.Windows.Forms.Label();
            this.listeningsDisplayedList = new System.Windows.Forms.ListBox();
            this.kickUserBtn = new System.Windows.Forms.Button();
            this.banUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хост:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.startBtn.Location = new System.Drawing.Point(12, 44);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 22);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Запустить";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // HostBox
            // 
            this.HostBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.HostBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HostBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.HostBox.Location = new System.Drawing.Point(12, 25);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(100, 13);
            this.HostBox.TabIndex = 2;
            this.HostBox.Text = "127.0.0.1:8910";
            this.HostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputTxt
            // 
            this.outputTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.outputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.outputTxt.Location = new System.Drawing.Point(12, 74);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(635, 364);
            this.outputTxt.TabIndex = 2;
            // 
            // listeningsCountLabel
            // 
            this.listeningsCountLabel.AutoSize = true;
            this.listeningsCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.listeningsCountLabel.Location = new System.Drawing.Point(706, 9);
            this.listeningsCountLabel.Name = "listeningsCountLabel";
            this.listeningsCountLabel.Size = new System.Drawing.Size(82, 13);
            this.listeningsCountLabel.TabIndex = 3;
            this.listeningsCountLabel.Text = "Подключено: 0";
            this.listeningsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listeningsCountLabel.Visible = false;
            // 
            // listeningsDisplayedList
            // 
            this.listeningsDisplayedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.listeningsDisplayedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listeningsDisplayedList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.listeningsDisplayedList.FormattingEnabled = true;
            this.listeningsDisplayedList.Location = new System.Drawing.Point(653, 74);
            this.listeningsDisplayedList.Name = "listeningsDisplayedList";
            this.listeningsDisplayedList.Size = new System.Drawing.Size(135, 364);
            this.listeningsDisplayedList.TabIndex = 4;
            // 
            // kickUserBtn
            // 
            this.kickUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kickUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.kickUserBtn.Location = new System.Drawing.Point(653, 45);
            this.kickUserBtn.Name = "kickUserBtn";
            this.kickUserBtn.Size = new System.Drawing.Size(59, 23);
            this.kickUserBtn.TabIndex = 1;
            this.kickUserBtn.Text = "Кик";
            this.kickUserBtn.UseVisualStyleBackColor = true;
            this.kickUserBtn.Click += new System.EventHandler(this.kickUserBtn_Click);
            // 
            // banUserBtn
            // 
            this.banUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.banUserBtn.Location = new System.Drawing.Point(729, 45);
            this.banUserBtn.Name = "banUserBtn";
            this.banUserBtn.Size = new System.Drawing.Size(59, 23);
            this.banUserBtn.TabIndex = 5;
            this.banUserBtn.Text = "Бан";
            this.banUserBtn.UseVisualStyleBackColor = true;
            this.banUserBtn.Click += new System.EventHandler(this.banUserBtn_Click);
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.banUserBtn);
            this.Controls.Add(this.listeningsDisplayedList);
            this.Controls.Add(this.listeningsCountLabel);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.HostBox);
            this.Controls.Add(this.kickUserBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Name = "HostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandruve - Сервер";
            this.Load += new System.EventHandler(this.HostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.Label listeningsCountLabel;
        private System.Windows.Forms.ListBox listeningsDisplayedList;
        private System.Windows.Forms.Button kickUserBtn;
        private System.Windows.Forms.Button banUserBtn;
    }
}