namespace bai5._1
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            grpAccount = new GroupBox();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            grpPersonal = new GroupBox();
            chkTerms = new CheckBox();
            pnlGender = new Panel();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            lblGender = new Label();
            dtpBirthDate = new DateTimePicker();
            lblBirthDate = new Label();
            pnlActions = new Panel();
            btnReset = new Button();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            pnlHeader.SuspendLayout();
            grpAccount.SuspendLayout();
            grpPersonal.SuspendLayout();
            pnlGender.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // epCheck
            // 
            epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            epCheck.ContainerControl = this;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 119, 242);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(604, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN MỚI";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(225, 235, 255);
            lblSubtitle.Location = new Point(22, 43);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(390, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Vui lòng nhập đầy đủ và chính xác thông tin để kích hoạt tài khoản hệ thống";
            // 
            // grpAccount
            // 
            grpAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAccount.Controls.Add(txtConfirmPassword);
            grpAccount.Controls.Add(lblConfirmPassword);
            grpAccount.Controls.Add(txtPassword);
            grpAccount.Controls.Add(lblPassword);
            grpAccount.Controls.Add(txtUsername);
            grpAccount.Controls.Add(lblUsername);
            grpAccount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpAccount.ForeColor = Color.FromArgb(30, 41, 59);
            grpAccount.Location = new Point(20, 88);
            grpAccount.Name = "grpAccount";
            grpAccount.Size = new Size(564, 155);
            grpAccount.TabIndex = 1;
            grpAccount.TabStop = false;
            grpAccount.Text = "Thông tin tài khoản đăng nhập";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Font = new Font("Segoe UI", 9.5F);
            txtConfirmPassword.Location = new Point(170, 108);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(350, 24);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F);
            lblConfirmPassword.Location = new Point(25, 112);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(112, 15);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Segoe UI", 9.5F);
            txtPassword.Location = new Point(170, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(350, 24);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.Location = new Point(25, 73);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Font = new Font("Segoe UI", 9.5F);
            txtUsername.Location = new Point(170, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 24);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.Location = new Point(25, 34);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // grpPersonal
            // 
            grpPersonal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpPersonal.Controls.Add(chkTerms);
            grpPersonal.Controls.Add(pnlGender);
            grpPersonal.Controls.Add(lblGender);
            grpPersonal.Controls.Add(dtpBirthDate);
            grpPersonal.Controls.Add(lblBirthDate);
            grpPersonal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpPersonal.ForeColor = Color.FromArgb(30, 41, 59);
            grpPersonal.Location = new Point(20, 255);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Size = new Size(564, 180);
            grpPersonal.TabIndex = 2;
            grpPersonal.TabStop = false;
            grpPersonal.Text = "Thông tin cá nhân & Xác nhận";
            // 
            // chkTerms
            // 
            chkTerms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chkTerms.AutoSize = true;
            chkTerms.Font = new Font("Segoe UI", 9.5F);
            chkTerms.Location = new Point(28, 135);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(346, 21);
            chkTerms.TabIndex = 4;
            chkTerms.Text = "Tôi đồng ý với các điều khoản dịch vụ và chính sách bảo mật";
            chkTerms.UseVisualStyleBackColor = true;
            // 
            // pnlGender
            // 
            pnlGender.Controls.Add(rdoFemale);
            pnlGender.Controls.Add(rdoMale);
            pnlGender.Location = new Point(170, 80);
            pnlGender.Name = "pnlGender";
            pnlGender.Size = new Size(260, 32);
            pnlGender.TabIndex = 3;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Segoe UI", 9.5F);
            rdoFemale.Location = new Point(110, 5);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(43, 21);
            rdoFemale.TabIndex = 1;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Font = new Font("Segoe UI", 9.5F);
            rdoMale.Location = new Point(10, 5);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(54, 21);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F);
            lblGender.Location = new Point(25, 87);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(55, 15);
            lblGender.TabIndex = 2;
            lblGender.Text = "Giới tính:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Font = new Font("Segoe UI", 9.5F);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(170, 34);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 24);
            dtpBirthDate.TabIndex = 1;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9F);
            lblBirthDate.Location = new Point(25, 38);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(63, 15);
            lblBirthDate.TabIndex = 0;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnReset);
            pnlActions.Controls.Add(btnRegister);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(0, 460);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(604, 60);
            pnlActions.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReset.BackColor = Color.FromArgb(241, 245, 249);
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9.5F);
            btnReset.ForeColor = Color.FromArgb(51, 65, 85);
            btnReset.Location = new Point(340, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 36);
            btnReset.TabIndex = 1;
            btnReset.Text = "Làm Mới";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(24, 119, 242);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(464, 12);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 36);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(604, 520);
            Controls.Add(pnlActions);
            Controls.Add(grpPersonal);
            Controls.Add(grpAccount);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5.1 - Đăng Ký Tài Khoản & Bắt Lỗi Giao Diện";
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpAccount.ResumeLayout(false);
            grpAccount.PerformLayout();
            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            pnlGender.ResumeLayout(false);
            pnlGender.PerformLayout();
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ErrorProvider epCheck;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private GroupBox grpAccount;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private GroupBox grpPersonal;
        private CheckBox chkTerms;
        private Panel pnlGender;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label lblGender;
        private DateTimePicker dtpBirthDate;
        private Label lblBirthDate;
        private Panel pnlActions;
        private Button btnReset;
        private Button btnRegister;
    }
}
