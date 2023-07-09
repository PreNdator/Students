namespace Students
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
            this.filename = new System.Windows.Forms.TextBox();
            this.open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grade1 = new System.Windows.Forms.TextBox();
            this.grade2 = new System.Windows.Forms.TextBox();
            this.grade3 = new System.Windows.Forms.TextBox();
            this.grade4 = new System.Windows.Forms.TextBox();
            this.grade5 = new System.Windows.Forms.TextBox();
            this.studentsFile = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(12, 25);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(156, 20);
            this.filename.TabIndex = 1;
            this.filename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(174, 23);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(71, 23);
            this.open.TabIndex = 3;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя файла";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(12, 84);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(156, 20);
            this.first_name.TabIndex = 5;
            this.first_name.Visible = false;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(12, 110);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(156, 20);
            this.last_name.TabIndex = 6;
            this.last_name.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Информация о студенте";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фамилия";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Оценки";
            this.label5.Visible = false;
            // 
            // grade1
            // 
            this.grade1.AllowDrop = true;
            this.grade1.Location = new System.Drawing.Point(34, 136);
            this.grade1.MaxLength = 1;
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(22, 20);
            this.grade1.TabIndex = 11;
            this.grade1.Visible = false;
            this.grade1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyGrades);
            // 
            // grade2
            // 
            this.grade2.AllowDrop = true;
            this.grade2.Location = new System.Drawing.Point(62, 136);
            this.grade2.MaxLength = 1;
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(22, 20);
            this.grade2.TabIndex = 12;
            this.grade2.Visible = false;
            this.grade2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyGrades);
            // 
            // grade3
            // 
            this.grade3.AllowDrop = true;
            this.grade3.Location = new System.Drawing.Point(90, 136);
            this.grade3.MaxLength = 1;
            this.grade3.Name = "grade3";
            this.grade3.Size = new System.Drawing.Size(22, 20);
            this.grade3.TabIndex = 13;
            this.grade3.Visible = false;
            this.grade3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyGrades);
            // 
            // grade4
            // 
            this.grade4.AllowDrop = true;
            this.grade4.Location = new System.Drawing.Point(118, 136);
            this.grade4.MaxLength = 1;
            this.grade4.Name = "grade4";
            this.grade4.Size = new System.Drawing.Size(22, 20);
            this.grade4.TabIndex = 14;
            this.grade4.Visible = false;
            this.grade4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyGrades);
            // 
            // grade5
            // 
            this.grade5.AllowDrop = true;
            this.grade5.Location = new System.Drawing.Point(146, 136);
            this.grade5.MaxLength = 1;
            this.grade5.Name = "grade5";
            this.grade5.Size = new System.Drawing.Size(22, 20);
            this.grade5.TabIndex = 15;
            this.grade5.Visible = false;
            this.grade5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_OnlyGrades);
            // 
            // studentsFile
            // 
            this.studentsFile.Location = new System.Drawing.Point(251, 12);
            this.studentsFile.Multiline = true;
            this.studentsFile.Name = "studentsFile";
            this.studentsFile.ReadOnly = true;
            this.studentsFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.studentsFile.Size = new System.Drawing.Size(517, 533);
            this.studentsFile.TabIndex = 16;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 522);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(98, 23);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Закрыть файл";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 179);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.studentsFile);
            this.Controls.Add(this.grade5);
            this.Controls.Add(this.grade4);
            this.Controls.Add(this.grade3);
            this.Controls.Add(this.grade2);
            this.Controls.Add(this.grade1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.filename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Ы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox grade1;
        private System.Windows.Forms.TextBox grade2;
        private System.Windows.Forms.TextBox grade3;
        private System.Windows.Forms.TextBox grade4;
        private System.Windows.Forms.TextBox grade5;
        private System.Windows.Forms.TextBox studentsFile;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addButton;
    }
}

