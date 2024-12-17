using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BasicControls;

namespace MainForms
{
    partial class frmDbSetup : frm
    {
        private IContainer components = null;
        private lbl lblDbType, lblSqlInstances, lblUsername, lblPassword, lblSQLitePath, lblAuthType;
        private btn btnTest, btnBrowse;
        private txtBox txtUsername, txtPassword, txtSQLitePath;
        private rdoBtn rbWindowsAuth, rbSqlAuth;
        private cmbBox cmbSqlInstances;
        private pnl pnlSQLExpress, pnlAuthType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDbType = new BasicControls.lbl();
            this.lblSqlInstances = new BasicControls.lbl();
            this.lblUsername = new BasicControls.lbl();
            this.lblPassword = new BasicControls.lbl();
            this.lblSQLitePath = new BasicControls.lbl();
            this.lblAuthType = new BasicControls.lbl();
            this.rbWindowsAuth = new BasicControls.rdoBtn(this.components);
            this.rbSqlAuth = new BasicControls.rdoBtn(this.components);
            this.txtUsername = new BasicControls.txtBox();
            this.txtPassword = new BasicControls.txtBox();
            this.txtSQLitePath = new BasicControls.txtBox();
            this.cmbDbType = new BasicControls.cmbBox(this.components);
            this.cmbSqlInstances = new BasicControls.cmbBox(this.components);
            this.btnTest = new BasicControls.btn();
            this.btnBrowse = new BasicControls.btn();
            this.pnlSQLExpress = new BasicControls.pnl(this.components);
            this.pnlAuthType = new BasicControls.pnl(this.components);
            this.pnlSQLExpress.SuspendLayout();
            this.pnlAuthType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDbType
            // 
            this.lblDbType.Location = new System.Drawing.Point(20, 20);
            this.lblDbType.Name = "lblDbType";
            this.lblDbType.Size = new System.Drawing.Size(150, 25);
            this.lblDbType.TabIndex = 0;
            this.lblDbType.Text = "Database Type:";
            // 
            // lblSqlInstances
            // 
            this.lblSqlInstances.Location = new System.Drawing.Point(20, 20);
            this.lblSqlInstances.Name = "lblSqlInstances";
            this.lblSqlInstances.Size = new System.Drawing.Size(150, 25);
            this.lblSqlInstances.TabIndex = 0;
            this.lblSqlInstances.Text = "SQL Instances:";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(20, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(150, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(20, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(150, 25);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblSQLitePath
            // 
            this.lblSQLitePath.Location = new System.Drawing.Point(20, 80);
            this.lblSQLitePath.Name = "lblSQLitePath";
            this.lblSQLitePath.Size = new System.Drawing.Size(150, 25);
            this.lblSQLitePath.TabIndex = 3;
            this.lblSQLitePath.Text = "SQLite Database Path:";
            // 
            // lblAuthType
            // 
            this.lblAuthType.Location = new System.Drawing.Point(20, 60);
            this.lblAuthType.Name = "lblAuthType";
            this.lblAuthType.Size = new System.Drawing.Size(150, 25);
            this.lblAuthType.TabIndex = 2;
            this.lblAuthType.Text = "Authentication Type:";
            // 
            // rbWindowsAuth
            // 
            this.rbWindowsAuth.Location = new System.Drawing.Point(0, 0);
            this.rbWindowsAuth.Name = "rbWindowsAuth";
            this.rbWindowsAuth.Size = new System.Drawing.Size(150, 25);
            this.rbWindowsAuth.TabIndex = 0;
            this.rbWindowsAuth.Text = "Windows Authentication";
            this.rbWindowsAuth.CheckedChanged += new System.EventHandler(this.rbWindowsAuth_CheckedChanged);
            // 
            // rbSqlAuth
            // 
            this.rbSqlAuth.Location = new System.Drawing.Point(160, 0);
            this.rbSqlAuth.Name = "rbSqlAuth";
            this.rbSqlAuth.Size = new System.Drawing.Size(140, 25);
            this.rbSqlAuth.TabIndex = 1;
            this.rbSqlAuth.Text = "SQL Authentication";
            this.rbSqlAuth.CheckedChanged += new System.EventHandler(this.rbSqlAuth_CheckedChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(200, 100);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtSQLitePath
            // 
            this.txtSQLitePath.Location = new System.Drawing.Point(200, 80);
            this.txtSQLitePath.Name = "txtSQLitePath";
            this.txtSQLitePath.Size = new System.Drawing.Size(300, 20);
            this.txtSQLitePath.TabIndex = 4;
            // 
            // cmbDbType
            // 
            this.cmbDbType.Items.AddRange(new object[] {
            "SQLite",
            "SQL Express"});
            this.cmbDbType.Location = new System.Drawing.Point(200, 20);
            this.cmbDbType.Name = "cmbDbType";
            this.cmbDbType.Size = new System.Drawing.Size(300, 21);
            this.cmbDbType.TabIndex = 1;
            this.cmbDbType.SelectedIndexChanged += new System.EventHandler(this.cmbDbType_SelectedIndexChanged);
            // 
            // cmbSqlInstances
            // 
            this.cmbSqlInstances.Location = new System.Drawing.Point(200, 20);
            this.cmbSqlInstances.Name = "cmbSqlInstances";
            this.cmbSqlInstances.Size = new System.Drawing.Size(300, 21);
            this.cmbSqlInstances.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(520, 342);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 25);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test Connection";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(510, 80);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 25);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pnlSQLExpress
            // 
            this.pnlSQLExpress.Controls.Add(this.lblSqlInstances);
            this.pnlSQLExpress.Controls.Add(this.cmbSqlInstances);
            this.pnlSQLExpress.Controls.Add(this.lblAuthType);
            this.pnlSQLExpress.Controls.Add(this.pnlAuthType);
            this.pnlSQLExpress.Controls.Add(this.lblUsername);
            this.pnlSQLExpress.Controls.Add(this.txtUsername);
            this.pnlSQLExpress.Controls.Add(this.lblPassword);
            this.pnlSQLExpress.Controls.Add(this.txtPassword);
            this.pnlSQLExpress.Location = new System.Drawing.Point(20, 150);
            this.pnlSQLExpress.Name = "pnlSQLExpress";
            this.pnlSQLExpress.Size = new System.Drawing.Size(600, 176);
            this.pnlSQLExpress.TabIndex = 6;
            // 
            // pnlAuthType
            // 
            this.pnlAuthType.Controls.Add(this.rbWindowsAuth);
            this.pnlAuthType.Controls.Add(this.rbSqlAuth);
            this.pnlAuthType.Location = new System.Drawing.Point(200, 57);
            this.pnlAuthType.Name = "pnlAuthType";
            this.pnlAuthType.Size = new System.Drawing.Size(300, 40);
            this.pnlAuthType.TabIndex = 3;
            // 
            // frmDbSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 382);
            this.Controls.Add(this.lblDbType);
            this.Controls.Add(this.cmbDbType);
            this.Controls.Add(this.lblSQLitePath);
            this.Controls.Add(this.txtSQLitePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pnlSQLExpress);
            this.Controls.Add(this.btnTest);
            this.Name = "frmDbSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Configuration Wizard";
            this.pnlSQLExpress.ResumeLayout(false);
            this.pnlSQLExpress.PerformLayout();
            this.pnlAuthType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private cmbBox cmbDbType;
    }
}