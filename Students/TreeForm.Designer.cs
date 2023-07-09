namespace Students
{
    partial class TreeForm
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
            this.rootText = new System.Windows.Forms.TextBox();
            this.layer2Text1 = new System.Windows.Forms.TextBox();
            this.layer2Text2 = new System.Windows.Forms.TextBox();
            this.layer3Text1 = new System.Windows.Forms.TextBox();
            this.layer3Text4 = new System.Windows.Forms.TextBox();
            this.layer3Text3 = new System.Windows.Forms.TextBox();
            this.layer3Text2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rootText
            // 
            this.rootText.Location = new System.Drawing.Point(246, 12);
            this.rootText.Name = "rootText";
            this.rootText.ReadOnly = true;
            this.rootText.Size = new System.Drawing.Size(158, 20);
            this.rootText.TabIndex = 0;
            // 
            // layer2Text1
            // 
            this.layer2Text1.Location = new System.Drawing.Point(82, 129);
            this.layer2Text1.Name = "layer2Text1";
            this.layer2Text1.ReadOnly = true;
            this.layer2Text1.Size = new System.Drawing.Size(158, 20);
            this.layer2Text1.TabIndex = 1;
            // 
            // layer2Text2
            // 
            this.layer2Text2.Location = new System.Drawing.Point(408, 129);
            this.layer2Text2.Name = "layer2Text2";
            this.layer2Text2.ReadOnly = true;
            this.layer2Text2.Size = new System.Drawing.Size(158, 20);
            this.layer2Text2.TabIndex = 2;
            // 
            // layer3Text1
            // 
            this.layer3Text1.Location = new System.Drawing.Point(4, 267);
            this.layer3Text1.Name = "layer3Text1";
            this.layer3Text1.ReadOnly = true;
            this.layer3Text1.Size = new System.Drawing.Size(158, 20);
            this.layer3Text1.TabIndex = 3;
            // 
            // layer3Text4
            // 
            this.layer3Text4.Location = new System.Drawing.Point(490, 267);
            this.layer3Text4.Name = "layer3Text4";
            this.layer3Text4.ReadOnly = true;
            this.layer3Text4.Size = new System.Drawing.Size(158, 20);
            this.layer3Text4.TabIndex = 4;
            // 
            // layer3Text3
            // 
            this.layer3Text3.Location = new System.Drawing.Point(328, 267);
            this.layer3Text3.Name = "layer3Text3";
            this.layer3Text3.ReadOnly = true;
            this.layer3Text3.Size = new System.Drawing.Size(158, 20);
            this.layer3Text3.TabIndex = 5;
            // 
            // layer3Text2
            // 
            this.layer3Text2.Location = new System.Drawing.Point(166, 267);
            this.layer3Text2.Name = "layer3Text2";
            this.layer3Text2.ReadOnly = true;
            this.layer3Text2.Size = new System.Drawing.Size(158, 20);
            this.layer3Text2.TabIndex = 6;
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(650, 425);
            this.Controls.Add(this.layer3Text2);
            this.Controls.Add(this.layer3Text3);
            this.Controls.Add(this.layer3Text4);
            this.Controls.Add(this.layer3Text1);
            this.Controls.Add(this.layer2Text2);
            this.Controls.Add(this.layer2Text1);
            this.Controls.Add(this.rootText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(125, 10);
            this.Name = "TreeForm";
            this.Text = "TreeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rootText;
        private System.Windows.Forms.TextBox layer2Text1;
        private System.Windows.Forms.TextBox layer2Text2;
        private System.Windows.Forms.TextBox layer3Text1;
        private System.Windows.Forms.TextBox layer3Text4;
        private System.Windows.Forms.TextBox layer3Text3;
        private System.Windows.Forms.TextBox layer3Text2;
    }
}