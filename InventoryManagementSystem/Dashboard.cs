using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Dashboard : Form
    {
        private System.Windows.Forms.Timer _timer;

        private string _adminName;

        public Dashboard(string adminName) // Pass username from login
        {
            InitializeComponent();
            _adminName = adminName; // Set admin name first
            panelMain.BringToFront();
            statusStrip1.BringToFront();
            LoadDashboard();
            InitializeStatusStrip();
        }

        #region Button Click Events

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new SupplierForm());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Productform());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new SalesForm());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Report());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Helper Methods

        private void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void LoadDashboard()
        {
            LoadFormIntoPanel(new DashboardForm());
        }

        private void InitializeStatusStrip()
        {
            // Show username
            toolStripStatusLabelUser.Text = "Logged in as: " + _adminName;

            // Show current date/time
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToString("dd MMM yyyy | hh:mm:ss tt");

            // Start live clock
            _timer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            _timer.Tick += (s, e) =>
            {
                toolStripStatusLabelDateTime.Text = DateTime.Now.ToString("dd MMM yyyy | hh:mm:ss tt");
            };
            _timer.Start();
        }

        #endregion

        #region Cleanup

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
            }
            base.OnFormClosing(e);
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            // Optional: leave empty if no custom painting is needed
        }

        #endregion

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

