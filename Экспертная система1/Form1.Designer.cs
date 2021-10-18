
namespace Экспертная_система1
{
    partial class Knowledge
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
            this.btnReStart = new System.Windows.Forms.Button();
            this.tboxQuest = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnReStart
            // 
            this.btnReStart.Location = new System.Drawing.Point(1060, 902);
            this.btnReStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReStart.Name = "btnReStart";
            this.btnReStart.Size = new System.Drawing.Size(249, 35);
            this.btnReStart.TabIndex = 3;
            this.btnReStart.Text = "Начать заново";
            this.btnReStart.UseVisualStyleBackColor = true;
            this.btnReStart.Click += new System.EventHandler(this.btnReStart_Click);
            // 
            // tboxQuest
            // 
            this.tboxQuest.BackColor = System.Drawing.Color.White;
            this.tboxQuest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxQuest.Location = new System.Drawing.Point(13, 14);
            this.tboxQuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxQuest.Name = "tboxQuest";
            this.tboxQuest.ReadOnly = true;
            this.tboxQuest.Size = new System.Drawing.Size(1261, 372);
            this.tboxQuest.TabIndex = 1;
            this.tboxQuest.Text = "Вопрос";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(20, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 361);
            this.panel1.TabIndex = 4;
            // 
            // Knowledge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 955);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tboxQuest);
            this.Controls.Add(this.btnReStart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Knowledge";
            this.Text = "Knowledge";
            this.Load += new System.EventHandler(this.Knowledge_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReStart;
        private System.Windows.Forms.RichTextBox tboxQuest;
        private System.Windows.Forms.Panel panel1;
    }
}

