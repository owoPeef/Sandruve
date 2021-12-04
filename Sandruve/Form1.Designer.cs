
namespace Sandruve
{
    partial class Sandruve
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.hostBtn = new System.Windows.Forms.Button();
            this.conBtn = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // hostBtn
            // 
            this.hostBtn.Location = new System.Drawing.Point(10, 12);
            this.hostBtn.Name = "hostBtn";
            this.hostBtn.Size = new System.Drawing.Size(91, 23);
            this.hostBtn.TabIndex = 0;
            this.hostBtn.Text = "Создать";
            this.hostBtn.UseVisualStyleBackColor = true;
            this.hostBtn.Click += new System.EventHandler(this.hostBtn_Click);
            // 
            // conBtn
            // 
            this.conBtn.Location = new System.Drawing.Point(107, 12);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(91, 23);
            this.conBtn.TabIndex = 0;
            this.conBtn.Text = "Подключиться";
            this.conBtn.UseVisualStyleBackColor = true;
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(7, 38);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(131, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Доступна новая версия!";
            this.VersionLabel.Visible = false;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(144, 38);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(48, 13);
            this.LinkLabel.TabIndex = 2;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Скачать";
            this.LinkLabel.Visible = false;
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // Sandruve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 60);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.conBtn);
            this.Controls.Add(this.hostBtn);
            this.MaximizeBox = false;
            this.Name = "Sandruve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandruve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hostBtn;
        private System.Windows.Forms.Button conBtn;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.LinkLabel LinkLabel;
    }
}

