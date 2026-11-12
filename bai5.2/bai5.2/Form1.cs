using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bai5._2
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, List<ServiceItem>> categoryData = new();

        public Form1()
        {
            InitializeComponent();
            InitServiceCatalog();
            LoadCategories();
        }

        private void InitServiceCatalog()
        {
            categoryData["Khám bệnh"] = new List<ServiceItem>
            {
                new("Khám tổng quát định kỳ", 150000),
                new("Khám chuyên khoa Nội", 200000),
                new("Khám Tai Mũi Họng", 180000),
                new("Khám Mắt chuyên sâu", 170000)
            };

            categoryData["Xét nghiệm"] = new List<ServiceItem>
            {
                new("Xét nghiệm công thức máu 24 chỉ số", 120000),
                new("Xét nghiệm đường huyết lúc đói", 80000),
                new("Xét nghiệm chức năng men gan (AST, ALT)", 150000),
                new("Xét nghiệm bộ mỡ máu (Lipid toàn phần)", 160000)
            };

            categoryData["Chụp X-Quang"] = new List<ServiceItem>
            {
                new("Chụp X-Quang tim phổi thẳng", 150000),
                new("Chụp X-Quang cột sống cổ (2 tư thế)", 220000),
                new("Chụp X-Quang xoang hàm mặt", 160000),
                new("Chụp X-Quang khớp gối tiêu chuẩn", 200000)
            };

            categoryData["Vắc-xin"] = new List<ServiceItem>
            {
                new("Tiêm vắc-xin Cúm mùa thế hệ mới", 320000),
                new("Tiêm vắc-xin Viêm gan B người lớn", 250000),
                new("Tiêm vắc-xin Uốn ván tinh chế", 180000),
                new("Tiêm vắc-xin Dại dự phòng", 400000)
            };
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            foreach (var key in categoryData.Keys)
            {
                cboCategory.Items.Add(key);
            }

            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedItem is string catName && categoryData.ContainsKey(catName))
            {
                lstAvailableServices.Items.Clear();
                foreach (var item in categoryData[catName])
                {
                    lstAvailableServices.Items.Add(item);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            AddSelectedService();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            AddSelectedService();
        }

        private void AddSelectedService()
        {
            if (lstAvailableServices.SelectedItem is ServiceItem item)
            {
                lstSelectedServices.Items.Add(item);
                RecalculateTotals();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ từ danh sách bên trái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedService();
        }

        private void lstSelectedServices_DoubleClick(object sender, EventArgs e)
        {
            RemoveSelectedService();
        }

        private void RemoveSelectedService()
        {
            if (lstSelectedServices.SelectedIndex >= 0)
            {
                lstSelectedServices.Items.RemoveAt(lstSelectedServices.SelectedIndex);
                RecalculateTotals();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa khỏi danh sách đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.Items.Count == 0) return;

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ dịch vụ đã chọn?",
                "Xác nhận thao tác",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                lstSelectedServices.Items.Clear();
                RecalculateTotals();
            }
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            RecalculateTotals();
        }

        private void RecalculateTotals()
        {
            decimal total = 0;
            foreach (var obj in lstSelectedServices.Items)
            {
                if (obj is ServiceItem s)
                {
                    total += s.Price;
                }
            }

            decimal discountRate = nudDiscount.Value;
            decimal discountAmount = total * (discountRate / 100m);
            decimal finalAmount = total - discountAmount;

            txtTotalAmount.Text = $"{total:N0} đ";
            txtFinalAmount.Text = $"{finalAmount:N0} đ";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dịch vụ trước khi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = 0;
            foreach (var obj in lstSelectedServices.Items)
            {
                if (obj is ServiceItem s) total += s.Price;
            }

            decimal discountRate = nudDiscount.Value;
            decimal discountAmount = total * (discountRate / 100m);
            decimal finalAmount = total - discountAmount;

            string detail = $"CHI TIẾT HÓA ĐƠN:\n"
                          + $"• Tổng tiền chưa giảm: {total:N0} đ\n"
                          + $"• Chiết khấu: {discountRate}% (-{discountAmount:N0} đ)\n"
                          + $"• THÀNH TIỀN: {finalAmount:N0} đ\n\n"
                          + "Bạn có đồng ý xác nhận thanh toán đơn dịch vụ này không?";

            DialogResult confirm = MessageBox.Show(
                detail,
                "Xác nhận thanh toán dịch vụ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công! Đã lưu hóa đơn vào hệ thống.", "Hoàn tất thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstSelectedServices.Items.Clear();
                nudDiscount.Value = 0;
                RecalculateTotals();
            }
        }
    }
}
