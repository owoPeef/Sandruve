
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хост:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(419, 33);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Запустить";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // HostBox
            // 
            this.HostBox.Location = new System.Drawing.Point(313, 35);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(100, 20);
            this.HostBox.TabIndex = 2;
            this.HostBox.Text = "127.0.0.1:8910";
            this.HostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(12, 61);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(635, 381);
            this.outputTxt.TabIndex = 2;
            // 
            // listeningsCountLabel
            // 
            this.listeningsCountLabel.Location = new System.Drawing.Point(653, 9);
            this.listeningsCountLabel.Name = "listeningsCountLabel";
            this.listeningsCountLabel.Size = new System.Drawing.Size(135, 15);
            this.listeningsCountLabel.TabIndex = 3;
            this.listeningsCountLabel.Text = "Подключено: 0";
            this.listeningsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listeningsCountLabel.Visible = false;
            // 
            // listeningsDisplayedList
            // 
            this.listeningsDisplayedList.FormattingEnabled = true;
            this.listeningsDisplayedList.Location = new System.Drawing.Point(656, 61);
            this.listeningsDisplayedList.Name = "listeningsDisplayedList";
            this.listeningsDisplayedList.Size = new System.Drawing.Size(132, 381);
            this.listeningsDisplayedList.TabIndex = 4;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeningsDisplayedList);
            this.Controls.Add(this.listeningsCountLabel);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.HostBox);
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
    }
}