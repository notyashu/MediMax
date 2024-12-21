using System;
using System.Data.SQLite;
using BasicControls;
using Models;
using Utilities;

namespace MainForms
{
    public partial class frmAddFirm : frm
    {
        private bool isEditing = false;
        private string currentFirmId = null;

        public frmAddFirm()
        {
            InitializeComponent();
        }

        private void frmAddFirm_Load(object sender, EventArgs e)
        {
            PopulateCmbBoxes();
        }

        private void PopulateCmbBoxes()
        {
            PopulateCmbSelectFirm();

            cmbFirmType.Items.Clear();
            cmbFirmType.Items.AddRange(new string[]
            {
                "Medical - Wholesale",
                "Medical - Retail",
                "Medical - Wholesale + Retail",
                "Textile - Wholesale",
                "Textile - Retail",
                "Textile - Wholesale + Retail"
            });

            cmbRegType.Items.Clear();
            cmbRegType.Items.AddRange(new string[]
            {
                "Registered",
                "Composition",
                "Unregistered"
            });

            PopulateStates();
        }

        private void PopulateStates()
        {
            cmbState.Items.Clear();

            if (clConnection.CurrentDatabaseType == DatabaseType.SQLite)
            {
                using (var connection = clConnection.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT StateId, State FROM States";
                        using (var cmd = new SQLiteCommand(query, (SQLiteConnection)connection))
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string stateId = reader["StateId"].ToString();
                                string state = reader["State"].ToString();
                                cmbState.Items.Add($"{stateId} | {state}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clDialog.msgBox($"Error loading states: {ex.Message}", "E");
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing && string.IsNullOrEmpty(currentFirmId))
            {
                clDialog.msgBox("No firm selected for modification.", "E");
                return;
            }

            if (!ValidateFormInputs())
            {
                clDialog.msgBox("Please correct the errors in the form.", "E");
                return;
            }

            string firmId = isEditing ? currentFirmId : new clInteractDb().GetNextId("Firms", "FirmId");
            var firmData = GetFormData(firmId);

            using (var connection = clConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT OR REPLACE INTO Firms 
                                (FirmId, FirmType, Name, CP, AddA, AddB, City, StateId, Pin, Std, LandLineA, LandLineB, MobNoA, MobNoB, Email, Website, Bank, IFSC, AcNo, GSTIN, WeightM, Labour, DLNoA, DLNoB, LabExp, WMExp, DLExpA, DLExpB, RegType, PAN, TAN, CIN, WarnDays) 
                             VALUES
                                (@FirmId, @FirmType, @Name, @CP, @AddA, @AddB, @City, @StateId, @Pin, @Std, @LandLineA, @LandLineB, @MobNoA, @MobNoB, @Email, @Website, @Bank, @IFSC, @AcNo, @GSTIN, @WeightM, @Labour, @DLNoA, @DLNoB, @LabExp, @WMExp, @DLExpA, @DLExpB, @RegType, @PAN, @TAN, @CIN, @WarnDays)";

                    using (var cmd = new SQLiteCommand(query, (SQLiteConnection)connection))
                    {
                        AddQueryParamters(cmd, firmData);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            clDialog.msgBox("Firm details saved successfully.", "I");
                        }
                        else
                        {
                            clDialog.msgBox("Failed to save firm details.", "E");
                        }
                    }
                }
                catch (Exception ex)
                {
                    clDialog.msgBox($"Error saving firm: {ex.Message}", "E");
                }
            }

            ResetEditingState();
            PopulateCmbSelectFirm();
        }

