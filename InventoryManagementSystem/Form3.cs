using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InventoryManagementSystem
{
    public partial class SupplierForm : Form
    {
        string connectionString = "Server=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True;";
        DataTable supplierTable;


        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
    StyleDataGridView(dgvSuppliers);  
    StyleTextBoxes(this);

    // ✅ Setup placeholders
    SetPlaceholder(txtSupplierID, "Supplier ID");
    SetPlaceholder(txtName, "Name");
    SetPlaceholder(txtCNumber, "Contact Number");
    SetPlaceholder(txtEmail, "Email");
    SetPlaceholder(txtAddress, "Address");            // Apply theme to textboxes
        }
        private bool ValidateInputs()
        {
            // List of placeholders (same as in ClearTextBoxes)
            string[] placeholders = { "Supplier ID", "Name", "Contact Number", "Email", "Address" };

            // Check empty fields or placeholders
            if (string.IsNullOrWhiteSpace(txtSupplierID.Text) || placeholders.Contains(txtSupplierID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) || placeholders.Contains(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCNumber.Text) || placeholders.Contains(txtCNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || placeholders.Contains(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) || placeholders.Contains(txtAddress.Text))
            {
                MessageBox.Show("Please enter all required fields.");
                return false;
            }

            // ✅ Validate Contact Number (exactly 10 digits)
            if (!Regex.IsMatch(txtCNumber.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Contact Number must contain exactly 10 digits.");
                txtCNumber.Focus();
                return false;
            }

            // ✅ Validate Email Address
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void LoadSuppliers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT SupplierID, Name, ContactNumber, Email, Address FROM Supplier", conn);
                supplierTable = new DataTable();
                da.Fill(supplierTable);
                dgvSuppliers.DataSource = supplierTable;
            }

            dgvSuppliers.ClearSelection();
        }

        // ✅ THEME for DataGridView
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // light gray
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSuppliers.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvSuppliers.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0); // Orange
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;

            dgv.GridColor = Color.LightGray;
        }

        // ✅ THEME for TextBoxes
        private void StyleTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.BackColor = Color.White;
                    tb.ForeColor = Color.Black;
                    tb.Font = new Font("Segoe UI", 10);

                    // Placeholder style (make text gray initially)
                    if (string.IsNullOrWhiteSpace(tb.Text))
                        tb.ForeColor = Color.Gray;
                }
                else
                {
                    StyleTextBoxes(ctrl); // apply recursively
                }
            }
        }
        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = placeholder;
                tb.ForeColor = Color.Gray;
            }

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;  // ✅ Run validation before saving

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "INSERT INTO Supplier (SupplierID, Name, ContactNumber, Email, Address) " +
                           "VALUES (@id, @name, @cnumber, @email, @address)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", txtSupplierID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@cnumber", txtCNumber.Text); // keep as string
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Supplier Added Successfully!");

            LoadSuppliers();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null) return;
            if (!ValidateInputs()) return;  // ✅ Run validation before updating

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "UPDATE Supplier SET Name=@name, ContactNumber=@cnumber, Email=@email, Address=@address " +
                           "WHERE SupplierID=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", txtSupplierID.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@cnumber", txtCNumber.Text); // keep as string
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Supplier Updated Successfully!");

            LoadSuppliers();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow == null) return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this supplier?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "DELETE FROM Supplier WHERE SupplierID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtSupplierID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSuppliers();
                ClearForm();
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSuppliers.Rows[e.RowIndex];

                txtSupplierID.Text = row.Cells["SupplierID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCNumber.Text = row.Cells["ContactNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();

                // reset textbox color back to black (not gray placeholder)
                txtSupplierID.ForeColor = Color.Black;
                txtName.ForeColor = Color.Black;
                txtCNumber.ForeColor = Color.Black;
                txtEmail.ForeColor = Color.Black;
                txtAddress.ForeColor = Color.Black;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            dgvSuppliers.ClearSelection();
        }

        private void ClearForm()
        {
            ClearTextBoxes(this);
            dgvSuppliers.ClearSelection();
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.Clear();
                    tb.ForeColor = Color.Gray;

                    // set placeholder text
                    if (tb == txtSupplierID) tb.Text = "Supplier ID";
                    else if (tb == txtName) tb.Text = "Name";
                    else if (tb == txtCNumber) tb.Text = "Contact Number";
                    else if (tb == txtEmail) tb.Text = "Email";
                    else if (tb == txtAddress) tb.Text = "Address";
                }
                else
                {
                    ClearTextBoxes(ctrl);
                }
            }
        }
    }
}
