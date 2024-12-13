namespace MainForms
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
            this.loginBtn = new BasicControls.btn();
            this.lbl1 = new BasicControls.lbl();
            this.lbl2 = new BasicControls.lbl();
            this.txtUsername = new BasicControls.txtBox();
            this.txtPassword = new BasicControls.txtBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(376, 167);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 63);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "User Name";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(64, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(162, 63);
            this.txtUsername.Name = "txtBox1";
            this.txtUsername.Size = new System.Drawing.Size(289, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 106);
            this.txtPassword.Name = "txtBox2";
            this.txtPassword.Size = new System.Drawing.Size(289, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 237);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.lbl lbl1;
        private BasicControls.lbl lbl2;
        private BasicControls.txtBox txtPassword;
        private BasicControls.txtBox txtUsername;
        private BasicControls.btn loginBtn;
    }
}