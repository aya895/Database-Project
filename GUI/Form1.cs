using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BoutiqueHospitalityApp
{
    public partial class Form1 : Form
    {
        private DatabaseManager db = new DatabaseManager();
        private string currentTable = "";
        private bool isJoinMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    cboTables.Items.AddRange(new string[] { "HOTEL", "CONCIERGE", "SUITE", "GUEST", "EXPERIENCE", "RESERVATION", "RESERVATION_EXPERIENCE" });
        //    cboJoins.Items.AddRange(new string[] { "1. Reservation with Guest & Suite Details", "2. Experience with Concierge Details", "3. Reservation with Experience Details" });

        //    cboTables.SelectedIndex = 0; // Triggers UI configuration and loads data
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            // Clear first to prevent double-loading if you call it twice
            cboTables.Items.Clear();
            cboTables.Items.AddRange(new string[] { "HOTEL", "CONCIERGE", "SUITE", "GUEST", "EXPERIENCE", "RESERVATION", "RESERVATION_EXPERIENCE" });

            cboJoins.Items.Clear();
            cboJoins.Items.AddRange(new string[] { "1. Reservations & Guests", "2. Experiences & Concierge", "3. Reservation Experiences" });

            // This triggers the first table load (HOTEL)
            if (cboTables.Items.Count > 0)
                cboTables.SelectedIndex = 0;
        }

        private void cboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTables.SelectedIndex == -1) return;
            currentTable = cboTables.SelectedItem.ToString();
            isJoinMode = false;
            cboJoins.SelectedIndex = -1; // Deselect join query
            ConfigureUIForTable(currentTable);
            LoadData();
            ClearFields();
        }

        private void cboJoins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJoins.SelectedIndex == -1) return;
            isJoinMode = true;
            cboTables.SelectedIndex = -1;
            HideAllFields();

            try
            {
                if (cboJoins.SelectedIndex == 0)
                    dgvData.DataSource = db.GetJoinReservationGuestSuite();
                else if (cboJoins.SelectedIndex == 1)
                    dgvData.DataSource = db.GetJoinExperienceConcierge();
                else if (cboJoins.SelectedIndex == 2)
                    dgvData.DataSource = db.GetJoinReservationExperiences();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading join query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            if (string.IsNullOrEmpty(currentTable)) return;
            try
            {
                dgvData.DataSource = db.GetAll(currentTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureUIForTable(string table)
        {
            HideAllFields();
            switch (table)
            {
                case "HOTEL":
                    SetField(1, "Hotel ID", true); SetField(2, "Name", true); SetField(3, "Location", true); SetField(4, "Theme", true);
                    break;
                case "CONCIERGE":
                    SetField(1, "Concierge ID", true); SetField(2, "Name", true); SetField(3, "Specialized Skills", true);
                    break;
                case "SUITE":
                    SetField(1, "Suite ID", true); SetField(2, "Hotel ID", true); SetField(3, "Suite Number", true); SetField(4, "Suite Class", true); SetField(5, "Price per Night", true); SetField(6, "Amenities", true);
                    break;
                case "GUEST":
                    SetField(1, "Guest ID", true); SetField(2, "Full Name", true); SetField(3, "Email", true); SetField(4, "Phone", true); SetField(5, "Reg Date (yyyy-mm-dd)", true); SetField(6, "Billing Address", true);
                    break;
                case "EXPERIENCE":
                    SetField(1, "Experience ID", true); SetField(2, "Concierge ID", true); SetField(3, "Experience Name", true); SetField(4, "Description", true);
                    break;
                case "RESERVATION":
                    SetField(1, "Reservation ID", true); SetField(2, "Guest ID", true); SetField(3, "Suite ID", true); SetField(4, "Start Date (yyyy-mm-dd)", true); SetField(5, "End Date (yyyy-mm-dd)", true); SetField(6, "Total Price", true); SetField(7, "Status", true);
                    break;
                case "RESERVATION_EXPERIENCE":
                    SetField(1, "Res Exp ID", true); SetField(2, "Reservation ID", true); SetField(3, "Experience ID", true);
                    break;
            }
        }

        private void HideAllFields()
        {
            lblField1.Visible = txtField1.Visible = false;
            lblField2.Visible = txtField2.Visible = false;
            lblField3.Visible = txtField3.Visible = false;
            lblField4.Visible = txtField4.Visible = false;
            lblField5.Visible = txtField5.Visible = false;
            lblField6.Visible = txtField6.Visible = false;
            lblField7.Visible = txtField7.Visible = false; // Added for status/amenities logic
        }

        private void SetField(int index, string labelText, bool visible)
        {
            Label lbl = (Label)this.Controls.Find("lblField" + index, true)[0];
            TextBox txt = (TextBox)this.Controls.Find("txtField" + index, true)[0];
            lbl.Text = labelText;
            lbl.Visible = visible;
            txt.Visible = visible;
        }

        private void ClearFields()
        {
            txtField1.Clear(); txtField2.Clear(); txtField3.Clear();
            txtField4.Clear(); txtField5.Clear(); txtField6.Clear(); txtField7.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private bool ValidateRequiredFields()
        {
            for (int i = 1; i <= 7; i++)
            {
                TextBox txt = (TextBox)this.Controls.Find("txtField" + i, true)[0];
                if (txt.Visible && string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Please fill all visible fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (isJoinMode || string.IsNullOrEmpty(currentTable)) { MessageBox.Show("Please select a table to insert."); return; }
            if (!ValidateRequiredFields()) return;

            try
            {
                switch (currentTable)
                {
                    case "HOTEL":
                        db.InsertHotel(int.Parse(txtField1.Text), txtField2.Text, txtField3.Text, txtField4.Text);
                        break;
                    case "CONCIERGE":
                        db.InsertConcierge(int.Parse(txtField1.Text), txtField2.Text, txtField3.Text);
                        break;
                    case "SUITE":
                        db.InsertSuite(int.Parse(txtField1.Text), int.Parse(txtField2.Text), int.Parse(txtField3.Text), txtField4.Text, decimal.Parse(txtField5.Text), txtField6.Text);
                        break;
                    case "GUEST":
                        db.InsertGuest(int.Parse(txtField1.Text), txtField2.Text, txtField3.Text, txtField4.Text, DateTime.Parse(txtField5.Text), txtField6.Text);
                        break;
                    case "EXPERIENCE":
                        db.InsertExperience(int.Parse(txtField1.Text), int.Parse(txtField2.Text), txtField3.Text, txtField4.Text);
                        break;
                    case "RESERVATION":
                        db.InsertReservation(int.Parse(txtField1.Text), int.Parse(txtField2.Text), int.Parse(txtField3.Text), DateTime.Parse(txtField4.Text), DateTime.Parse(txtField5.Text), decimal.Parse(txtField6.Text), txtField7.Text);
                        break;
                    case "RESERVATION_EXPERIENCE":
                        db.InsertReservationExperience(int.Parse(txtField1.Text), int.Parse(txtField2.Text), int.Parse(txtField3.Text));
                        break;
                }
                MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) MessageBox.Show("Primary key violation. ID already exists.");
                else if (ex.Number == 547) MessageBox.Show("Foreign key violation. Parent record does not exist.");
                else MessageBox.Show("Database error: " + ex.Message);
            }
            catch (FormatException) { MessageBox.Show("Invalid input format. Please check numbers and dates.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isJoinMode || string.IsNullOrEmpty(currentTable)) { MessageBox.Show("Please select a table to update."); return; }
            if (!ValidateRequiredFields()) return;

            try
            {
                switch (currentTable)
                {
                    case "HOTEL":
                        db.UpdateHotel(int.Parse(txtField1.Text), txtField2.Text, txtField3.Text, txtField4.Text);
                        break;
                    case "CONCIERGE":
                        db.UpdateConcierge(int.Parse(txtField1.Text), txtField2.Text, txtField3.Text);
                        break;
                    case "SUITE":
                        db.UpdateSuite(int.Parse(txtField1.Text), int.Parse(txtField2.Text), int.Parse(txtField3.Text), txtField4.Text, decimal.Parse(txtField5.Text), txtField6.Text);
                        break;
                    case "GUEST":
                        db.UpdateGuest(int.Parse(txtField1.Text), txtField2.Text, txtField3.Text, txtField4.Text, DateTime.Parse(txtField5.Text), txtField6.Text);
                        break;
                    case "EXPERIENCE":
                        db.UpdateExperience(int.Parse(txtField1.Text), int.Parse(txtField2.Text), txtField3.Text, txtField4.Text);
                        break;
                    case "RESERVATION":
                        db.UpdateReservation(int.Parse(txtField1.Text), int.Parse(txtField2.Text), int.Parse(txtField3.Text), DateTime.Parse(txtField4.Text), DateTime.Parse(txtField5.Text), decimal.Parse(txtField6.Text), txtField7.Text);
                        break;
                    case "RESERVATION_EXPERIENCE":
                        db.UpdateReservationExperience(int.Parse(txtField1.Text), int.Parse(txtField2.Text), int.Parse(txtField3.Text));
                        break;
                }
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) MessageBox.Show("Foreign key violation. Parent record does not exist.");
                else MessageBox.Show("Database error: " + ex.Message);
            }
            catch (FormatException) { MessageBox.Show("Invalid input format. Please check numbers and dates.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isJoinMode || string.IsNullOrEmpty(currentTable)) { MessageBox.Show("Please select a table to delete from."); return; }
            if (string.IsNullOrWhiteSpace(txtField1.Text)) { MessageBox.Show("Please provide the ID to delete."); return; }

            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                string pkCol;
                if (currentTable == "RESERVATION_EXPERIENCE") pkCol = "RES_EXP_ID";
                else if (currentTable == "HOTEL") pkCol = "HOTEL_ID";
                else if (currentTable == "CONCIERGE") pkCol = "CONCIERGE_ID";
                else if (currentTable == "SUITE") pkCol = "SUITE_ID";
                else if (currentTable == "GUEST") pkCol = "GUEST_ID";
                else if (currentTable == "EXPERIENCE") pkCol = "EXPERIENCE_ID";
                else pkCol = "RESERVATION_ID";

                db.DeleteRecord(currentTable, pkCol, int.Parse(txtField1.Text));

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearFields();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) MessageBox.Show("Cannot delete this record because it is referenced by another table.", "Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                // Use a helper function to avoid "Index Out of Bounds"
                txtField1.Text = GetCellValue(row, 0);
                txtField2.Text = GetCellValue(row, 1);
                txtField3.Text = GetCellValue(row, 2);
                txtField4.Text = GetCellValue(row, 3);
                txtField5.Text = GetCellValue(row, 4);
                txtField6.Text = GetCellValue(row, 5);
                txtField7.Text = GetCellValue(row, 6);
            }
        }

        private string GetCellValue(DataGridViewRow row, int index)
        {
            // If the table has fewer columns than the index we're looking for, return empty
            if (index < row.Cells.Count)
            {
                return row.Cells[index].Value?.ToString() ?? "";
            }
            return "";
        }

        private void lblSelectJoin_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxMain_Enter(object sender, EventArgs e)
        {

        }
    }
}