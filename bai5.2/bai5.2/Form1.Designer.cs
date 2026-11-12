namespace bai5._2
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
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlTop = new Panel();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            pnlCenter = new Panel();
            grpSelected = new GroupBox();
            lstSelectedServices = new ListBox();
            pnlButtons = new Panel();
            btnClearAll = new Button();
            btnRemove = new Button();
            btnSelect = new Button();
            grpAvailable = new GroupBox();
            lstAvailableServices = new ListBox();
            grpBilling = new GroupBox();
            btnPay = new Button();
            txtFinalAmount = new TextBox();
            lblFinalAmount = new Label();
            nudDiscount = new NumericUpDown();
            lblDiscount = new Label();
            txtTotalAmount = new TextBox();
            lblTotalAmount = new Label();
            pnlHeader.SuspendLayout();
            pnlTop.SuspendLayout();
            pnlCenter.SuspendLayout();
            grpSelected.SuspendLayout();
            pnlButtons.SuspendLayout();
            grpAvailable.SuspendLayout();
            grpBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(13, 148, 136);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(764, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(204, 251, 241);
            lblSubtitle.Location = new Point(22, 43);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(388, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Lựa chọn dịch vụ y tế, áp dụng ưu đãi chiết khấu và xuất hóa đơn thanh toán";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(393, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BẢNG TÍNH TIỀN DỊCH VỤ & CHIẾT KHẤU";
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(cboCategory);
            pnlTop.Controls.Add(lblCategory);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 75);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(764, 52);
            pnlTop.TabIndex = 1;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 9.5F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(145, 12);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(280, 25);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(30, 41, 59);
            lblCategory.Location = new Point(20, 16);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 17);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Nhóm danh mục:";
            // 
            // pnlCenter
            // 
            pnlCenter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCenter.Controls.Add(grpSelected);
            pnlCenter.Controls.Add(pnlButtons);
            pnlCenter.Controls.Add(grpAvailable);
            pnlCenter.Location = new Point(16, 132);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(732, 260);
            pnlCenter.TabIndex = 2;
            // 
            // grpSelected
            // 
            grpSelected.Controls.Add(lstSelectedServices);
            grpSelected.Dock = DockStyle.Fill;
            grpSelected.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpSelected.ForeColor = Color.FromArgb(30, 41, 59);
            grpSelected.Location = new Point(410, 0);
            grpSelected.Name = "grpSelected";
            grpSelected.Padding = new Padding(8);
            grpSelected.Size = new Size(322, 260);
            grpSelected.TabIndex = 2;
            grpSelected.TabStop = false;
            grpSelected.Text = "Dịch vụ đã chọn";
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.BorderStyle = BorderStyle.FixedSingle;
            lstSelectedServices.Dock = DockStyle.Fill;
            lstSelectedServices.Font = new Font("Segoe UI", 9.5F);
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.ItemHeight = 17;
            lstSelectedServices.Location = new Point(8, 26);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(306, 226);
            lstSelectedServices.TabIndex = 0;
            lstSelectedServices.DoubleClick += lstSelectedServices_DoubleClick;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnClearAll);
            pnlButtons.Controls.Add(btnRemove);
            pnlButtons.Controls.Add(btnSelect);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.Location = new Point(320, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(90, 260);
            pnlButtons.TabIndex = 1;
            // 
            // btnClearAll
            // 
            btnClearAll.Anchor = AnchorStyles.None;
            btnClearAll.BackColor = Color.FromArgb(241, 245, 249);
            btnClearAll.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnClearAll.ForeColor = Color.FromArgb(220, 38, 38);
            btnClearAll.Location = new Point(15, 155);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(60, 34);
            btnClearAll.TabIndex = 2;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.BackColor = Color.FromArgb(241, 245, 249);
            btnRemove.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnRemove.ForeColor = Color.FromArgb(30, 41, 59);
            btnRemove.Location = new Point(15, 110);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(60, 34);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.None;
            btnSelect.BackColor = Color.FromArgb(13, 148, 136);
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(15, 65);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(60, 34);
            btnSelect.TabIndex = 0;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // grpAvailable
            // 
            grpAvailable.Controls.Add(lstAvailableServices);
            grpAvailable.Dock = DockStyle.Left;
            grpAvailable.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpAvailable.ForeColor = Color.FromArgb(30, 41, 59);
            grpAvailable.Location = new Point(0, 0);
            grpAvailable.Name = "grpAvailable";
            grpAvailable.Padding = new Padding(8);
            grpAvailable.Size = new Size(320, 260);
            grpAvailable.TabIndex = 0;
            grpAvailable.TabStop = false;
            grpAvailable.Text = "Danh sách dịch vụ hiện có";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.BorderStyle = BorderStyle.FixedSingle;
            lstAvailableServices.Dock = DockStyle.Fill;
            lstAvailableServices.Font = new Font("Segoe UI", 9.5F);
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.ItemHeight = 17;
            lstAvailableServices.Location = new Point(8, 26);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(304, 226);
            lstAvailableServices.TabIndex = 0;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            // 
            // grpBilling
            // 
            grpBilling.Controls.Add(btnPay);
            grpBilling.Controls.Add(txtFinalAmount);
            grpBilling.Controls.Add(lblFinalAmount);
            grpBilling.Controls.Add(nudDiscount);
            grpBilling.Controls.Add(lblDiscount);
            grpBilling.Controls.Add(txtTotalAmount);
            grpBilling.Controls.Add(lblTotalAmount);
            grpBilling.Dock = DockStyle.Bottom;
            grpBilling.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpBilling.ForeColor = Color.FromArgb(30, 41, 59);
            grpBilling.Location = new Point(0, 405);
            grpBilling.Name = "grpBilling";
            grpBilling.Size = new Size(764, 126);
            grpBilling.TabIndex = 3;
            grpBilling.TabStop = false;
            grpBilling.Text = "Tính toán chi phí & Thanh toán";
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPay.BackColor = Color.FromArgb(13, 148, 136);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(570, 42);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(168, 52);
            btnPay.TabIndex = 6;
            btnPay.Text = "Thanh Toán Hóa Đơn";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // txtFinalAmount
            // 
            txtFinalAmount.BackColor = Color.FromArgb(240, 253, 250);
            txtFinalAmount.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtFinalAmount.ForeColor = Color.FromArgb(15, 118, 110);
            txtFinalAmount.Location = new Point(390, 68);
            txtFinalAmount.Name = "txtFinalAmount";
            txtFinalAmount.ReadOnly = true;
            txtFinalAmount.Size = new Size(150, 26);
            txtFinalAmount.TabIndex = 5;
            txtFinalAmount.Text = "0 đ";
            txtFinalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFinalAmount
            // 
            lblFinalAmount.AutoSize = true;
            lblFinalAmount.Font = new Font("Segoe UI", 9F);
            lblFinalAmount.Location = new Point(275, 74);
            lblFinalAmount.Name = "lblFinalAmount";
            lblFinalAmount.Size = new Size(106, 15);
            lblFinalAmount.TabIndex = 4;
            lblFinalAmount.Text = "Thành tiền phải trả:";
            // 
            // nudDiscount
            // 
            nudDiscount.Font = new Font("Segoe UI", 9.5F);
            nudDiscount.Location = new Point(390, 28);
            nudDiscount.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(150, 24);
            nudDiscount.TabIndex = 3;
            nudDiscount.TextAlign = HorizontalAlignment.Right;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 9F);
            lblDiscount.Location = new Point(275, 32);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(99, 15);
            lblDiscount.TabIndex = 2;
            lblDiscount.Text = "Chiết khấu (%):";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.FromArgb(248, 250, 252);
            txtTotalAmount.Font = new Font("Segoe UI", 9.5F);
            txtTotalAmount.Location = new Point(145, 48);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(115, 24);
            txtTotalAmount.TabIndex = 1;
            txtTotalAmount.Text = "0 đ";
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F);
            lblTotalAmount.Location = new Point(20, 52);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(116, 15);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "Tổng tiền chưa giảm:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(764, 531);
            Controls.Add(grpBilling);
            Controls.Add(pnlCenter);
            Controls.Add(pnlTop);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(780, 570);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.2 - Bảng Tính Tiền Dịch Vụ Và Chiết Khấu";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlCenter.ResumeLayout(false);
            grpSelected.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            grpAvailable.ResumeLayout(false);
            grpBilling.ResumeLayout(false);
            grpBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlTop;
        private ComboBox cboCategory;
        private Label lblCategory;
        private Panel pnlCenter;
        private GroupBox grpAvailable;
        private ListBox lstAvailableServices;
        private Panel pnlButtons;
        private Button btnClearAll;
        private Button btnRemove;
        private Button btnSelect;
        private GroupBox grpSelected;
        private ListBox lstSelectedServices;
        private GroupBox grpBilling;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private Label lblDiscount;
        private NumericUpDown nudDiscount;
        private Label lblFinalAmount;
        private TextBox txtFinalAmount;
        private Button btnPay;
    }
}
