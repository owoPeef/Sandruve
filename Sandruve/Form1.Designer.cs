
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
            // Sandruve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 43);
            this.Controls.Add(this.conBtn);
            this.Controls.Add(this.hostBtn);
            this.MaximizeBox = false;
            this.Name = "Sandruve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sandruve";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hostBtn;
        private System.Windows.Forms.Button conBtn;
    }
}

