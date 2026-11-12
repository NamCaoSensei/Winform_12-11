namespace bai5._3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            epCheck = new ErrorProvider(components);
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            grpInfo = new GroupBox();
            nudQuantity = new NumericUpDown();
            lblQuantity = new Label();
            nudUnitPrice = new NumericUpDown();
            lblUnitPrice = new Label();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductId = new TextBox();
            lblProductId = new Label();
            grpActions = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlSearch = new Panel();
            btnResetSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            statusStrip = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            lblStatusTotalValue = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            pnlHeader.SuspendLayout();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).BeginInit();
            grpActions.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // epCheck
            // 
            epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            epCheck.ContainerControl = this;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(964, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(224, 231, 255);
            lblSubtitle.Location = new Point(22, 43);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(420, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Hệ thống quản lý dữ liệu sản phẩm trong bộ nhớ liên kết 2 chiều BindingSource";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(378, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ DANH SÁCH SẢN PHẨM KHO";
            // 
            // grpInfo
            // 
            grpInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInfo.Controls.Add(nudQuantity);
            grpInfo.Controls.Add(lblQuantity);
            grpInfo.Controls.Add(nudUnitPrice);
            grpInfo.Controls.Add(lblUnitPrice);
            grpInfo.Controls.Add(cboCategory);
            grpInfo.Controls.Add(lblCategory);
            grpInfo.Controls.Add(txtProductName);
            grpInfo.Controls.Add(lblProductName);
            grpInfo.Controls.Add(txtProductId);
            grpInfo.Controls.Add(lblProductId);
            grpInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpInfo.ForeColor = Color.FromArgb(30, 41, 59);
            grpInfo.Location = new Point(16, 83);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(932, 115);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin sản phẩm";
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 9.5F);
            nudQuantity.Location = new Point(780, 68);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(130, 24);
            nudQuantity.TabIndex = 9;
            nudQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F);
            lblQuantity.Location = new Point(700, 72);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(57, 15);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng:";
            // 
            // nudUnitPrice
            // 
            nudUnitPrice.Font = new Font("Segoe UI", 9.5F);
            nudUnitPrice.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudUnitPrice.Location = new Point(480, 68);
            nudUnitPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudUnitPrice.Name = "nudUnitPrice";
            nudUnitPrice.Size = new Size(180, 24);
            nudUnitPrice.TabIndex = 7;
            nudUnitPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI", 9F);
            lblUnitPrice.Location = new Point(390, 72);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(80, 15);
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "Đơn giá (VND):";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 9.5F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(105, 68);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(245, 25);
            cboCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F);
            lblCategory.Location = new Point(16, 72);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 15);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Danh mục:";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.Font = new Font("Segoe UI", 9.5F);
            txtProductName.Location = new Point(480, 28);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(430, 24);
            txtProductName.TabIndex = 3;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9F);
            lblProductName.Location = new Point(390, 32);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(83, 15);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên sản phẩm:";
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 9.5F);
            txtProductId.Location = new Point(105, 28);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(245, 24);
            txtProductId.TabIndex = 1;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI", 9F);
            lblProductId.Location = new Point(16, 32);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(82, 15);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã sản phẩm:";
            // 
            // grpActions
            // 
            grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnEdit);
            grpActions.Controls.Add(btnAdd);
            grpActions.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpActions.ForeColor = Color.FromArgb(30, 41, 59);
            grpActions.Location = new Point(16, 204);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(932, 65);
            grpActions.TabIndex = 2;
            grpActions.TabStop = false;
            grpActions.Text = "Chức năng thao tác";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(241, 245, 249);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F);
            btnClear.ForeColor = Color.FromArgb(51, 65, 85);
            btnClear.Location = new Point(410, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 32);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(275, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa Bỏ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(245, 158, 11);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(145, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 32);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Cập Nhật";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(79, 70, 229);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(16, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 32);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearch.Controls.Add(btnResetSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Location = new Point(16, 275);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(932, 42);
            pnlSearch.TabIndex = 3;
            // 
            // btnResetSearch
            // 
            btnResetSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetSearch.BackColor = Color.FromArgb(241, 245, 249);
            btnResetSearch.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetSearch.FlatStyle = FlatStyle.Flat;
            btnResetSearch.Font = new Font("Segoe UI", 9F);
            btnResetSearch.ForeColor = Color.FromArgb(51, 65, 85);
            btnResetSearch.Location = new Point(830, 6);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(90, 28);
            btnResetSearch.TabIndex = 2;
            btnResetSearch.Text = "Xóa lọc";
            btnResetSearch.UseVisualStyleBackColor = false;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(165, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập tên sản phẩm để tìm kiếm tức thời...";
            txtSearch.Size = new Size(650, 24);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(30, 41, 59);
            lblSearch.Location = new Point(6, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(150, 17);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm theo tên SP:";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Location = new Point(16, 323);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(932, 245);
            pnlGrid.TabIndex = 4;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.Fixed3D;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, colQty, colTotal });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(932, 245);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "ProductId";
            colId.FillWeight = 50F;
            colId.HeaderText = "Mã SP";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "ProductName";
            colName.FillWeight = 130F;
            colName.HeaderText = "Tên Sản Phẩm";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.FillWeight = 75F;
            colCategory.HeaderText = "Danh Mục";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "UnitPrice";
            colPrice.FillWeight = 60F;
            colPrice.HeaderText = "Đơn Giá (đ)";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.DataPropertyName = "Quantity";
            colQty.FillWeight = 45F;
            colQty.HeaderText = "Số Lượng";
            colQty.Name = "colQty";
            colQty.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.DataPropertyName = "TotalAmount";
            colTotal.FillWeight = 70F;
            colTotal.HeaderText = "Thành Tiền (đ)";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatusCount, lblStatusTotalValue });
            statusStrip.Location = new Point(0, 581);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(964, 24);
            statusStrip.TabIndex = 5;
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(130, 19);
            lblStatusCount.Text = "Số lượng sản phẩm: 0";
            // 
            // lblStatusTotalValue
            // 
            lblStatusTotalValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusTotalValue.ForeColor = Color.FromArgb(79, 70, 229);
            lblStatusTotalValue.Margin = new Padding(20, 3, 0, 2);
            lblStatusTotalValue.Name = "lblStatusTotalValue";
            lblStatusTotalValue.Size = new Size(160, 19);
            lblStatusTotalValue.Text = "Tổng giá trị tồn kho: 0 đ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(964, 605);
            Controls.Add(statusStrip);
            Controls.Add(pnlGrid);
            Controls.Add(pnlSearch);
            Controls.Add(grpActions);
            Controls.Add(grpInfo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(980, 640);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.3 - Quản Lý Danh Sách Sản Phẩm (DataGridView Cơ Bản)";
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).EndInit();
            grpActions.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ErrorProvider epCheck;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private GroupBox grpInfo;
        private TextBox txtProductId;
        private Label lblProductId;
        private TextBox txtProductName;
        private Label lblProductName;
        private ComboBox cboCategory;
        private Label lblCategory;
        private NumericUpDown nudUnitPrice;
        private Label lblUnitPrice;
        private NumericUpDown nudQuantity;
        private Label lblQuantity;
        private GroupBox grpActions;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnResetSearch;
        private Panel pnlGrid;
        private DataGridView dgvProducts;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatusCount;
        private ToolStripStatusLabel lblStatusTotalValue;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colTotal;
    }
}