        private void PopulateCmbSelectFirm()
        {
            cmbSelectFirm.Items.Clear();

            using (var connection = clConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT FirmId, Name FROM Firms ORDER BY Name";

                    using (var cmd = new SQLiteCommand(query, (SQLiteConnection)connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemText = $"{reader["FirmId"]} | {reader["Name"]}";
                            cmbSelectFirm.Items.Add(itemText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    clDialog.msgBox($"Error loading firms: {ex.Message}", "E");
                }
            }
        }

        private void cmbSelectFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectFirm.SelectedItem == null) return;

            currentFirmId = cmbSelectFirm.SelectedItem.ToString().Split('|')[0].Trim();

            using (var connection = clConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT f.*, s.State FROM Firms f LEFT JOIN States s ON f.StateId = s.StateId WHERE f.FirmId = @FirmId";

                    using (var cmd = new SQLiteCommand(query, (SQLiteConnection)connection))
                    {
                        cmd.Parameters.AddWithValue("@FirmId", currentFirmId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PopulateFormFields(reader);
                                ToggleFormControls(false);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    clDialog.msgBox($"Error loading firm details: {ex.Message}", "E");
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (cmbSelectFirm.SelectedItem == null)
            {
                clDialog.msgBox("Please select a firm to modify.", "E");
                return;
            }

            isEditing = true;
            ToggleFormControls(true);
        }

        private void ResetEditingState()
        {
            isEditing = false;
            currentFirmId = null;
            ToggleFormControls(false);
        }

        private void ToggleFormControls(bool enabled)
        {
            pnlFirmInfo.Enabled = enabled;
            pnlAddressDetails.Enabled = enabled;
            pnlContactInfo.Enabled = enabled;
            pnlBankingDetails.Enabled = enabled;
            pnlReg.Enabled = enabled;
            pnlFY1.Enabled = enabled;
            pnlFY2.Enabled = enabled;
            pnlWarnDays.Enabled = enabled;
        }

        private void AddQueryParamters(SQLiteCommand cmd, FirmData data)
        {
            cmd.Parameters.AddWithValue("@FirmId", data.FirmId);
            cmd.Parameters.AddWithValue("@FirmType", data.FirmType);
            cmd.Parameters.AddWithValue("@Name", data.Name);
            cmd.Parameters.AddWithValue("@CP", data.ContactPerson);
            cmd.Parameters.AddWithValue("@AddA", data.AddressLineA);
            cmd.Parameters.AddWithValue("@AddB", data.AddressLineB);
            cmd.Parameters.AddWithValue("@City", data.City);
            cmd.Parameters.AddWithValue("@StateId", data.StateId);
            cmd.Parameters.AddWithValue("@Pin", data.Pincode);
            cmd.Parameters.AddWithValue("@Std", data.StdCode);
            cmd.Parameters.AddWithValue("@LandLineA", data.LandlineA);
            cmd.Parameters.AddWithValue("@LandLineB", data.LandlineB);
            cmd.Parameters.AddWithValue("@MobNoA", data.MobileA);
            cmd.Parameters.AddWithValue("@MobNoB", data.MobileB);
            cmd.Parameters.AddWithValue("@Email", data.Email);
            cmd.Parameters.AddWithValue("@Website", data.Website);
            cmd.Parameters.AddWithValue("@Bank", data.BankName);
            cmd.Parameters.AddWithValue("@IFSC", data.IFSCCode);
            cmd.Parameters.AddWithValue("@AcNo", data.AccountNumber);
            cmd.Parameters.AddWithValue("@GSTIN", data.GSTIN);
            cmd.Parameters.AddWithValue("@WeightM", data.WeightMeasure);
            cmd.Parameters.AddWithValue("@Labour", data.LabourCharges);
            cmd.Parameters.AddWithValue("@DLNoA", data.DrugLicenseA);
            cmd.Parameters.AddWithValue("@DLNoB", data.DrugLicenseB);
            cmd.Parameters.AddWithValue("@LabExp", data.LabourExpiry);
            cmd.Parameters.AddWithValue("@WMExp", data.WeightMeasureExpiry);
            cmd.Parameters.AddWithValue("@DLExpA", data.DrugLicenseExpiryA);
            cmd.Parameters.AddWithValue("@DLExpB", data.DrugLicenseExpiryB);
            cmd.Parameters.AddWithValue("@RegType", data.RegistrationType);
            cmd.Parameters.AddWithValue("@PAN", data.PAN);
            cmd.Parameters.AddWithValue("@TAN", data.TAN);
            cmd.Parameters.AddWithValue("@CIN", data.CIN);
            cmd.Parameters.AddWithValue("@WarnDays", data.WarningDays);
        }

        private bool ValidateFormInputs()
        {
            // Implement validation logic for form inputs
            return true;
        }

        private FirmData GetFormData(string firmId)
        {
            // Collect form data into a FirmData object
            return new FirmData
            {
                FirmId = firmId,
                FirmType = cmbFirmType.SelectedIndex,
                Name = txtFirmName.Text.Trim(),
                ContactPerson = txtContactPerson.Text.Trim(),
                AddressLineA = txtAddressLine1.Text.Trim(),
                AddressLineB = txtAddressLine2.Text.Trim(),
                City = txtCity.Text.Trim(),
                StateId = cmbState.SelectedItem?.ToString().Split('|')[0].Trim(),
                Pincode = txtPincode.Text,
                StdCode = txtStd.Text.Trim(),
                LandlineA = txtLandLine1.Text.Trim(),
                LandlineB = txtLandLine2.Text.Trim(),
                MobileA = txtMobileNo1.Text.Trim(),
                MobileB = txtMobileNo2.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Website = txtWebsite.Text.Trim(),
                BankName = txtBankName.Text.Trim(),
                IFSCCode = txtIFSC.Text.Trim(),
                AccountNumber = txtAccountNo.Text.Trim(),
                GSTIN = txtGSTIN.Text.Trim(),
                WeightMeasure = txtWeightM.Text.Trim(),
                LabourCharges = txtLabour.Text.Trim(),
                DrugLicenseA = txtDL1.Text.Trim(),
                DrugLicenseB = txtDL2.Text.Trim(),
                LabourExpiry = labourExpiry.Value.Date,
                WeightMeasureExpiry = weightExpiry.Value.Date,
                DrugLicenseExpiryA = DL1Expiry.Value.Date,
                DrugLicenseExpiryB = DL2Expiry.Value.Date,
                RegistrationType = cmbRegType.SelectedIndex,
                PAN = txtPAN.Text.Trim(),
                TAN = txtTAN.Text.Trim(),
                CIN = txtCIN.Text.Trim(),
                WarningDays = int.Parse(txtWarnDays.Text),
            };
        }

        private void PopulateFormFields(SQLiteDataReader reader)
        {
            cmbFirmType.SelectedIndex = Convert.ToInt32(reader["FirmType"]);
            txtFirmName.Text = reader["Name"].ToString();
            txtContactPerson.Text = reader["CP"].ToString();
            txtAddressLine1.Text = reader["AddA"].ToString();
            txtAddressLine2.Text = reader["AddB"].ToString();
            txtCity.Text = reader["City"].ToString();
            cmbState.SelectedItem = $"{reader["StateId"]} | {reader["State"]}";
            txtPincode.Text = reader["Pin"].ToString();
            txtStd.Text = reader["Std"].ToString();
            txtLandLine1.Text = reader["LandLineA"].ToString();
            txtLandLine2.Text = reader["LandLineB"].ToString();
            txtMobileNo1.Text = reader["MobNoA"].ToString();
            txtMobileNo2.Text = reader["MobNoB"].ToString();
            txtEmail.Text = reader["Email"].ToString();
            txtWebsite.Text = reader["Website"].ToString();
            txtBankName.Text = reader["Bank"].ToString();
            txtIFSC.Text = reader["IFSC"].ToString();
            txtAccountNo.Text = reader["AcNo"].ToString();
            txtGSTIN.Text = reader["GSTIN"].ToString();
            txtWeightM.Text = reader["WeightM"].ToString();
            txtLabour.Text = reader["Labour"].ToString();
            txtDL1.Text = reader["DLNoA"].ToString();
            txtDL2.Text = reader["DLNoB"].ToString();
            labourExpiry.Value = Convert.ToDateTime(reader["LabExp"]);
            weightExpiry.Value = Convert.ToDateTime(reader["WMExp"]);
            DL1Expiry.Value = Convert.ToDateTime(reader["DLExpA"]);
            DL2Expiry.Value = Convert.ToDateTime(reader["DLExpB"]);
            cmbRegType.SelectedIndex = Convert.ToInt32(reader["RegType"]);
            txtPAN.Text = reader["PAN"].ToString();
            txtTAN.Text = reader["TAN"].ToString();
            txtCIN.Text = reader["CIN"].ToString();
            txtWarnDays.Text = reader["WarnDays"].ToString();
        }

        private class FirmData
        {
            public string FirmId { get; set; }
            public int FirmType { get; set; }
            public string Name { get; set; }
            public string ContactPerson { get; set; }
            public string AddressLineA { get; set; }
            public string AddressLineB { get; set; }
            public string City { get; set; }
            public string StateId { get; set; }
            public string Pincode { get; set; }
            public string StdCode { get; set; }
            public string LandlineA { get; set; }
            public string LandlineB { get; set; }
            public string MobileA { get; set; }
            public string MobileB { get; set; }
            public string Email { get; set; }
            public string Website { get; set; }
            public string BankName { get; set; }
            public string IFSCCode { get; set; }
            public string AccountNumber { get; set; }
            public string GSTIN { get; set; }
            public string WeightMeasure { get; set; }
            public string LabourCharges { get; set; }
            public string DrugLicenseA { get; set; }
            public string DrugLicenseB { get; set; }
            public DateTime LabourExpiry { get; set; }
            public DateTime WeightMeasureExpiry { get; set; }
            public DateTime DrugLicenseExpiryA { get; set; }
            public DateTime DrugLicenseExpiryB { get; set; }
            public int RegistrationType { get; set; }
            public string PAN { get; set; }
            public string TAN { get; set; }
            public string CIN { get; set; }
            public int WarningDays { get; set; }
        }
    }
}
