﻿namespace Gudang_PAS_APP
{
    partial class FormGudang
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TambahBarang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-7, -3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(845, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.TambahBarang);
            this.panel1.Location = new System.Drawing.Point(-7, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 409);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Lihat Barang";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lihat Barang";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TambahBarang
            // 
            this.TambahBarang.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TambahBarang.Location = new System.Drawing.Point(28, 39);
            this.TambahBarang.Name = "TambahBarang";
            this.TambahBarang.Size = new System.Drawing.Size(134, 33);
            this.TambahBarang.TabIndex = 2;
            this.TambahBarang.Text = "Tambah Barang";
            this.TambahBarang.UseVisualStyleBackColor = true;
            this.TambahBarang.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormGudang";
            this.Text = "FormData";
            this.Load += new System.EventHandler(this.FormGudang_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TambahBarang;
    }
}