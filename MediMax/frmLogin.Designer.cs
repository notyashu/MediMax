﻿namespace MediMax
{
    partial class frmLogin
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
            this.lbl2 = new BasicControls.lbl();
            this.lbl1 = new BasicControls.lbl();
            this.txtBox1 = new BasicControls.txtBox();
            this.txtBox2 = new BasicControls.txtBox();
            this.btn1 = new BasicControls.btn();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(64, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Password";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 63);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "User Name";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.Color.White;
            this.txtBox1.Location = new System.Drawing.Point(162, 63);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(289, 20);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(162, 106);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(289, 20);
            this.txtBox2.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(376, 167);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Login";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 237);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.txtBox txtBox1;
        private BasicControls.lbl lbl1;
        private BasicControls.lbl lbl2;
        private BasicControls.txtBox txtBox2;
        private BasicControls.btn btn1;
    }
}