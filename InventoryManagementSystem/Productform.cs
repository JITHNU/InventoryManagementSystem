using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSystem
{
    public partial class Productform : Form
    {
        public Productform()
        {
            InitializeComponent();
        }

        private void Productform_Load(object sender, EventArgs e)
        {
            label1.Text = "";

            LoadProducts();
            LoadSuppliers();
            StyleDataGridView(dgvProducts);  // Apply theme to grid
            StyleTextBoxes(this);
        }

        private void LoadProducts()
        {
            using SqlConnection conn = new SqlConnection("Server=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True;");
            conn.Open();
            string query = "SELECT ProductID, Name, Category, UnitPrice, QuantityInStock AS Quantity, ReorderLevel AS Reorder, SupplierID FROM Products";


            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProducts.DataSource = dt;
        }

        private void LoadSuppliers()
        {
            using SqlConnection conn = new SqlConnection("Server=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True;");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT SupplierID, Name FROM Suppliers", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;  // ✅ Run validation first

            using SqlConnection conn = new SqlConnection("Server=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True;");
            conn.Open();
            string query = "INSERT INTO Products (ProductID, Name, Category, UnitPrice, QuantityInStock, ReorderLevel, SupplierID) " +
                           "VALUES (@id, @name, @cat, @price, @qty, @reorder, @sup)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", txtProductID.Text);
            cmd.Parameters.AddWithValue("@name", txtProductName.Text);
            cmd.Parameters.AddWithValue("@cat", txtCategory.Text);
            cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtUnitPrice.Text));
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQuantity.Text));
            cmd.Parameters.AddWithValue("@reorder", Convert.ToInt32(txtReorderLevel.Text));
            cmd.Parameters.AddWithValue("@sup", txtSupplier.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Added Successfully!");

            LoadProducts();
            ClearForm();

        }

        

        private void txtReorderLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            if (!ValidateInputs()) return;  // ✅ Run validation first

            string productId = dgvProducts.CurrentRow.Cells["ProductID"].Value.ToString();

            using SqlConnection conn = new SqlConnection("Server=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True;");
            conn.Open();
            string query = "UPDATE Products SET Name=@n, Category=@c, UnitPrice=@p, QuantityInStock=@q, ReorderLevel=@r, SupplierID=@s WHERE ProductID=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@n", txtProductName.Text);
            cmd.Parameters.AddWithValue("@c", txtCategory.Text);
            cmd.Parameters.AddWithValue("@p", Convert.ToDecimal(txtUnitPrice.Text));
            cmd.Parameters.AddWithValue("@q", Convert.ToInt32(txtQuantity.Text));
            cmd.Parameters.AddWithValue("@r", Convert.ToInt32(txtReorderLevel.Text));
            cmd.Parameters.AddWithValue("@s", txtSupplier.Text);
            cmd.Parameters.AddWithValue("@id", productId);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated Successfully!");

            LoadProducts();
            ClearForm();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            string productId = dgvProducts.CurrentRow.Cells["ProductID"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using SqlConnection conn = new SqlConnection("Server=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @id", conn);
                cmd.Parameters.AddWithValue("@id", productId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully!");
                LoadProducts();
                ClearForm();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            dgvProducts.ClearSelection();
        }
        
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["Name"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtReorderLevel.Text = row.Cells["Reorder"].Value.ToString();
                txtSupplier.Text = row.Cells["SupplierID"].Value.ToString();
            }
        }


        private void ClearForm()
        {
            ClearTextBoxes(this);   // Start from the main form
            dgvProducts.ClearSelection();
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.Clear(); // clear existing value

                    // Set placeholder text manually
                    if (tb == txtProductID) tb.Text = "Product ID";
                    else if (tb == txtProductName) tb.Text = "Product Name";
                    else if (tb == txtCategory) tb.Text = "Category";
                    else if (tb == txtUnitPrice) tb.Text = "Unit Price";
                    else if (tb == txtQuantity) tb.Text = "Quantity";
                    else if (tb == txtReorderLevel) tb.Text = "Reorder Level";
                    else if (tb == txtSupplier) tb.Text = "Supplier ID";
                }
                else
                {
                    ClearTextBoxes(ctrl); // recursively clear nested controls
                }
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // light gray
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.Black;

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

        private void StyleTextBoxes(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.BackColor = Color.White;
                    tb.ForeColor = Color.Gray;
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

        private bool ValidateInputs()
        {
            // Placeholders (must match what you set in ClearTextBoxes)
            string[] placeholders = { "Product ID", "Product Name", "Category", "Unit Price", "Quantity", "Reorder Level", "Supplier ID" };

            // Check for empty or placeholder values
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || placeholders.Contains(txtProductID.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) || placeholders.Contains(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) || placeholders.Contains(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) || placeholders.Contains(txtUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) || placeholders.Contains(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtReorderLevel.Text) || placeholders.Contains(txtReorderLevel.Text) ||
                string.IsNullOrWhiteSpace(txtSupplier.Text) || placeholders.Contains(txtSupplier.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // ✅ Validate numeric fields
            if (!decimal.TryParse(txtUnitPrice.Text, out _))
            {
                MessageBox.Show("Unit Price must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (!int.TryParse(txtReorderLevel.Text, out _))
            {
                MessageBox.Show("Reorder Level must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReorderLevel.Focus();
                return false;
            }

            return true; // all checks passed
        }





    }



}
