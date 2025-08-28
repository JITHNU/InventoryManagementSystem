namespace InventoryManagementSystem
{
    partial class Productform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productform));
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtReorderLevel = new TextBox();
            txtProductID = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            txtSupplier = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.ControlLightLight;
            txtProductName.ForeColor = SystemColors.ScrollBar;
            txtProductName.Location = new Point(196, 80);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(151, 27);
            txtProductName.TabIndex = 1;
            txtProductName.Text = "Product Name";
            // 
            // txtCategory
            // 
            txtCategory.BackColor = SystemColors.ControlLightLight;
            txtCategory.ForeColor = SystemColors.ScrollBar;
            txtCategory.Location = new Point(389, 80);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(172, 27);
            txtCategory.TabIndex = 2;
            txtCategory.Text = "Product Category";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.ControlLightLight;
            txtUnitPrice.ForeColor = SystemColors.ScrollBar;
            txtUnitPrice.Location = new Point(196, 164);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(151, 27);
            txtUnitPrice.TabIndex = 3;
            txtUnitPrice.Text = "Unit Price";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.ControlLightLight;
            txtQuantity.ForeColor = SystemColors.ScrollBar;
            txtQuantity.Location = new Point(597, 80);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(117, 27);
            txtQuantity.TabIndex = 4;
            txtQuantity.Text = "Quantity";
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.BackColor = SystemColors.ControlLightLight;
            txtReorderLevel.ForeColor = SystemColors.ScrollBar;
            txtReorderLevel.Location = new Point(34, 164);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(125, 27);
            txtReorderLevel.TabIndex = 5;
            txtReorderLevel.Text = "Reorder Level";
            txtReorderLevel.TextChanged += txtReorderLevel_TextChanged;
            // 
            // txtProductID
            // 
            txtProductID.BackColor = SystemColors.ControlLightLight;
            txtProductID.ForeColor = SystemColors.ScrollBar;
            txtProductID.Location = new Point(34, 80);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 6;
            txtProductID.Text = "Product ID";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOrange;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(311, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Products";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(196, 220);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(487, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(620, 163);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.ButtonFace;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(34, 267);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(690, 251);
            dgvProducts.TabIndex = 11;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txtSupplier
            // 
            txtSupplier.BackColor = SystemColors.ControlLightLight;
            txtSupplier.ForeColor = SystemColors.ScrollBar;
            txtSupplier.Location = new Point(389, 165);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(172, 27);
            txtSupplier.TabIndex = 12;
            txtSupplier.Text = "Supplier ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(561, 314);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 57);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 48;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(196, 57);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 49;
            label3.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(389, 57);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 50;
            label4.Text = "Product Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(597, 57);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 51;
            label5.Text = "Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(34, 141);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 52;
            label6.Text = "Reorder Level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(196, 141);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 53;
            label7.Text = "Unit Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(389, 142);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 54;
            label8.Text = "Supplier ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkOrange;
            label9.Location = new Point(343, 9);
            label9.Name = "label9";
            label9.Size = new Size(101, 27);
            label9.TabIndex = 55;
            label9.Text = "Products";
            // 
            // Productform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(875, 538);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSupplier);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtProductID);
            Controls.Add(txtReorderLevel);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            DoubleBuffered = true;
            Name = "Productform";
            Text = "Product";
            Load += Productform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtReorderLevel;
        private TextBox txtProductID;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private TextBox txtSupplier;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}