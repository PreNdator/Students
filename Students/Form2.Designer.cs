namespace Students
{
    partial class Form2
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
            this.bestStudents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TreeButton = new System.Windows.Forms.Button();
            this.AVLTreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bestStudents
            // 
            this.bestStudents.Location = new System.Drawing.Point(125, 455);
            this.bestStudents.Multiline = true;
            this.bestStudents.Name = "bestStudents";
            this.bestStudents.ReadOnly = true;
            this.bestStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bestStudents.Size = new System.Drawing.Size(650, 100);
            this.bestStudents.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лучшие студенты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Список1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Список2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TreeButton
            // 
            this.TreeButton.Location = new System.Drawing.Point(12, 71);
            this.TreeButton.Name = "TreeButton";
            this.TreeButton.Size = new System.Drawing.Size(106, 23);
            this.TreeButton.TabIndex = 5;
            this.TreeButton.Text = "Дерево";
            this.TreeButton.UseVisualStyleBackColor = true;
            this.TreeButton.Click += new System.EventHandler(this.TreeButton_Click);
            // 
            // AVLTreeButton
            // 
            this.AVLTreeButton.Location = new System.Drawing.Point(13, 100);
            this.AVLTreeButton.Name = "AVLTreeButton";
            this.AVLTreeButton.Size = new System.Drawing.Size(106, 23);
            this.AVLTreeButton.TabIndex = 6;
            this.AVLTreeButton.Text = "AVL-Дерево";
            this.AVLTreeButton.UseVisualStyleBackColor = true;
            this.AVLTreeButton.Click += new System.EventHandler(this.AVLTreeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AVLTreeButton);
            this.Controls.Add(this.TreeButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bestStudents);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bestStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TreeButton;
        private System.Windows.Forms.Button AVLTreeButton;
    }
}