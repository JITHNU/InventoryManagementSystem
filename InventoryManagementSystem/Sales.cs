using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class SalesForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True";

        public SalesForm()
        {
            InitializeComponent();
            StyleDataGridView(dgvCart);
        }
        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, Name, UnitPrice FROM Products";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Add product name to combo
                    cmbProduct.Items.Add(reader["Name"].ToString());

                    // Optionally store ID/Price in Tag for quick access
                    cmbProduct.DisplayMember = "Name";
                    cmbProduct.ValueMember = "ProductID";
                }
            }
        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadProducts();

            if (dgvCart.Columns.Count == 0)
            {
                dgvCart.Columns.Add("ProductName", "Product Name");
                dgvCart.Columns.Add("Quantity", "Quantity");
                dgvCart.Columns.Add("UnitPrice", "Unit Price");
                dgvCart.Columns.Add("Total", "Total");
            }
        }

        private void btnAddTocart_Click(object sender, EventArgs e)
        {
            string product = cmbProduct.Text;
            int quantity = int.Parse(txtQuantity.Text);
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
            decimal total = quantity * unitPrice;

            dgvCart.Rows.Add(product, quantity, unitPrice, total);


            CalculateTotal();
        }
        private void CalculateTotal()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells[3].Value != null)
                    sum += Convert.ToDecimal(row.Cells[3].Value);
            }
            txtTotalAmount.Text = sum.ToString("0.00");
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    string productName = row.Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells[1].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells[2].Value);
                    decimal total = Convert.ToDecimal(row.Cells[3].Value);

                    string query = "INSERT INTO Sales (ProductName, Quantity, Price, SalesDate) " +
               "VALUES (@ProductName, @Quantity, @Price, @SalesDate)";


                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Price", unitPrice);
                    cmd.Parameters.AddWithValue("@SalesDate", DateTime.Now); // ✅ add current timestamp



                    cmd.ExecuteNonQuery();

                    // (Optional) reduce stock in Products table
                    string updateStock = "UPDATE Products SET QuantityInStock = QuantityInStock - @qty WHERE Name = @Name";
                    SqlCommand stockCmd = new SqlCommand(updateStock, con);
                    stockCmd.Parameters.AddWithValue("@qty", quantity);
                    stockCmd.Parameters.AddWithValue("@Name", productName);
                    stockCmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Sale Completed!\nTotal: " + txtTotalAmount.Text, "Success");

            // Clear after sale
            dgvCart.Rows.Clear();
            txtTotalAmount.Clear();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT UnitPrice FROM Products WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", cmbProduct.Text);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    txtUnitPrice.Text = result.ToString();
                }
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // light gray
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.Black;

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

    }
}
