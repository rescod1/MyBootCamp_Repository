
namespace Calculator
{
    partial class Form1
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
            this.Lblname1 = new System.Windows.Forms.Label();
            this.Lblname2 = new System.Windows.Forms.Label();
            this.Lblname3 = new System.Windows.Forms.Label();
            this.btnName1 = new System.Windows.Forms.Button();
            this.btnName2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblname1
            // 
            this.Lblname1.AutoSize = true;
            this.Lblname1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblname1.Location = new System.Drawing.Point(12, 22);
            this.Lblname1.Name = "Lblname1";
            this.Lblname1.Size = new System.Drawing.Size(119, 29);
            this.Lblname1.TabIndex = 0;
            this.Lblname1.Text = "Hello ♥";
            // 
            // Lblname2
            // 
            this.Lblname2.AutoSize = true;
            this.Lblname2.Font = new System.Drawing.Font("Source Sans Pro Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblname2.Location = new System.Drawing.Point(139, 55);
            this.Lblname2.Name = "Lblname2";
            this.Lblname2.Size = new System.Drawing.Size(27, 31);
            this.Lblname2.TabIndex = 1;
            this.Lblname2.Text = "0";
            // 
            // Lblname3
            // 
            this.Lblname3.AutoSize = true;
            this.Lblname3.Font = new System.Drawing.Font("Source Sans Pro Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblname3.Location = new System.Drawing.Point(360, 55);
            this.Lblname3.Name = "Lblname3";
            this.Lblname3.Size = new System.Drawing.Size(27, 31);
            this.Lblname3.TabIndex = 2;
            this.Lblname3.Text = "0";
            // 
            // btnName1
            // 
            this.btnName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnName1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName1.Location = new System.Drawing.Point(85, 113);
            this.btnName1.Name = "btnName1";
            this.btnName1.Size = new System.Drawing.Size(150, 80);
            this.btnName1.TabIndex = 3;
            this.btnName1.Text = "НАЖМИ!";
            this.btnName1.UseVisualStyleBackColor = false;
            this.btnName1.Click += new System.EventHandler(this.btnName1_Click);
            // 
            // btnName2
            // 
            this.btnName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnName2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName2.Location = new System.Drawing.Point(299, 113);
            this.btnName2.Name = "btnName2";
            this.btnName2.Size = new System.Drawing.Size(150, 80);
            this.btnName2.TabIndex = 4;
            this.btnName2.Text = "Клик";
            this.btnName2.UseVisualStyleBackColor = false;
            this.btnName2.Click += new System.EventHandler(this.btnName2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(514, 211);
            this.Controls.Add(this.btnName2);
            this.Controls.Add(this.btnName1);
            this.Controls.Add(this.Lblname3);
            this.Controls.Add(this.Lblname2);
            this.Controls.Add(this.Lblname1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МОЯ ПЕРВАЯ ПРОГРАММА";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblname1;
        private System.Windows.Forms.Label Lblname2;
        private System.Windows.Forms.Label Lblname3;
        private System.Windows.Forms.Button btnName1;
        private System.Windows.Forms.Button btnName2;
    }
}

