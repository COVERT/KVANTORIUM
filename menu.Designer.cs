namespace KVANTORIUM
{
    partial class menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.USINIK = new System.Windows.Forms.Button();
            this.KURS = new System.Windows.Forms.Button();
            this.INFO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Преподаватель";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // USINIK
            // 
            this.USINIK.Location = new System.Drawing.Point(37, 162);
            this.USINIK.Name = "USINIK";
            this.USINIK.Size = new System.Drawing.Size(117, 23);
            this.USINIK.TabIndex = 1;
            this.USINIK.Text = "Ученик";
            this.USINIK.UseVisualStyleBackColor = true;
            this.USINIK.Click += new System.EventHandler(this.USINIK_Click);
            // 
            // KURS
            // 
            this.KURS.Location = new System.Drawing.Point(37, 208);
            this.KURS.Name = "KURS";
            this.KURS.Size = new System.Drawing.Size(117, 23);
            this.KURS.TabIndex = 2;
            this.KURS.Text = "Запись на курс";
            this.KURS.UseVisualStyleBackColor = true;
            this.KURS.Click += new System.EventHandler(this.KURS_Click);
            // 
            // INFO
            // 
            this.INFO.Location = new System.Drawing.Point(37, 253);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(117, 23);
            this.INFO.TabIndex = 3;
            this.INFO.Text = "Контакты";
            this.INFO.UseVisualStyleBackColor = true;
            this.INFO.Click += new System.EventHandler(this.INFO_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(205, 326);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.KURS);
            this.Controls.Add(this.USINIK);
            this.Controls.Add(this.button1);
            this.Name = "menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button USINIK;
        private System.Windows.Forms.Button KURS;
        private System.Windows.Forms.Button INFO;
    }
}

