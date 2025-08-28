namespace InventoryManagementSystem
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            cmbProduct = new ComboBox();
            btnAddTocart = new Button();
            txtQuantity = new TextBox();
            label1 = new Label();
            txtUnitPrice = new TextBox();
            dgvCart = new DataGridView();
            txtTotalAmount = new TextBox();
            btnCompleteSale = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // cmbProduct
            // 
            cmbProduct.BackColor = SystemColors.ControlLightLight;
            cmbProduct.ForeColor = Color.DimGray;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(43, 88);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(151, 28);
            cmbProduct.TabIndex = 40;
            cmbProduct.Text = "Product";
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // btnAddTocart
            // 
            btnAddTocart.BackColor = Color.Black;
            btnAddTocart.FlatStyle = FlatStyle.Flat;
            btnAddTocart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTocart.ForeColor = SystemColors.ButtonFace;
            btnAddTocart.Location = new Point(584, 89);
            btnAddTocart.Name = "btnAddTocart";
            btnAddTocart.Size = new Size(125, 29);
            btnAddTocart.TabIndex = 39;
            btnAddTocart.Text = "Add To Cart";
            btnAddTocart.UseVisualStyleBackColor = false;
            btnAddTocart.Click += btnAddTocart_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.ControlLightLight;
            txtQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.ForeColor = SystemColors.GrayText;
            txtQuantity.Location = new Point(258, 86);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(134, 30);
            txtQuantity.TabIndex = 38;
            txtQuantity.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 27);
            label1.TabIndex = 37;
            label1.Text = "Sales Details";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.ControlLightLight;
            txtUnitPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.ForeColor = SystemColors.GrayText;
            txtUnitPrice.Location = new Point(444, 88);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 30);
            txtUnitPrice.TabIndex = 43;
            txtUnitPrice.Text = "Unit Price";
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(43, 153);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(535, 285);
            dgvCart.TabIndex = 44;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = SystemColors.ControlLightLight;
            txtTotalAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.ForeColor = SystemColors.GrayText;
            txtTotalAmount.Location = new Point(584, 333);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(125, 30);
            txtTotalAmount.TabIndex = 46;
            txtTotalAmount.Text = "Total Amount";
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.Black;
            btnCompleteSale.FlatStyle = FlatStyle.Flat;
            btnCompleteSale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteSale.ForeColor = SystemColors.ButtonHighlight;
            btnCompleteSale.Location = new Point(584, 397);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(125, 29);
            btnCompleteSale.TabIndex = 45;
            btnCompleteSale.Text = "Complete Sale";
            btnCompleteSale.UseVisualStyleBackColor = false;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(43, 54);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 50;
            label2.Text = "Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(258, 54);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 51;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Georgia", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(444, 54);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 52;
            label4.Text = "Unit Price:";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTotalAmount);
            Controls.Add(btnCompleteSale);
            Controls.Add(dgvCart);
            Controls.Add(txtUnitPrice);
            Controls.Add(cmbProduct);
            Controls.Add(btnAddTocart);
            Controls.Add(txtQuantity);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "SalesForm";
            Text = "Sales";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProduct;
        private Button btnAddTocart;
        private TextBox txtQuantity;
        private Label label1;
        private TextBox txtUnitPrice;
        private DataGridView dgvCart;
        private TextBox txtTotalAmount;
        private Button btnCompleteSale;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}