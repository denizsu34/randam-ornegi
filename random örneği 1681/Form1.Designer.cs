﻿namespace random_örneği_1681
{
    partial class btnUret
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNotlar
            // 
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.Location = new System.Drawing.Point(150, 44);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(124, 199);
            this.lbNotlar.TabIndex = 2;
            // 
            // btnUret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 308);
            this.Controls.Add(this.lbNotlar);
            this.Controls.Add(this.button1);
            this.Name = "btnUret";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbNotlar;
    }
}

