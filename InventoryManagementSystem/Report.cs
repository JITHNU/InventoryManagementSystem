using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class Report : Form
    {
        private string connectionString = "Data Source=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True";
        public Report()
        {
            InitializeComponent();
            StyleDataGridView(dgvReports);
        }
        private void LoadReport(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Sales WHERE SalesDate BETWEEN @startDate AND @endDate";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReports.DataSource = dt;
            }
        }
        private void Report_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            LoadReport(today, today);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpStart.Value.Date;
            DateTime toDate = dtpEnd.Value.Date;

            LoadReport(fromDate, toDate);
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dgvReports.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Report.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    // Column headers
                    string[] columnNames = dgvReports.Columns.Cast<DataGridViewColumn>()
                        .Select(column => column.HeaderText).ToArray();
                    sb.AppendLine(string.Join(",", columnNames));

                    // Rows
                    foreach (DataGridViewRow row in dgvReports.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] fields = row.Cells.Cast<DataGridViewCell>()
                                .Select(cell => cell.Value?.ToString().Replace(",", " ")).ToArray();
                            sb.AppendLine(string.Join(",", fields));
                        }
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString());
                    MessageBox.Show("CSV Exported Successfully!");
                }
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // light gray
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReports.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvReports.DefaultCellStyle.SelectionForeColor = Color.Black;

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
