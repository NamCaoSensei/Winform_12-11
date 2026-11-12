using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace bai5._4
{
    public partial class Form1 : Form
    {
        private readonly List<Employee> allEmployees = new();

        public Form1()
        {
            InitializeComponent();
            InitIcons();
            InitViewModes();
            InitSampleData();
            BuildDepartmentTree();
        }

        private void InitIcons()
        {
            // 1. Icon cho TreeView (16x16)
            imgTree.Images.Add("company", CreateColorIcon(16, 16, Color.FromArgb(15, 118, 110), "C"));
            imgTree.Images.Add("department", CreateColorIcon(16, 16, Color.FromArgb(2, 132, 199), "D"));
            imgTree.Images.Add("team", CreateColorIcon(16, 16, Color.FromArgb(217, 119, 6), "T"));
            tvDepartments.ImageList = imgTree;

            // 2. Icon cho ListView - Small (24x24)
            imgSmall.Images.Add("male", CreateAvatarIcon(24, 24, Color.FromArgb(37, 99, 235), "N"));
            imgSmall.Images.Add("female", CreateAvatarIcon(24, 24, Color.FromArgb(219, 39, 119), "U"));
            lsvEmployees.SmallImageList = imgSmall;

            // 3. Icon cho ListView - Large (48x48)
            imgLarge.Images.Add("male", CreateAvatarIcon(48, 48, Color.FromArgb(37, 99, 235), "Nam"));
            imgLarge.Images.Add("female", CreateAvatarIcon(48, 48, Color.FromArgb(219, 39, 119), "Nữ"));
            lsvEmployees.LargeImageList = imgLarge;
        }

        private Bitmap CreateColorIcon(int w, int h, Color color, string symbol)
        {
            Bitmap bmp = new(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Brush b = new SolidBrush(color))
                {
                    g.FillRoundedRectangle(b, new Rectangle(0, 0, w - 1, h - 1), 3);
                }
                using (Font f = new("Segoe UI", w * 0.55f, FontStyle.Bold))
                using (StringFormat sf = new() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    g.DrawString(symbol, f, Brushes.White, new RectangleF(0, 0, w, h), sf);
                }
            }
            return bmp;
        }

        private Bitmap CreateAvatarIcon(int w, int h, Color color, string label)
        {
            Bitmap bmp = new(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Brush b = new SolidBrush(color))
                {
                    g.FillEllipse(b, 2, 2, w - 4, h - 4);
                }
                using (Font f = new("Segoe UI", w * 0.35f, FontStyle.Bold))
                using (StringFormat sf = new() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    g.DrawString(label, f, Brushes.White, new RectangleF(0, 0, w, h), sf);
                }
            }
            return bmp;
        }

        private void InitViewModes()
        {
            cboViewMode.Items.AddRange(new object[]
            {
                "Details (Chi tiết)",
                "LargeIcon (Biểu tượng lớn)",
                "SmallIcon (Biểu tượng nhỏ)",
                "Tile (Dạng ô lát)",
                "List (Danh sách)"
            });
            cboViewMode.SelectedIndex = 0; // Details
        }

        private void InitSampleData()
        {
            allEmployees.AddRange(new[]
            {
                // Phòng Phát Triển Phần Mềm
                new Employee("NV001", "Nguyễn Văn An", "Trưởng phòng Phần mềm", new DateTime(2019, 3, 15), "Tập Đoàn/Phòng Phát Triển Phần Mềm", "Nam"),
                new Employee("NV002", "Trần Thị Mai", "Frontend Lead", new DateTime(2021, 6, 1), "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Web Frontend", "Nữ"),
                new Employee("NV003", "Lê Hoàng Nam", "Frontend Developer", new DateTime(2022, 9, 10), "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Web Frontend", "Nam"),
                new Employee("NV004", "Phạm Quốc Tuấn", "Backend Architect", new DateTime(2020, 2, 20), "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Backend & API", "Nam"),
                new Employee("NV005", "Vũ Minh Tâm", "Backend Developer", new DateTime(2023, 1, 15), "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Backend & API", "Nam"),
                new Employee("NV006", "Đỗ Hương Giang", "Mobile Team Lead", new DateTime(2021, 11, 5), "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Mobile App", "Nữ"),
                new Employee("NV007", "Bùi Thế Long", "Flutter Developer", new DateTime(2023, 4, 18), "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Mobile App", "Nam"),

                // Phòng Hạ Tầng & An Ninh Mạng
                new Employee("NV008", "Ngô Quốc Hùng", "Trưởng phòng Hạ tầng", new DateTime(2018, 5, 12), "Tập Đoàn/Phòng Hạ Tầng & An Ninh Mạng", "Nam"),
                new Employee("NV009", "Đặng Quang Huy", "DevOps Engineer Lead", new DateTime(2021, 8, 22), "Tập Đoàn/Phòng Hạ Tầng & An Ninh Mạng/Nhóm DevOps & Cloud", "Nam"),
                new Employee("NV010", "Nguyễn Tuấn Kiệt", "Cloud System Admin", new DateTime(2022, 12, 1), "Tập Đoàn/Phòng Hạ Tầng & An Ninh Mạng/Nhóm DevOps & Cloud", "Nam"),
                new Employee("NV011", "Trương Thu Hà", "Security Specialist", new DateTime(2022, 5, 10), "Tập Đoàn/Phòng Hạ Tầng & An Ninh Mạng/Nhóm An Toàn Thông Tin", "Nữ"),

                // Phòng Kinh Doanh & Tiếp Thị
                new Employee("NV012", "Hoàng Kim Liên", "Trưởng phòng Kinh Doanh", new DateTime(2019, 8, 14), "Tập Đoàn/Phòng Kinh Doanh & Tiếp Thị", "Nữ"),
                new Employee("NV013", "Võ Minh Đức", "Marketing Specialist", new DateTime(2022, 2, 28), "Tập Đoàn/Phòng Kinh Doanh & Tiếp Thị/Nhóm Digital Marketing", "Nam"),
                new Employee("NV014", "Nguyễn Thùy Dung", "Customer Success Lead", new DateTime(2021, 4, 15), "Tập Đoàn/Phòng Kinh Doanh & Tiếp Thị/Nhóm Chăm Sóc Khách Hàng", "Nữ"),
                new Employee("NV015", "Phan Gia Bảo", "Support Specialist", new DateTime(2023, 7, 1), "Tập Đoàn/Phòng Kinh Doanh & Tiếp Thị/Nhóm Chăm Sóc Khách Hàng", "Nam")
            });
        }

        private void BuildDepartmentTree()
        {
            tvDepartments.BeginUpdate();
            tvDepartments.Nodes.Clear();

            TreeNode root = new("Tập Đoàn Công Nghệ Toàn Cầu")
            {
                Tag = "Tập Đoàn",
                ImageKey = "company",
                SelectedImageKey = "company"
            };

            // 1. Phòng Phát Triển Phần Mềm
            TreeNode depDev = new("Phòng Phát Triển Phần Mềm")
            {
                Tag = "Tập Đoàn/Phòng Phát Triển Phần Mềm",
                ImageKey = "department",
                SelectedImageKey = "department"
            };
            depDev.Nodes.Add(new TreeNode("Nhóm Web Frontend") { Tag = "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Web Frontend", ImageKey = "team", SelectedImageKey = "team" });
            depDev.Nodes.Add(new TreeNode("Nhóm Backend & API") { Tag = "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Backend & API", ImageKey = "team", SelectedImageKey = "team" });
            depDev.Nodes.Add(new TreeNode("Nhóm Mobile App") { Tag = "Tập Đoàn/Phòng Phát Triển Phần Mềm/Nhóm Mobile App", ImageKey = "team", SelectedImageKey = "team" });

            // 2. Phòng Hạ Tầng & An Ninh Mạng
            TreeNode depInfra = new("Phòng Hạ Tầng & An Ninh Mạng")
            {
                Tag = "Tập Đoàn/Phòng Hạ Tầng & An Ninh Mạng",
                ImageKey = "department",
                SelectedImageKey = "department"
            };
            depInfra.Nodes.Add(new TreeNode("Nhóm DevOps & Cloud") { Tag = "Tập Đoàn/Phòng Hạ Tầng & An Ninh Mạng/Nhóm DevOps & Cloud", ImageKey = "team", SelectedImageKey = "team" });
            depInfra.Nodes.Add(new TreeNode("Nhóm An Toàn Thông Tin") { Tag = "Tập Đoàn/Phòng Hạ Tầng & An Ninh Mạng/Nhóm An Toàn Thông Tin", ImageKey = "team", SelectedImageKey = "team" });

            // 3. Phòng Kinh Doanh & Tiếp Thị
            TreeNode depBiz = new("Phòng Kinh Doanh & Tiếp Thị")
            {
                Tag = "Tập Đoàn/Phòng Kinh Doanh & Tiếp Thị",
                ImageKey = "department",
                SelectedImageKey = "department"
            };
            depBiz.Nodes.Add(new TreeNode("Nhóm Digital Marketing") { Tag = "Tập Đoàn/Phòng Kinh Doanh & Tiếp Thị/Nhóm Digital Marketing", ImageKey = "team", SelectedImageKey = "team" });
            depBiz.Nodes.Add(new TreeNode("Nhóm Chăm Sóc Khách Hàng") { Tag = "Tập Đoàn/Phòng Kinh Doanh & Tiếp Thị/Nhóm Chăm Sóc Khách Hàng", ImageKey = "team", SelectedImageKey = "team" });

            root.Nodes.Add(depDev);
            root.Nodes.Add(depInfra);
            root.Nodes.Add(depBiz);

            tvDepartments.Nodes.Add(root);
            tvDepartments.ExpandAll();
            tvDepartments.SelectedNode = root;
            tvDepartments.EndUpdate();
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;

            string path = e.Node.Tag?.ToString() ?? "";
            lblCurrentPath.Text = $"Đang xem: {e.Node.FullPath}";
            lblStatusCurrentNode.Text = $"Vị trí: {e.Node.Text}";

            LoadEmployeesByPath(path);
        }

        private void LoadEmployeesByPath(string path)
        {
            lsvEmployees.BeginUpdate();
            lsvEmployees.Items.Clear();

            var filtered = string.IsNullOrEmpty(path) || path == "Tập Đoàn"
                ? allEmployees
                : allEmployees.Where(emp => emp.DepartmentPath.StartsWith(path, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var emp in filtered)
            {
                ListViewItem lvi = new(emp.EmployeeId)
                {
                    Tag = emp,
                    ImageKey = emp.Gender == "Nữ" ? "female" : "male"
                };

                lvi.SubItems.Add(emp.FullName);
                lvi.SubItems.Add(emp.Position);
                lvi.SubItems.Add(emp.StartDate.ToString("dd/MM/yyyy"));

                lsvEmployees.Items.Add(lvi);
            }

            lsvEmployees.EndUpdate();
            lblStatusCount.Text = $"Tổng số nhân sự: {filtered.Count} / {allEmployees.Count}";
        }

        private void cboViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboViewMode.SelectedIndex)
            {
                case 0:
                    lsvEmployees.View = View.Details;
                    break;
                case 1:
                    lsvEmployees.View = View.LargeIcon;
                    break;
                case 2:
                    lsvEmployees.View = View.SmallIcon;
                    break;
                case 3:
                    lsvEmployees.View = View.Tile;
                    break;
                case 4:
                    lsvEmployees.View = View.List;
                    break;
            }
        }
    }

    internal static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics g, Brush brush, Rectangle bounds, int cornerRadius)
        {
            using GraphicsPath path = new();
            path.AddArc(bounds.X, bounds.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(bounds.Right - 2 * cornerRadius, bounds.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(bounds.Right - 2 * cornerRadius, bounds.Bottom - 2 * cornerRadius, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - 2 * cornerRadius, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.CloseFigure();
            g.FillPath(brush, path);
        }
    }
}
