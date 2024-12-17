namespace MainForms
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            this.txtBox1 = new BasicControls.txtBox();
            this.txtBox2 = new BasicControls.txtBox();
            this.Lite = new BasicControls.rdoBtn(this.components);
            this.Express = new BasicControls.rdoBtn(this.components);
            this.btn1 = new BasicControls.btn();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.Location = new System.Drawing.Point(12, 72);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(1475, 26);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.Text = "CREATE TABLE IF NOT EXISTS Users ( UserId _S_ PRIMARY KEY, Username _V_ UNIQUE, P" +
    "assword _V_[30], IsAdmin _B_ , NUMWPS _N_[20?2], NUM _N_, MYDATE _D_, MYDT _T_);" +
    "";
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(12, 221);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(1458, 26);
            this.txtBox2.TabIndex = 1;
            // 
            // Lite
            // 
            this.Lite.AutoSize = true;
            this.Lite.Location = new System.Drawing.Point(372, 312);
            this.Lite.Name = "Lite";
            this.Lite.Size = new System.Drawing.Size(42, 17);
            this.Lite.TabIndex = 2;
            this.Lite.TabStop = true;
            this.Lite.Text = "Lite";
            this.Lite.UseVisualStyleBackColor = true;
            this.Lite.CheckedChanged += new System.EventHandler(this.rdoBtn1_CheckedChanged);
            // 
            // Express
            // 
            this.Express.AutoSize = true;
            this.Express.Location = new System.Drawing.Point(548, 312);
            this.Express.Name = "Express";
            this.Express.Size = new System.Drawing.Size(62, 17);
            this.Express.TabIndex = 3;
            this.Express.TabStop = true;
            this.Express.Text = "Express";
            this.Express.UseVisualStyleBackColor = true;
            this.Express.CheckedChanged += new System.EventHandler(this.rdoBtn2_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(439, 373);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(92, 35);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "btn1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Express);
            this.Controls.Add(this.Lite);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.txtBox txtBox1;
        private BasicControls.txtBox txtBox2;
        private BasicControls.rdoBtn Lite;
        private BasicControls.rdoBtn Express;
        private BasicControls.btn btn1;
    }
}