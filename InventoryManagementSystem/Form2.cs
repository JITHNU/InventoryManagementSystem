using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.BackColor = Color.WhiteSmoke; // Light theme background
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            
            StyleButtons();
            LoadLowStockItems();
        }

        private void LoadLowStockItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True;"))
                {
                    conn.Open();
                    string query = "SELECT ProductID, Name, QuantityInStock, ReorderLevel FROM Products WHERE QuantityInStock <= ReorderLevel";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Pass dataGridView1 into the method
                    StyleDataGridView(dataGridView1);
                    HighlightLowStock();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock: " + ex.Message);
            }
        }

        private void HighlightLowStock()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["QuantityInStock"].Value != null && row.Cells["ReorderLevel"].Value != null)
                {
                    int stock = Convert.ToInt32(row.Cells["QuantityInStock"].Value);
                    int reorder = Convert.ToInt32(row.Cells["ReorderLevel"].Value);

                    if (stock <= reorder)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral; // red shade
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            // General settings
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // light gray
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Black;   // selection background
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;   // selection text
            dgv.BackgroundColor = Color.White;

            // Column header style
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0); // orange
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Row style
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;

            // Grid style
            dgv.GridColor = Color.LightGray;
        }




        private void StyleButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.Navy;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.Height = 40;
                }
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new SalesForm().ShowDialog();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            new Productform().ShowDialog();
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            new SupplierForm().ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new Report().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
