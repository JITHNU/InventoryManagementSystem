namespace InventoryManagementSystem
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            label1 = new Label();
            dgvSuppliers = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSupplierID = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtCNumber = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(289, -2);
            label1.Name = "label1";
            label1.Size = new Size(176, 27);
            label1.TabIndex = 0;
            label1.Text = "Supplier Details";
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = SystemColors.ButtonFace;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(36, 252);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(643, 186);
            dgvSuppliers.TabIndex = 22;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(585, 131);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(471, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(190, 192);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOrange;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(316, 192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add Suppliers";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSupplierID
            // 
            txtSupplierID.BackColor = SystemColors.ControlLightLight;
            txtSupplierID.ForeColor = Color.DimGray;
            txtSupplierID.Location = new Point(36, 59);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(157, 27);
            txtSupplierID.TabIndex = 17;
            txtSupplierID.Text = "Supplier ID";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.HighlightText;
            txtAddress.ForeColor = Color.DimGray;
            txtAddress.Location = new Point(265, 131);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(211, 27);
            txtAddress.TabIndex = 16;
            txtAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.HighlightText;
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(36, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 27);
            txtEmail.TabIndex = 14;
            txtEmail.Text = "Email";
            // 
            // txtCNumber
            // 
            txtCNumber.BackColor = SystemColors.HighlightText;
            txtCNumber.ForeColor = Color.DimGray;
            txtCNumber.Location = new Point(515, 59);
            txtCNumber.Name = "txtCNumber";
            txtCNumber.Size = new Size(164, 27);
            txtCNumber.TabIndex = 13;
            txtCNumber.Text = "Contact Number";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HighlightText;
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(265, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(211, 27);
            txtName.TabIndex = 12;
            txtName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 36);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 49;
            label2.Text = "Supplier ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(265, 36);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 50;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(515, 36);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 51;
            label4.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(36, 108);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 52;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(265, 108);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 53;
            label6.Text = "Address:";
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(793, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSupplierID);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtCNumber);
            Controls.Add(txtName);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SupplierForm";
            Text = "Supplier";
            Load += SupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSuppliers;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSupplierID;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtCNumber;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}