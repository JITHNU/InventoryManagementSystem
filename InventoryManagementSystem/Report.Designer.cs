namespace InventoryManagementSystem
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            btnExportCSV = new Button();
            dgvReports = new DataGridView();
            btnFilter = new Button();
            txtStart = new TextBox();
            label1 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            txtEnd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // btnExportCSV
            // 
            btnExportCSV.BackColor = Color.Black;
            btnExportCSV.FlatStyle = FlatStyle.Flat;
            btnExportCSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCSV.ForeColor = SystemColors.ButtonHighlight;
            btnExportCSV.Location = new Point(304, 186);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(125, 29);
            btnExportCSV.TabIndex = 53;
            btnExportCSV.Text = "Export CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // dgvReports
            // 
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(62, 221);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(650, 217);
            dgvReports.TabIndex = 52;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.OrangeRed;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = SystemColors.ButtonHighlight;
            btnFilter.Location = new Point(622, 64);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(90, 29);
            btnFilter.TabIndex = 49;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtStart
            // 
            txtStart.BackColor = SystemColors.ControlLightLight;
            txtStart.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStart.Location = new Point(62, 85);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(88, 30);
            txtStart.TabIndex = 48;
            txtStart.Text = "Date From";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(291, 18);
            label1.Name = "label1";
            label1.Size = new Size(119, 35);
            label1.TabIndex = 47;
            label1.Text = "Reports";
            // 
            // dtpStart
            // 
            dtpStart.CalendarMonthBackground = SystemColors.InactiveCaption;
            dtpStart.Location = new Point(62, 132);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 27);
            dtpStart.TabIndex = 55;
            // 
            // dtpEnd
            // 
            dtpEnd.CalendarMonthBackground = SystemColors.InactiveCaption;
            dtpEnd.Location = new Point(462, 132);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 27);
            dtpEnd.TabIndex = 56;
            // 
            // txtEnd
            // 
            txtEnd.BackColor = SystemColors.ControlLightLight;
            txtEnd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEnd.Location = new Point(462, 85);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(69, 30);
            txtEnd.TabIndex = 57;
            txtEnd.Text = "Date To";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEnd);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(btnExportCSV);
            Controls.Add(dgvReports);
            Controls.Add(btnFilter);
            Controls.Add(txtStart);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExportCSV;
        private DataGridView dgvReports;
        private Button btnFilter;
        private TextBox txtStart;
        private Label label1;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private TextBox txtEnd;
    }
}