namespace bai5._4
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
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            splitContainer = new SplitContainer();
            pnlLeftHeader = new Panel();
            lblTreeHeader = new Label();
            tvDepartments = new TreeView();
            pnlRightTop = new Panel();
            lblCurrentPath = new Label();
            cboViewMode = new ComboBox();
            lblViewMode = new Label();
            lsvEmployees = new ListView();
            colEmpId = new ColumnHeader();
            colEmpName = new ColumnHeader();
            colEmpPosition = new ColumnHeader();
            colEmpStartDate = new ColumnHeader();
            statusStrip = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            lblStatusCurrentNode = new ToolStripStatusLabel();
            imgTree = new ImageList(components);
            imgLarge = new ImageList(components);
            imgSmall = new ImageList(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            pnlLeftHeader.SuspendLayout();
            pnlRightTop.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(15, 118, 110);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(984, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(204, 251, 241);
            lblSubtitle.Location = new Point(22, 43);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(428, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Khám phá cấu trúc nhân sự tổ chức phân cấp và đa chế độ hiển thị linh hoạt";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(430, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ TẬP ĐOÀN";
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.Location = new Point(0, 75);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(tvDepartments);
            splitContainer.Panel1.Controls.Add(pnlLeftHeader);
            splitContainer.Panel1.Padding = new Padding(12, 10, 6, 10);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(lsvEmployees);
            splitContainer.Panel2.Controls.Add(pnlRightTop);
            splitContainer.Panel2.Padding = new Padding(6, 10, 12, 10);
            splitContainer.Size = new Size(984, 522);
            splitContainer.SplitterDistance = 320;
            splitContainer.TabIndex = 1;
            // 
            // pnlLeftHeader
            // 
            pnlLeftHeader.BackColor = Color.FromArgb(241, 245, 249);
            pnlLeftHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlLeftHeader.Controls.Add(lblTreeHeader);
            pnlLeftHeader.Dock = DockStyle.Top;
            pnlLeftHeader.Location = new Point(12, 10);
            pnlLeftHeader.Name = "pnlLeftHeader";
            pnlLeftHeader.Size = new Size(302, 36);
            pnlLeftHeader.TabIndex = 0;
            // 
            // lblTreeHeader
            // 
            lblTreeHeader.AutoSize = true;
            lblTreeHeader.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTreeHeader.ForeColor = Color.FromArgb(30, 41, 59);
            lblTreeHeader.Location = new Point(10, 9);
            lblTreeHeader.Name = "lblTreeHeader";
            lblTreeHeader.Size = new Size(160, 17);
            lblTreeHeader.TabIndex = 0;
            lblTreeHeader.Text = "Cơ cấu tổ chức công ty";
            // 
            // tvDepartments
            // 
            tvDepartments.BorderStyle = BorderStyle.FixedSingle;
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.Font = new Font("Segoe UI", 9.5F);
            tvDepartments.FullRowSelect = true;
            tvDepartments.HideSelection = false;
            tvDepartments.ItemHeight = 26;
            tvDepartments.Location = new Point(12, 46);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.ShowLines = true;
            tvDepartments.ShowRootLines = true;
            tvDepartments.Size = new Size(302, 466);
            tvDepartments.TabIndex = 1;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            // 
            // pnlRightTop
            // 
            pnlRightTop.BackColor = Color.FromArgb(248, 250, 252);
            pnlRightTop.BorderStyle = BorderStyle.FixedSingle;
            pnlRightTop.Controls.Add(lblCurrentPath);
            pnlRightTop.Controls.Add(cboViewMode);
            pnlRightTop.Controls.Add(lblViewMode);
            pnlRightTop.Dock = DockStyle.Top;
            pnlRightTop.Location = new Point(6, 10);
            pnlRightTop.Name = "pnlRightTop";
            pnlRightTop.Size = new Size(642, 44);
            pnlRightTop.TabIndex = 0;
            // 
            // lblCurrentPath
            // 
            lblCurrentPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentPath.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCurrentPath.ForeColor = Color.FromArgb(15, 118, 110);
            lblCurrentPath.Location = new Point(12, 11);
            lblCurrentPath.Name = "lblCurrentPath";
            lblCurrentPath.Size = new Size(370, 20);
            lblCurrentPath.TabIndex = 2;
            lblCurrentPath.Text = "Đang xem: Toàn công ty";
            // 
            // cboViewMode
            // 
            cboViewMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboViewMode.Font = new Font("Segoe UI", 9F);
            cboViewMode.FormattingEnabled = true;
            cboViewMode.Location = new Point(510, 9);
            cboViewMode.Name = "cboViewMode";
            cboViewMode.Size = new Size(120, 23);
            cboViewMode.TabIndex = 1;
            cboViewMode.SelectedIndexChanged += cboViewMode_SelectedIndexChanged;
            // 
            // lblViewMode
            // 
            lblViewMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblViewMode.AutoSize = true;
            lblViewMode.Font = new Font("Segoe UI", 9F);
            lblViewMode.Location = new Point(415, 13);
            lblViewMode.Name = "lblViewMode";
            lblViewMode.Size = new Size(88, 15);
            lblViewMode.TabIndex = 0;
            lblViewMode.Text = "Chế độ hiển thị:";
            // 
            // lsvEmployees
            // 
            lsvEmployees.BorderStyle = BorderStyle.FixedSingle;
            lsvEmployees.Columns.AddRange(new ColumnHeader[] { colEmpId, colEmpName, colEmpPosition, colEmpStartDate });
            lsvEmployees.Dock = DockStyle.Fill;
            lsvEmployees.Font = new Font("Segoe UI", 9.5F);
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.Location = new Point(6, 54);
            lsvEmployees.MultiSelect = false;
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(642, 458);
            lsvEmployees.TabIndex = 1;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // colEmpId
            // 
            colEmpId.Text = "Mã NV";
            colEmpId.Width = 90;
            // 
            // colEmpName
            // 
            colEmpName.Text = "Họ và Tên";
            colEmpName.Width = 190;
            // 
            // colEmpPosition
            // 
            colEmpPosition.Text = "Chức vụ";
            colEmpPosition.Width = 180;
            // 
            // colEmpStartDate
            // 
            colEmpStartDate.Text = "Ngày vào làm";
            colEmpStartDate.Width = 130;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatusCount, lblStatusCurrentNode });
            statusStrip.Location = new Point(0, 597);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(984, 24);
            statusStrip.TabIndex = 2;
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(129, 19);
            lblStatusCount.Text = "Tổng số nhân sự: 0";
            // 
            // lblStatusCurrentNode
            // 
            lblStatusCurrentNode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusCurrentNode.ForeColor = Color.FromArgb(15, 118, 110);
            lblStatusCurrentNode.Margin = new Padding(20, 3, 0, 2);
            lblStatusCurrentNode.Name = "lblStatusCurrentNode";
            lblStatusCurrentNode.Size = new Size(130, 19);
            lblStatusCurrentNode.Text = "Vị trí: Toàn công ty";
            // 
            // imgTree
            // 
            imgTree.ColorDepth = ColorDepth.Depth32Bit;
            imgTree.ImageSize = new Size(16, 16);
            imgTree.TransparentColor = Color.Transparent;
            // 
            // imgLarge
            // 
            imgLarge.ColorDepth = ColorDepth.Depth32Bit;
            imgLarge.ImageSize = new Size(48, 48);
            imgLarge.TransparentColor = Color.Transparent;
            // 
            // imgSmall
            // 
            imgSmall.ColorDepth = ColorDepth.Depth32Bit;
            imgSmall.ImageSize = new Size(24, 24);
            imgSmall.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(984, 621);
            Controls.Add(splitContainer);
            Controls.Add(statusStrip);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 660);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.4 - Trình Quản Lý Tập Tin & Nhân Sự Dạng Chuyên Nghiệp (TreeView & ListView)";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            pnlLeftHeader.ResumeLayout(false);
            pnlLeftHeader.PerformLayout();
            pnlRightTop.ResumeLayout(false);
            pnlRightTop.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private SplitContainer splitContainer;
        private Panel pnlLeftHeader;
        private Label lblTreeHeader;
        private TreeView tvDepartments;
        private Panel pnlRightTop;
        private Label lblCurrentPath;
        private Label lblViewMode;
        private ComboBox cboViewMode;
        private ListView lsvEmployees;
        private ColumnHeader colEmpId;
        private ColumnHeader colEmpName;
        private ColumnHeader colEmpPosition;
        private ColumnHeader colEmpStartDate;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatusCount;
        private ToolStripStatusLabel lblStatusCurrentNode;
        private ImageList imgTree;
        private ImageList imgLarge;
        private ImageList imgSmall;
    }
}
