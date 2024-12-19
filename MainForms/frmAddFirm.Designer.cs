namespace MainForms
{
    partial class frmAddFirm
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
            this.lblFirmType = new BasicControls.lbl();
            this.lblFirmName = new BasicControls.lbl();
            this.lblContactPerson = new BasicControls.lbl();
            this.lblEmail = new BasicControls.lbl();
            this.lblWebsite = new BasicControls.lbl();
            this.cmbFirmType = new BasicControls.cmbBox(this.components);
            this.txtFirmName = new BasicControls.txtBox();
            this.txtContactPerson = new BasicControls.txtBox();
            this.txtEmail = new BasicControls.txtBox();
            this.txtWebsite = new BasicControls.txtBox();
            this.grpFirmInfo = new BasicControls.grpBox();
            this.lblStd = new BasicControls.lbl();
            this.lblLandLine1 = new BasicControls.lbl();
            this.lblLandLine2 = new BasicControls.lbl();
            this.lblMobileNo1 = new BasicControls.lbl();
            this.lblMobileNo2 = new BasicControls.lbl();
            this.txtStd = new BasicControls.txtBox();
            this.txtLandLine1 = new BasicControls.txtBox();
            this.txtLandLine2 = new BasicControls.txtBox();
            this.txtMobileNo1 = new BasicControls.txtBox();
            this.txtMobileNo2 = new BasicControls.txtBox();
            this.grpContactInfo = new BasicControls.grpBox();
            this.grpBankingDetails = new BasicControls.grpBox();
            this.lblBankName = new BasicControls.lbl();
            this.lblIFSC = new BasicControls.lbl();
            this.lblAccountNo = new BasicControls.lbl();
            this.txtBankName = new BasicControls.txtBox();
            this.txtIFSC = new BasicControls.txtBox();
            this.txtAccountNo = new BasicControls.txtBox();
            this.grpRegistrations = new BasicControls.grpBox();
            this.lbl4 = new BasicControls.lbl();
            this.GSTINExpiry = new BasicControls.dateTimePicker();
            this.DL2Expiry = new BasicControls.dateTimePicker();
            this.txtDL2 = new BasicControls.txtBox();
            this.lbl5 = new BasicControls.lbl();
            this.DL1Expiry = new BasicControls.dateTimePicker();
            this.lbl3 = new BasicControls.lbl();
            this.txtDL1 = new BasicControls.txtBox();
            this.LabourExpiry = new BasicControls.dateTimePicker();
            this.WeightExpiry = new BasicControls.dateTimePicker();
            this.cmbRegType = new BasicControls.cmbBox(this.components);
            this.lblWeightM = new BasicControls.lbl();
            this.lbl1 = new BasicControls.lbl();
            this.lblLabour = new BasicControls.lbl();
            this.lbl2 = new BasicControls.lbl();
            this.lbl7 = new BasicControls.lbl();
            this.txtWeightM = new BasicControls.txtBox();
            this.lbl8 = new BasicControls.lbl();
            this.txtLabour = new BasicControls.txtBox();
            this.lbl9 = new BasicControls.lbl();
            this.txtGSTIN = new BasicControls.txtBox();
            this.txtCIN = new BasicControls.txtBox();
            this.txtTAN = new BasicControls.txtBox();
            this.txtPAN = new BasicControls.txtBox();
            this.grpAddressDetails = new BasicControls.grpBox();
            this.cmbState = new BasicControls.cmbBox(this.components);
            this.lblAddressLine1 = new BasicControls.lbl();
            this.lblAddressLine2 = new BasicControls.lbl();
            this.lblCity = new BasicControls.lbl();
            this.lblState = new BasicControls.lbl();
            this.lblPincode = new BasicControls.lbl();
            this.txtPincode = new BasicControls.txtBox();
            this.txtAddressLine1 = new BasicControls.txtBox();
            this.txtAddressLine2 = new BasicControls.txtBox();
            this.txtCity = new BasicControls.txtBox();
            this.grpFinancialYear = new BasicControls.grpBox();
            this.dtPickerFYTo = new BasicControls.dateTimePicker();
            this.dtPickerFYFrom = new BasicControls.dateTimePicker();
            this.lblFYTo = new BasicControls.lbl();
            this.lblFYFrom = new BasicControls.lbl();
            this.lblSelectFirm = new BasicControls.lbl();
            this.cmbBox2 = new BasicControls.cmbBox(this.components);
            this.btnSave = new BasicControls.btn();
            this.btnModify = new BasicControls.btn();
            this.pnl1 = new BasicControls.pnl(this.components);
            this.grpFirmInfo.SuspendLayout();
            this.grpContactInfo.SuspendLayout();
            this.grpBankingDetails.SuspendLayout();
            this.grpRegistrations.SuspendLayout();
            this.grpAddressDetails.SuspendLayout();
            this.grpFinancialYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirmType
            // 
            this.lblFirmType.AutoSize = true;
            this.lblFirmType.Location = new System.Drawing.Point(18, 27);
            this.lblFirmType.Name = "lblFirmType";
            this.lblFirmType.Size = new System.Drawing.Size(53, 13);
            this.lblFirmType.TabIndex = 0;
            this.lblFirmType.Text = "Firm Type";
            // 
            // lblFirmName
            // 
            this.lblFirmName.AutoSize = true;
            this.lblFirmName.Location = new System.Drawing.Point(18, 54);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(57, 13);
            this.lblFirmName.TabIndex = 2;
            this.lblFirmName.Text = "Firm Name";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(18, 81);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(80, 13);
            this.lblContactPerson.TabIndex = 4;
            this.lblContactPerson.Text = "Contact Person";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(18, 135);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(46, 13);
            this.lblWebsite.TabIndex = 8;
            this.lblWebsite.Text = "Website";
            // 
            // cmbFirmType
            // 
            this.cmbFirmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirmType.FormattingEnabled = true;
            this.cmbFirmType.Items.AddRange(new object[] {
            "-Select Firm Type-",
            "Medical - Wholesale",
            "Medical - Retail",
            "Medical - Wholesale + Retail",
            "Textile - Wholesale",
            "Textile - Retail",
            "Textile - Wholesale + Retail"});
            this.cmbFirmType.Location = new System.Drawing.Point(142, 24);
            this.cmbFirmType.Name = "cmbFirmType";
            this.cmbFirmType.Size = new System.Drawing.Size(298, 21);
            this.cmbFirmType.TabIndex = 1;
            // 
            // txtFirmName
            // 
            this.txtFirmName.Location = new System.Drawing.Point(142, 51);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(298, 20);
            this.txtFirmName.TabIndex = 3;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(142, 78);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(298, 20);
            this.txtContactPerson.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(142, 132);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(298, 20);
            this.txtWebsite.TabIndex = 9;
            // 
            // grpFirmInfo
            // 
            this.grpFirmInfo.Controls.Add(this.lblWebsite);
            this.grpFirmInfo.Controls.Add(this.lblEmail);
            this.grpFirmInfo.Controls.Add(this.lblContactPerson);
            this.grpFirmInfo.Controls.Add(this.lblFirmName);
            this.grpFirmInfo.Controls.Add(this.lblFirmType);
            this.grpFirmInfo.Controls.Add(this.txtWebsite);
            this.grpFirmInfo.Controls.Add(this.cmbFirmType);
            this.grpFirmInfo.Controls.Add(this.txtEmail);
            this.grpFirmInfo.Controls.Add(this.txtFirmName);
            this.grpFirmInfo.Controls.Add(this.txtContactPerson);
            this.grpFirmInfo.Location = new System.Drawing.Point(33, 51);
            this.grpFirmInfo.Name = "grpFirmInfo";
            this.grpFirmInfo.Size = new System.Drawing.Size(461, 166);
            this.grpFirmInfo.TabIndex = 0;
            this.grpFirmInfo.TabStop = false;
            this.grpFirmInfo.Text = "Firm Information";
            // 
            // lblStd
            // 
            this.lblStd.AutoSize = true;
            this.lblStd.Location = new System.Drawing.Point(18, 27);
            this.lblStd.Name = "lblStd";
            this.lblStd.Size = new System.Drawing.Size(79, 13);
            this.lblStd.TabIndex = 0;
            this.lblStd.Text = "Std (Land Line)";
            // 
            // lblLandLine1
            // 
            this.lblLandLine1.AutoSize = true;
            this.lblLandLine1.Location = new System.Drawing.Point(18, 54);
            this.lblLandLine1.Name = "lblLandLine1";
            this.lblLandLine1.Size = new System.Drawing.Size(63, 13);
            this.lblLandLine1.TabIndex = 2;
            this.lblLandLine1.Text = "Land Line 1";
            // 
            // lblLandLine2
            // 
            this.lblLandLine2.AutoSize = true;
            this.lblLandLine2.Location = new System.Drawing.Point(18, 81);
            this.lblLandLine2.Name = "lblLandLine2";
            this.lblLandLine2.Size = new System.Drawing.Size(63, 13);
            this.lblLandLine2.TabIndex = 4;
            this.lblLandLine2.Text = "Land Line 2";
            // 
            // lblMobileNo1
            // 
            this.lblMobileNo1.AutoSize = true;
            this.lblMobileNo1.Location = new System.Drawing.Point(18, 108);
            this.lblMobileNo1.Name = "lblMobileNo1";
            this.lblMobileNo1.Size = new System.Drawing.Size(67, 13);
            this.lblMobileNo1.TabIndex = 6;
            this.lblMobileNo1.Text = "Mobile No. 1";
            // 
            // lblMobileNo2
            // 
            this.lblMobileNo2.AutoSize = true;
            this.lblMobileNo2.Location = new System.Drawing.Point(18, 135);
            this.lblMobileNo2.Name = "lblMobileNo2";
            this.lblMobileNo2.Size = new System.Drawing.Size(67, 13);
            this.lblMobileNo2.TabIndex = 8;
            this.lblMobileNo2.Text = "Mobile No. 2";
            // 
            // txtStd
            // 
            this.txtStd.Location = new System.Drawing.Point(143, 24);
            this.txtStd.Name = "txtStd";
            this.txtStd.Size = new System.Drawing.Size(298, 20);
            this.txtStd.TabIndex = 1;
            // 
            // txtLandLine1
            // 
            this.txtLandLine1.Location = new System.Drawing.Point(143, 51);
            this.txtLandLine1.Name = "txtLandLine1";
            this.txtLandLine1.Size = new System.Drawing.Size(298, 20);
            this.txtLandLine1.TabIndex = 3;
            // 
            // txtLandLine2
            // 
            this.txtLandLine2.Location = new System.Drawing.Point(143, 78);
            this.txtLandLine2.Name = "txtLandLine2";
            this.txtLandLine2.Size = new System.Drawing.Size(298, 20);
            this.txtLandLine2.TabIndex = 5;
            // 
            // txtMobileNo1
            // 
            this.txtMobileNo1.Location = new System.Drawing.Point(143, 105);
            this.txtMobileNo1.Name = "txtMobileNo1";
            this.txtMobileNo1.Size = new System.Drawing.Size(298, 20);
            this.txtMobileNo1.TabIndex = 7;
            // 
            // txtMobileNo2
            // 
            this.txtMobileNo2.Location = new System.Drawing.Point(143, 132);
            this.txtMobileNo2.Name = "txtMobileNo2";
            this.txtMobileNo2.Size = new System.Drawing.Size(298, 20);
            this.txtMobileNo2.TabIndex = 9;
            // 
            // grpContactInfo
            // 
            this.grpContactInfo.Controls.Add(this.lblStd);
            this.grpContactInfo.Controls.Add(this.lblLandLine1);
            this.grpContactInfo.Controls.Add(this.lblLandLine2);
            this.grpContactInfo.Controls.Add(this.lblMobileNo1);
            this.grpContactInfo.Controls.Add(this.lblMobileNo2);
            this.grpContactInfo.Controls.Add(this.txtMobileNo2);
            this.grpContactInfo.Controls.Add(this.txtStd);
            this.grpContactInfo.Controls.Add(this.txtLandLine1);
            this.grpContactInfo.Controls.Add(this.txtLandLine2);
            this.grpContactInfo.Controls.Add(this.txtMobileNo1);
            this.grpContactInfo.Location = new System.Drawing.Point(33, 395);
            this.grpContactInfo.Name = "grpContactInfo";
            this.grpContactInfo.Size = new System.Drawing.Size(461, 166);
            this.grpContactInfo.TabIndex = 2;
            this.grpContactInfo.TabStop = false;
            this.grpContactInfo.Text = "Contact Information";
            // 
            // grpBankingDetails
            // 
            this.grpBankingDetails.Controls.Add(this.lblBankName);
            this.grpBankingDetails.Controls.Add(this.lblIFSC);
            this.grpBankingDetails.Controls.Add(this.lblAccountNo);
            this.grpBankingDetails.Controls.Add(this.txtBankName);
            this.grpBankingDetails.Controls.Add(this.txtIFSC);
            this.grpBankingDetails.Controls.Add(this.txtAccountNo);
            this.grpBankingDetails.Location = new System.Drawing.Point(525, 51);
            this.grpBankingDetails.Name = "grpBankingDetails";
            this.grpBankingDetails.Size = new System.Drawing.Size(657, 112);
            this.grpBankingDetails.TabIndex = 3;
            this.grpBankingDetails.TabStop = false;
            this.grpBankingDetails.Text = "Banking Details";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Location = new System.Drawing.Point(18, 27);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(63, 13);
            this.lblBankName.TabIndex = 0;
            this.lblBankName.Text = "Bank Name";
            // 
            // lblIFSC
            // 
            this.lblIFSC.AutoSize = true;
            this.lblIFSC.Location = new System.Drawing.Point(18, 54);
            this.lblIFSC.Name = "lblIFSC";
            this.lblIFSC.Size = new System.Drawing.Size(30, 13);
            this.lblIFSC.TabIndex = 2;
            this.lblIFSC.Text = "IFSC";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(18, 81);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(67, 13);
            this.lblAccountNo.TabIndex = 4;
            this.lblAccountNo.Text = "Account No.";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(143, 24);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(298, 20);
            this.txtBankName.TabIndex = 1;
            // 
            // txtIFSC
            // 
            this.txtIFSC.Location = new System.Drawing.Point(143, 51);
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.Size = new System.Drawing.Size(298, 20);
            this.txtIFSC.TabIndex = 3;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(143, 78);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(298, 20);
            this.txtAccountNo.TabIndex = 5;
            // 
            // grpRegistrations
            // 
            this.grpRegistrations.Controls.Add(this.lbl4);
            this.grpRegistrations.Controls.Add(this.GSTINExpiry);
            this.grpRegistrations.Controls.Add(this.DL2Expiry);
            this.grpRegistrations.Controls.Add(this.txtDL2);
            this.grpRegistrations.Controls.Add(this.lbl5);
            this.grpRegistrations.Controls.Add(this.DL1Expiry);
            this.grpRegistrations.Controls.Add(this.lbl3);
            this.grpRegistrations.Controls.Add(this.txtDL1);
            this.grpRegistrations.Controls.Add(this.LabourExpiry);
            this.grpRegistrations.Controls.Add(this.WeightExpiry);
            this.grpRegistrations.Controls.Add(this.cmbRegType);
            this.grpRegistrations.Controls.Add(this.lblWeightM);
            this.grpRegistrations.Controls.Add(this.lbl1);
            this.grpRegistrations.Controls.Add(this.lblLabour);
            this.grpRegistrations.Controls.Add(this.lbl2);
            this.grpRegistrations.Controls.Add(this.lbl7);
            this.grpRegistrations.Controls.Add(this.txtWeightM);
            this.grpRegistrations.Controls.Add(this.lbl8);
            this.grpRegistrations.Controls.Add(this.txtLabour);
            this.grpRegistrations.Controls.Add(this.lbl9);
            this.grpRegistrations.Controls.Add(this.txtGSTIN);
            this.grpRegistrations.Controls.Add(this.txtCIN);
            this.grpRegistrations.Controls.Add(this.txtTAN);
            this.grpRegistrations.Controls.Add(this.txtPAN);
            this.grpRegistrations.Location = new System.Drawing.Point(525, 174);
            this.grpRegistrations.Name = "grpRegistrations";
            this.grpRegistrations.Size = new System.Drawing.Size(657, 319);
            this.grpRegistrations.TabIndex = 0;
            this.grpRegistrations.TabStop = false;
            this.grpRegistrations.Text = "Registrations";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(463, 20);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(56, 13);
            this.lbl4.TabIndex = 48;
            this.lbl4.Text = "Valid Upto";
            // 
            // GSTINExpiry
            // 
            this.GSTINExpiry.CustomFormat = "dd/MM/yyyy";
            this.GSTINExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GSTINExpiry.Location = new System.Drawing.Point(463, 164);
            this.GSTINExpiry.Name = "GSTINExpiry";
            this.GSTINExpiry.Size = new System.Drawing.Size(135, 20);
            this.GSTINExpiry.TabIndex = 14;
            // 
            // DL2Expiry
            // 
            this.DL2Expiry.CustomFormat = "dd/MM/yyyy";
            this.DL2Expiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DL2Expiry.Location = new System.Drawing.Point(463, 134);
            this.DL2Expiry.Name = "DL2Expiry";
            this.DL2Expiry.Size = new System.Drawing.Size(135, 20);
            this.DL2Expiry.TabIndex = 11;
            // 
            // txtDL2
            // 
            this.txtDL2.Location = new System.Drawing.Point(143, 131);
            this.txtDL2.Name = "txtDL2";
            this.txtDL2.Size = new System.Drawing.Size(298, 20);
            this.txtDL2.TabIndex = 10;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(18, 142);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(99, 13);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "Drug License No. 2";
            // 
            // DL1Expiry
            // 
            this.DL1Expiry.CustomFormat = "dd/MM/yyyy";
            this.DL1Expiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DL1Expiry.Location = new System.Drawing.Point(463, 104);
            this.DL1Expiry.Name = "DL1Expiry";
            this.DL1Expiry.Size = new System.Drawing.Size(135, 20);
            this.DL1Expiry.TabIndex = 8;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(18, 112);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(99, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Drug License No. 1";
            // 
            // txtDL1
            // 
            this.txtDL1.Location = new System.Drawing.Point(143, 102);
            this.txtDL1.Name = "txtDL1";
            this.txtDL1.Size = new System.Drawing.Size(298, 20);
            this.txtDL1.TabIndex = 7;
            // 
            // LabourExpiry
            // 
            this.LabourExpiry.CustomFormat = "dd/MM/yyyy";
            this.LabourExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LabourExpiry.Location = new System.Drawing.Point(463, 74);
            this.LabourExpiry.Name = "LabourExpiry";
            this.LabourExpiry.Size = new System.Drawing.Size(135, 20);
            this.LabourExpiry.TabIndex = 5;
            // 
            // WeightExpiry
            // 
            this.WeightExpiry.CustomFormat = "dd/MM/yyyy";
            this.WeightExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WeightExpiry.Location = new System.Drawing.Point(463, 44);
            this.WeightExpiry.Name = "WeightExpiry";
            this.WeightExpiry.Size = new System.Drawing.Size(135, 20);
            this.WeightExpiry.TabIndex = 2;
            // 
            // cmbRegType
            // 
            this.cmbRegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegType.FormattingEnabled = true;
            this.cmbRegType.Items.AddRange(new object[] {
            "Registered",
            "Composition",
            "Unregistered"});
            this.cmbRegType.Location = new System.Drawing.Point(143, 189);
            this.cmbRegType.Name = "cmbRegType";
            this.cmbRegType.Size = new System.Drawing.Size(298, 21);
            this.cmbRegType.TabIndex = 16;
            // 
            // lblWeightM
            // 
            this.lblWeightM.AutoSize = true;
            this.lblWeightM.Location = new System.Drawing.Point(18, 48);
            this.lblWeightM.Name = "lblWeightM";
            this.lblWeightM.Size = new System.Drawing.Size(50, 13);
            this.lblWeightM.TabIndex = 0;
            this.lblWeightM.Text = "WeightM";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(18, 169);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 13);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "GSTIN";
            // 
            // lblLabour
            // 
            this.lblLabour.AutoSize = true;
            this.lblLabour.Location = new System.Drawing.Point(18, 80);
            this.lblLabour.Name = "lblLabour";
            this.lblLabour.Size = new System.Drawing.Size(40, 13);
            this.lblLabour.TabIndex = 3;
            this.lblLabour.Text = "Labour";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(18, 194);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 13);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "Reg. Type";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(18, 226);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(29, 13);
            this.lbl7.TabIndex = 17;
            this.lbl7.Text = "PAN";
            // 
            // txtWeightM
            // 
            this.txtWeightM.Location = new System.Drawing.Point(143, 44);
            this.txtWeightM.Name = "txtWeightM";
            this.txtWeightM.Size = new System.Drawing.Size(298, 20);
            this.txtWeightM.TabIndex = 1;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(18, 251);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(29, 13);
            this.lbl8.TabIndex = 19;
            this.lbl8.Text = "TAN";
            // 
            // txtLabour
            // 
            this.txtLabour.Location = new System.Drawing.Point(143, 73);
            this.txtLabour.Name = "txtLabour";
            this.txtLabour.Size = new System.Drawing.Size(298, 20);
            this.txtLabour.TabIndex = 4;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(18, 280);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(25, 13);
            this.lbl9.TabIndex = 21;
            this.lbl9.Text = "CIN";
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.Location = new System.Drawing.Point(143, 160);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.Size = new System.Drawing.Size(298, 20);
            this.txtGSTIN.TabIndex = 13;
            // 
            // txtCIN
            // 
            this.txtCIN.Location = new System.Drawing.Point(143, 277);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(298, 20);
            this.txtCIN.TabIndex = 22;
            // 
            // txtTAN
            // 
            this.txtTAN.Location = new System.Drawing.Point(143, 248);
            this.txtTAN.Name = "txtTAN";
            this.txtTAN.Size = new System.Drawing.Size(298, 20);
            this.txtTAN.TabIndex = 20;
            // 
            // txtPAN
            // 
            this.txtPAN.Location = new System.Drawing.Point(143, 219);
            this.txtPAN.Name = "txtPAN";
            this.txtPAN.Size = new System.Drawing.Size(298, 20);
            this.txtPAN.TabIndex = 18;
            // 
            // grpAddressDetails
            // 
            this.grpAddressDetails.Controls.Add(this.cmbState);
            this.grpAddressDetails.Controls.Add(this.lblAddressLine1);
            this.grpAddressDetails.Controls.Add(this.lblAddressLine2);
            this.grpAddressDetails.Controls.Add(this.lblCity);
            this.grpAddressDetails.Controls.Add(this.lblState);
            this.grpAddressDetails.Controls.Add(this.lblPincode);
            this.grpAddressDetails.Controls.Add(this.txtPincode);
            this.grpAddressDetails.Controls.Add(this.txtAddressLine1);
            this.grpAddressDetails.Controls.Add(this.txtAddressLine2);
            this.grpAddressDetails.Controls.Add(this.txtCity);
            this.grpAddressDetails.Location = new System.Drawing.Point(33, 223);
            this.grpAddressDetails.Name = "grpAddressDetails";
            this.grpAddressDetails.Size = new System.Drawing.Size(461, 166);
            this.grpAddressDetails.TabIndex = 1;
            this.grpAddressDetails.TabStop = false;
            this.grpAddressDetails.Text = "Address Details";
            // 
            // cmbState
            // 
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(142, 105);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(298, 21);
            this.cmbState.TabIndex = 7;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(18, 27);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 0;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(18, 54);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 2;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(18, 81);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(18, 108);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // lblPincode
            // 
            this.lblPincode.AutoSize = true;
            this.lblPincode.Location = new System.Drawing.Point(18, 135);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(46, 13);
            this.lblPincode.TabIndex = 8;
            this.lblPincode.Text = "Pincode";
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(143, 132);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(298, 20);
            this.txtPincode.TabIndex = 9;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(143, 24);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(298, 20);
            this.txtAddressLine1.TabIndex = 1;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(143, 51);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(298, 20);
            this.txtAddressLine2.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(143, 78);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(298, 20);
            this.txtCity.TabIndex = 5;
            // 
            // grpFinancialYear
            // 
            this.grpFinancialYear.Controls.Add(this.dtPickerFYTo);
            this.grpFinancialYear.Controls.Add(this.dtPickerFYFrom);
            this.grpFinancialYear.Controls.Add(this.lblFYTo);
            this.grpFinancialYear.Controls.Add(this.lblFYFrom);
            this.grpFinancialYear.Location = new System.Drawing.Point(525, 503);
            this.grpFinancialYear.Name = "grpFinancialYear";
            this.grpFinancialYear.Size = new System.Drawing.Size(657, 58);
            this.grpFinancialYear.TabIndex = 4;
            this.grpFinancialYear.TabStop = false;
            this.grpFinancialYear.Text = "Financial Year";
            // 
            // dtPickerFYTo
            // 
            this.dtPickerFYTo.CustomFormat = "dd/MM/yyyy";
            this.dtPickerFYTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerFYTo.Location = new System.Drawing.Point(309, 24);
            this.dtPickerFYTo.Name = "dtPickerFYTo";
            this.dtPickerFYTo.Size = new System.Drawing.Size(132, 20);
            this.dtPickerFYTo.TabIndex = 3;
            // 
            // dtPickerFYFrom
            // 
            this.dtPickerFYFrom.CustomFormat = "dd/MM/yyyy";
            this.dtPickerFYFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerFYFrom.Location = new System.Drawing.Point(88, 24);
            this.dtPickerFYFrom.Name = "dtPickerFYFrom";
            this.dtPickerFYFrom.Size = new System.Drawing.Size(132, 20);
            this.dtPickerFYFrom.TabIndex = 2;
            // 
            // lblFYTo
            // 
            this.lblFYTo.AutoSize = true;
            this.lblFYTo.Location = new System.Drawing.Point(249, 27);
            this.lblFYTo.Name = "lblFYTo";
            this.lblFYTo.Size = new System.Drawing.Size(42, 13);
            this.lblFYTo.TabIndex = 1;
            this.lblFYTo.Text = "F.Y. To";
            // 
            // lblFYFrom
            // 
            this.lblFYFrom.AutoSize = true;
            this.lblFYFrom.Location = new System.Drawing.Point(19, 27);
            this.lblFYFrom.Name = "lblFYFrom";
            this.lblFYFrom.Size = new System.Drawing.Size(52, 13);
            this.lblFYFrom.TabIndex = 0;
            this.lblFYFrom.Text = "F.Y. From";
            // 
            // lblSelectFirm
            // 
            this.lblSelectFirm.AutoSize = true;
            this.lblSelectFirm.Location = new System.Drawing.Point(34, 21);
            this.lblSelectFirm.Name = "lblSelectFirm";
            this.lblSelectFirm.Size = new System.Drawing.Size(59, 13);
            this.lblSelectFirm.TabIndex = 5;
            this.lblSelectFirm.Text = "Select Firm";
            // 
            // cmbBox2
            // 
            this.cmbBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox2.FormattingEnabled = true;
            this.cmbBox2.Items.AddRange(new object[] {
            "-Select Firm-"});
            this.cmbBox2.Location = new System.Drawing.Point(116, 18);
            this.cmbBox2.Name = "cmbBox2";
            this.cmbBox2.Size = new System.Drawing.Size(1007, 21);
            this.cmbBox2.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1072, 595);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(969, 595);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(12, 45);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1180, 526);
            this.pnl1.TabIndex = 9;
            // 
            // frmAddFirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 645);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbBox2);
            this.Controls.Add(this.lblSelectFirm);
            this.Controls.Add(this.grpFinancialYear);
            this.Controls.Add(this.grpAddressDetails);
            this.Controls.Add(this.grpRegistrations);
            this.Controls.Add(this.grpBankingDetails);
            this.Controls.Add(this.grpFirmInfo);
            this.Controls.Add(this.grpContactInfo);
            this.Controls.Add(this.pnl1);
            this.Name = "frmAddFirm";
            this.Text = "Add Firm";
            this.Load += new System.EventHandler(this.frmAddFirm_Load);
            this.grpFirmInfo.ResumeLayout(false);
            this.grpFirmInfo.PerformLayout();
            this.grpContactInfo.ResumeLayout(false);
            this.grpContactInfo.PerformLayout();
            this.grpBankingDetails.ResumeLayout(false);
            this.grpBankingDetails.PerformLayout();
            this.grpRegistrations.ResumeLayout(false);
            this.grpRegistrations.PerformLayout();
            this.grpAddressDetails.ResumeLayout(false);
            this.grpAddressDetails.PerformLayout();
            this.grpFinancialYear.ResumeLayout(false);
            this.grpFinancialYear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.lbl lblFirmType;
        private BasicControls.lbl lblFirmName;
        private BasicControls.lbl lblContactPerson;
        private BasicControls.lbl lblEmail;
        private BasicControls.lbl lblWebsite;
        private BasicControls.cmbBox cmbFirmType;
        private BasicControls.txtBox txtFirmName;
        private BasicControls.txtBox txtContactPerson;
        private BasicControls.txtBox txtEmail;
        private BasicControls.txtBox txtWebsite;
        private BasicControls.grpBox grpFirmInfo;
        private BasicControls.lbl lblStd;
        private BasicControls.lbl lblLandLine1;
        private BasicControls.lbl lblLandLine2;
        private BasicControls.lbl lblMobileNo1;
        private BasicControls.lbl lblMobileNo2;
        private BasicControls.txtBox txtStd;
        private BasicControls.txtBox txtLandLine1;
        private BasicControls.txtBox txtLandLine2;
        private BasicControls.txtBox txtMobileNo1;
        private BasicControls.txtBox txtMobileNo2;
        private BasicControls.grpBox grpContactInfo;
        private BasicControls.grpBox grpBankingDetails;
        private BasicControls.lbl lblBankName;
        private BasicControls.lbl lblIFSC;
        private BasicControls.lbl lblAccountNo;
        private BasicControls.txtBox txtBankName;
        private BasicControls.txtBox txtIFSC;
        private BasicControls.txtBox txtAccountNo;
        private BasicControls.grpBox grpRegistrations;
        private BasicControls.lbl lblWeightM;
        private BasicControls.lbl lblLabour;
        private BasicControls.txtBox txtWeightM;
        private BasicControls.txtBox txtLabour;
        private BasicControls.grpBox grpAddressDetails;
        private BasicControls.lbl lblAddressLine1;
        private BasicControls.lbl lblAddressLine2;
        private BasicControls.lbl lblCity;
        private BasicControls.lbl lblState;
        private BasicControls.lbl lblPincode;
        private BasicControls.txtBox txtPincode;
        private BasicControls.txtBox txtAddressLine1;
        private BasicControls.txtBox txtAddressLine2;
        private BasicControls.txtBox txtCity;
        private BasicControls.cmbBox cmbState;
        private BasicControls.lbl lbl3;
        private BasicControls.lbl lbl5;
        private BasicControls.txtBox txtDL1;
        private BasicControls.txtBox txtDL2;
        private BasicControls.cmbBox cmbRegType;
        private BasicControls.lbl lbl1;
        private BasicControls.lbl lbl2;
        private BasicControls.lbl lbl7;
        private BasicControls.lbl lbl8;
        private BasicControls.lbl lbl9;
        private BasicControls.txtBox txtCIN;
        private BasicControls.txtBox txtGSTIN;
        private BasicControls.txtBox txtPAN;
        private BasicControls.txtBox txtTAN;
        private BasicControls.dateTimePicker GSTINExpiry;
        private BasicControls.dateTimePicker DL2Expiry;
        private BasicControls.dateTimePicker DL1Expiry;
        private BasicControls.dateTimePicker LabourExpiry;
        private BasicControls.dateTimePicker WeightExpiry;
        private BasicControls.lbl lbl4;
        private BasicControls.grpBox grpFinancialYear;
        private BasicControls.lbl lblFYFrom;
        private BasicControls.lbl lblFYTo;
        private BasicControls.dateTimePicker dtPickerFYTo;
        private BasicControls.dateTimePicker dtPickerFYFrom;
        private BasicControls.lbl lblSelectFirm;
        private BasicControls.cmbBox cmbBox2;
        private BasicControls.btn btnSave;
        private BasicControls.btn btnModify;
        private BasicControls.pnl pnl1;
    }
}