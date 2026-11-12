using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace bai5._3
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Product> originalList = new();
        private readonly BindingList<Product> filteredList = new();
        private readonly BindingSource bindingSource = new();

        public Form1()
        {
            InitializeComponent();
            InitCategories();
            InitDataBinding();
            LoadSampleData();
            ResetInputFields();
        }

        private void InitCategories()
        {
            cboCategory.Items.AddRange(new object[]
            {
                "Máy tính & Laptop",
                "Phụ kiện & Linh kiện",
                "Màn hình hiển thị",
                "Thiết bị âm thanh",
                "Thiết bị văn phòng"
            });
            cboCategory.SelectedIndex = 0;
        }

        private void InitDataBinding()
        {
            colPrice.DefaultCellStyle.Format = "N0";
            colPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTotal.DefaultCellStyle.Format = "N0";
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 252);
            dgvProducts.AutoGenerateColumns = false;

            bindingSource.DataSource = filteredList;
            dgvProducts.DataSource = bindingSource;
        }

        private void LoadSampleData()
        {
            var samples = new[]
            {
                new Product("SP001", "Laptop Ultrabook Pro 14 inch", 24500000, 15, "Máy tính & Laptop"),
                new Product("SP002", "Chuột không dây công thái học", 850000, 45, "Phụ kiện & Linh kiện"),
                new Product("SP003", "Bàn phím cơ Bluetooth RGB", 1850000, 30, "Phụ kiện & Linh kiện"),
                new Product("SP004", "Màn hình đồ họa 27 inch 4K", 9200000, 12, "Màn hình hiển thị"),
                new Product("SP005", "Tai nghe chụp tai chống ồn", 3450000, 25, "Thiết bị âm thanh")
            };

            foreach (var sp in samples)
            {
                originalList.Add(sp);
            }

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim();
            filteredList.Clear();

            var query = originalList.AsEnumerable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p => (p.ProductName ?? "").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            foreach (var item in query)
            {
                filteredList.Add(item);
            }

            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            lblStatusCount.Text = $"Số lượng sản phẩm: {filteredList.Count} / {originalList.Count}";
            decimal totalVal = filteredList.Sum(p => p.TotalAmount);
            lblStatusTotalValue.Text = $"Tổng giá trị tồn kho: {totalVal:N0} đ";
        }

        private bool ValidateInput(Product? currentItem = null)
        {
            epCheck.Clear();
            bool isValid = true;

            // 1. Mã sản phẩm
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                epCheck.SetError(txtProductId, "Mã sản phẩm không được để trống!");
                isValid = false;
            }
            else
            {
                string id = txtProductId.Text.Trim();
                if (originalList.Any(p => p.ProductId.Equals(id, StringComparison.OrdinalIgnoreCase) && p != currentItem))
                {
                    epCheck.SetError(txtProductId, "Mã sản phẩm đã tồn tại trong hệ thống!");
                    isValid = false;
                }
            }

            // 2. Tên sản phẩm
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                epCheck.SetError(txtProductName, "Tên sản phẩm không được để trống!");
                isValid = false;
            }

            // 3. Đơn giá
            if (nudUnitPrice.Value <= 0)
            {
                epCheck.SetError(nudUnitPrice, "Đơn giá phải lớn hơn 0 VND!");
                isValid = false;
            }

            // 4. Số lượng
            if (nudQuantity.Value < 0)
            {
                epCheck.SetError(nudQuantity, "Số lượng không được âm!");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(
                    "Dữ liệu nhập vào chưa hợp lệ! Vui lòng kiểm tra lại các trường có biểu tượng cảnh báo màu đỏ.",
                    "Lỗi xác thực dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string id = txtProductId.Text.Trim();
            string name = txtProductName.Text.Trim();
            decimal price = nudUnitPrice.Value;
            int qty = (int)nudQuantity.Value;
            string cat = cboCategory.SelectedItem?.ToString() ?? "Khác";

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn thêm sản phẩm mới sau vào danh mục không?\n\n• Mã SP: {id}\n• Tên SP: {name}\n• Đơn giá: {price:N0} đ\n• Số lượng: {qty}",
                "Xác nhận thêm sản phẩm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var newProduct = new Product(id, name, price, qty, cat);
            originalList.Add(newProduct);
            ApplyFilter();
            ResetInputFields();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selected)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(selected)) return;

            string name = txtProductName.Text.Trim();
            decimal price = nudUnitPrice.Value;
            int qty = (int)nudQuantity.Value;
            string cat = cboCategory.SelectedItem?.ToString() ?? "Khác";

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn cập nhật thông tin sản phẩm [{selected.ProductId}] không?\n\n• Tên: {name}\n• Đơn giá mới: {price:N0} đ\n• Số lượng: {qty}",
                "Xác nhận cập nhật sản phẩm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            selected.ProductName = name;
            selected.UnitPrice = price;
            selected.Quantity = qty;
            selected.Category = cat;

            UpdateStatusStrip();
            dgvProducts.Refresh();
            MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selected)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm [{selected.ProductId}] - {selected.ProductName} ra khỏi danh mục không?\n\nHành động này không thể hoàn tác!",
                "Xác nhận xóa sản phẩm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            originalList.Remove(selected);
            ApplyFilter();
            ResetInputFields();
            MessageBox.Show("Đã xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetInputFields();
        }

        private void ResetInputFields()
        {
            epCheck.Clear();
            txtProductId.Clear();
            txtProductName.Clear();
            nudUnitPrice.Value = 100000;
            nudQuantity.Value = 1;
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            txtProductId.Enabled = true;
            txtProductId.Focus();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindCurrentRowToFields();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            BindCurrentRowToFields();
        }

        private void BindCurrentRowToFields()
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product p)
            {
                epCheck.Clear();
                txtProductId.Text = p.ProductId;
                txtProductName.Text = p.ProductName;
                nudUnitPrice.Value = p.UnitPrice;
                nudQuantity.Value = p.Quantity;
                cboCategory.SelectedItem = p.Category;
                txtProductId.Enabled = false; // Khi xem/sửa thì khóa mã
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ApplyFilter();
        }
    }
}
