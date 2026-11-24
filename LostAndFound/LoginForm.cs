
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LostAndFound
{
    public partial class LoginForm : Form
    {
        // DASHBOARD TITLE BAR COLOR
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int attribute,
            ref int value,
            int size);

        private void SetTitleBarColor()
        {
            int color = ColorTranslator.ToWin32(
                Color.FromArgb(165, 42, 42));

            DwmSetWindowAttribute(
                this.Handle, 35, ref color, sizeof(int));
        }

        // CONFIRM PASSWORD TEXTBOX AND BORDER
        private RoundedTextBoxBorder confirmPasswordBorder;
        private TextBox txtConfirmPassword;

        // REGISTER PASSWORD TEXTBOX AND BORDER
        private RoundedTextBoxBorder regPasswordBorder;
        private TextBox txtRegPassword;

        // EMAIL TEXTBOX AND BORDER
        private RoundedTextBoxBorder emailBorder;
        private TextBox txtEmail;

        // CONTACT NUMBER TEXTBOX AND BORDER
        private RoundedTextBoxBorder contactNumberBorder;
        private TextBox txtContactNumber;

        // COURSE TEXTBOX AND BORDER
        private RoundedTextBoxBorder courseBorder;
        private TextBox txtCourse;

        // REGISTRATION ID TEXTBOX AND BORDER
        private RoundedTextBoxBorder regIDBorder;

        // FULL NAME TEXTBOX AND BORDER
        private RoundedTextBoxBorder fullNameBorder;
        private TextBox txtFullName;

        // CUSTOM DROPDOWNS
        private RoundedRoleDropdown roleDropdown;
        private RoundedRoleDropdown registerRoleDropdown;

        // ROUNDED TEXTBOX BORDERS
        private RoundedTextBoxBorder idBorder;
        private RoundedTextBoxBorder passwordBorder;

        public LoginForm()
        {
            InitializeComponent();

            // MATCH DASHBOARD TITLE BAR COLOR
            SetTitleBarColor();

            // LOGIN AND REGISTER PANEL VISIBILITY
            pnlLogin.Visible = true;
            pnlRegister.Visible = false;

            pnlRegister.Location = pnlLogin.Location;
            pnlRegister.Size = pnlLogin.Size;
            pnlRegister.AutoScroll = false;

            // REGISTER AND SIGN IN LINK CLICK EVENTS
            lnkRegister.Click += lnkRegister_Click;
            lnkSignIn.Click += lnkSignIn_Click;

            // COMPACT REGISTRATION LABEL POSITIONS
            lblRegisterTitle.Location = new Point(36, 15);
            lblRegRole.Location = new Point(36, 55);
            lblRegID.Location = new Point(36, 120);
            lblFullName.Location = new Point(36, 180);
            lblCourse.Location = new Point(36, 240);
            lblContactNumber.Location = new Point(36, 300);
            lblEmail.Location = new Point(36, 360);
            lblRegPassword.Location = new Point(36, 420);
            lblConfirmPassword.Location = new Point(36, 480);

            // HIDE ORIGINAL LOGIN ROLE COMBOBOX
            cmbRole.Visible = false;
            pnlRoleBorder.Visible = false;

            // CUSTOM LOGIN ROLE DROPDOWN
            roleDropdown = new RoundedRoleDropdown();
            roleDropdown.Parent = pnlLogin;
            roleDropdown.Location = new Point(36, 225);
            roleDropdown.Size = new Size(308, 38);
            roleDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            roleDropdown.BringToFront();

            // CUSTOM REGISTER ROLE DROPDOWN
            registerRoleDropdown = new RoundedRoleDropdown();
            registerRoleDropdown.Parent = pnlRegister;
            registerRoleDropdown.Location = new Point(36, 75);
            registerRoleDropdown.Size = new Size(308, 38);
            registerRoleDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            registerRoleDropdown.BringToFront();

            registerRoleDropdown.SelectedRoleChanged += RegisterRoleDropdown_SelectedRoleChanged;

            cmbRegRole.Visible = false;

            // REGISTRATION ID NUMBER BORDER
            regIDBorder = new RoundedTextBoxBorder();
            regIDBorder.Parent = pnlRegister;
            regIDBorder.Location = new Point(36, 140);
            regIDBorder.Size = new Size(308, 38);
            regIDBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // REGISTRATION ID NUMBER TEXTBOX
            txtRegID = new TextBox();
            txtRegID.Parent = regIDBorder;
            txtRegID.Location = new Point(8, 5);
            txtRegID.Size = new Size(292, 28);
            txtRegID.BorderStyle = BorderStyle.None;
            txtRegID.BackColor = Color.FromArgb(255, 255, 255);
            txtRegID.ForeColor = Color.FromArgb(35, 35, 35);
            txtRegID.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtRegID.TextAlign = HorizontalAlignment.Left;

            regIDBorder.BringToFront();

            // FULL NAME TEXTBOX BORDER
            fullNameBorder = new RoundedTextBoxBorder();
            fullNameBorder.Parent = pnlRegister;
            fullNameBorder.Location = new Point(36, 200);
            fullNameBorder.Size = new Size(308, 38);
            fullNameBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // FULL NAME TEXTBOX
            txtFullName = new TextBox();
            txtFullName.Parent = fullNameBorder;
            txtFullName.Location = new Point(8, 5);
            txtFullName.Size = new Size(292, 28);
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.BackColor = Color.FromArgb(255, 255, 255);
            txtFullName.ForeColor = Color.FromArgb(35, 35, 35);
            txtFullName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtFullName.TextAlign = HorizontalAlignment.Left;

            fullNameBorder.BringToFront();

            // COURSE TEXTBOX
            courseBorder = new RoundedTextBoxBorder();
            courseBorder.Parent = pnlRegister;
            courseBorder.Location = new Point(36, 260);
            courseBorder.Size = new Size(308, 38);
            courseBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            txtCourse = new TextBox();
            txtCourse.Parent = courseBorder;
            txtCourse.Location = new Point(8, 5);
            txtCourse.Size = new Size(292, 28);
            txtCourse.BorderStyle = BorderStyle.None;
            txtCourse.BackColor = Color.FromArgb(255, 255, 255);
            txtCourse.ForeColor = Color.FromArgb(35, 35, 35);
            txtCourse.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtCourse.TextAlign = HorizontalAlignment.Left;

            courseBorder.BringToFront();

            // CONTACT NUMBER TEXTBOX
            contactNumberBorder = new RoundedTextBoxBorder();
            contactNumberBorder.Parent = pnlRegister;
            contactNumberBorder.Location = new Point(36, 320);
            contactNumberBorder.Size = new Size(308, 38);
            contactNumberBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            txtContactNumber = new TextBox();
            txtContactNumber.Parent = contactNumberBorder;
            txtContactNumber.Location = new Point(8, 5);
            txtContactNumber.Size = new Size(292, 28);
            txtContactNumber.BorderStyle = BorderStyle.None;
            txtContactNumber.BackColor = Color.FromArgb(255, 255, 255);
            txtContactNumber.ForeColor = Color.FromArgb(35, 35, 35);
            txtContactNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtContactNumber.TextAlign = HorizontalAlignment.Left;

            contactNumberBorder.BringToFront();

            // EMAIL TEXTBOX
            emailBorder = new RoundedTextBoxBorder();
            emailBorder.Parent = pnlRegister;
            emailBorder.Location = new Point(36, 380);
            emailBorder.Size = new Size(308, 38);
            emailBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            txtEmail = new TextBox();
            txtEmail.Parent = emailBorder;
            txtEmail.Location = new Point(8, 5);
            txtEmail.Size = new Size(292, 28);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.BackColor = Color.FromArgb(255, 255, 255);
            txtEmail.ForeColor = Color.FromArgb(35, 35, 35);
            txtEmail.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtEmail.TextAlign = HorizontalAlignment.Left;

            emailBorder.BringToFront();

            // REGISTER PASSWORD TEXTBOX
            regPasswordBorder = new RoundedTextBoxBorder();
            regPasswordBorder.Parent = pnlRegister;
            regPasswordBorder.Location = new Point(36, 440);
            regPasswordBorder.Size = new Size(308, 38);
            regPasswordBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            txtRegPassword = new TextBox();
            txtRegPassword.Parent = regPasswordBorder;
            txtRegPassword.Location = new Point(8, 5);
            txtRegPassword.Size = new Size(292, 28);
            txtRegPassword.BorderStyle = BorderStyle.None;
            txtRegPassword.BackColor = Color.FromArgb(255, 255, 255);
            txtRegPassword.ForeColor = Color.FromArgb(35, 35, 35);
            txtRegPassword.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtRegPassword.TextAlign = HorizontalAlignment.Left;
            txtRegPassword.UseSystemPasswordChar = true;

            regPasswordBorder.BringToFront();

            // CONFIRM PASSWORD TEXTBOX
            confirmPasswordBorder = new RoundedTextBoxBorder();
            confirmPasswordBorder.Parent = pnlRegister;
            confirmPasswordBorder.Location = new Point(36, 500);
            confirmPasswordBorder.Size = new Size(308, 38);
            confirmPasswordBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            txtConfirmPassword = new TextBox();
            txtConfirmPassword.Parent = confirmPasswordBorder;
            txtConfirmPassword.Location = new Point(8, 5);
            txtConfirmPassword.Size = new Size(292, 28);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.BackColor = Color.FromArgb(255, 255, 255);
            txtConfirmPassword.ForeColor = Color.FromArgb(35, 35, 35);
            txtConfirmPassword.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtConfirmPassword.TextAlign = HorizontalAlignment.Left;
            txtConfirmPassword.UseSystemPasswordChar = true;

            confirmPasswordBorder.BringToFront();

            // REGISTER BUTTON POSITION
            btnRegister.Location = new Point(36, 550);

            // SIGN IN LINK POSITION
            lnkSignIn.Location = new Point(36, 595);

            // LOGIN ID NUMBER BORDER
            idBorder = new RoundedTextBoxBorder();
            idBorder.Parent = pnlLogin;
            idBorder.Location = new Point(36, 298);
            idBorder.Size = new Size(308, 38);
            idBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // LOGIN ID NUMBER TEXTBOX
            txtIDNumber.Parent = idBorder;
            txtIDNumber.Location = new Point(8, 5);
            txtIDNumber.Size = new Size(292, 28);
            txtIDNumber.BorderStyle = BorderStyle.None;
            txtIDNumber.BackColor = Color.FromArgb(255, 255, 255);
            txtIDNumber.ForeColor = Color.FromArgb(35, 35, 35);
            txtIDNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtIDNumber.TextAlign = HorizontalAlignment.Left;

            idBorder.BringToFront();

            // LOGIN PASSWORD LABEL
            lblPassword.Parent = pnlLogin;
            lblPassword.Text = "Password";
            lblPassword.Location = new Point(36, 345);
            lblPassword.Size = new Size(308, 20);
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(70, 70, 70);
            lblPassword.BackColor = Color.Transparent;

            // LOGIN PASSWORD BORDER
            passwordBorder = new RoundedTextBoxBorder();
            passwordBorder.Parent = pnlLogin;
            passwordBorder.Location = new Point(36, 371);
            passwordBorder.Size = new Size(308, 38);
            passwordBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // LOGIN PASSWORD TEXTBOX
            txtPassword.Parent = passwordBorder;
            txtPassword.Location = new Point(8, 5);
            txtPassword.Size = new Size(292, 28);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.BackColor = Color.FromArgb(255, 255, 255);
            txtPassword.ForeColor = Color.FromArgb(70, 70, 70);
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.UseSystemPasswordChar = true;

            passwordBorder.BringToFront();
            lblPassword.BringToFront();

            // ROUNDED LOGIN BUTTON
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(165, 42, 42);
            btnLogin.ForeColor = Color.White;
            btnLogin.Text = "Login";
            btnLogin.Cursor = Cursors.Hand;

            // ROUNDED REGISTER BUTTON
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.BackColor = Color.FromArgb(165, 42, 42);
            btnRegister.ForeColor = Color.White;
            btnRegister.Text = "Register";
            btnRegister.Cursor = Cursors.Hand;

            // APPLY ROUNDED EDGES
            MakeLoginButtonRounded();

            btnLogin.Resize += (s, e) => MakeLoginButtonRounded();
            btnRegister.Resize += (s, e) => MakeLoginButtonRounded();
        }

        // REGISTER LINK CLICK METHOD
        private void lnkRegister_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
            pnlRegister.BringToFront();
        }

        // SIGN IN LINK CLICK METHOD
        private void lnkSignIn_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();
        }

        // CHANGE REGISTRATION LABELS BASED ON ROLE
        private void RegisterRoleDropdown_SelectedRoleChanged(object sender, EventArgs e)
        {
            if (registerRoleDropdown.SelectedRole == "Student")
            {
                lblRegID.Text = "Student ID";
                lblCourse.Text = "Course";
            }
            else if (registerRoleDropdown.SelectedRole == "Professor")
            {
                lblRegID.Text = "Employee ID";
                lblCourse.Text = "Department";
            }
            else if (registerRoleDropdown.SelectedRole == "Guard")
            {
                lblRegID.Text = "Employee ID";
                lblCourse.Text = "Post Location";
            }
        }

        // MAKE LOGIN AND REGISTER BUTTONS ROUNDED
        private void MakeLoginButtonRounded()
        {
            if (btnLogin.Width > 0 && btnLogin.Height > 0)
            {
                using (GraphicsPath loginPath = new GraphicsPath())
                {
                    int radius = 9;
                    int diameter = radius * 2;

                    loginPath.AddArc(0, 0, diameter, diameter, 180, 90);
                    loginPath.AddArc(btnLogin.Width - diameter, 0, diameter, diameter, 270, 90);
                    loginPath.AddArc(btnLogin.Width - diameter, btnLogin.Height - diameter, diameter, diameter, 0, 90);
                    loginPath.AddArc(0, btnLogin.Height - diameter, diameter, diameter, 90, 90);

                    loginPath.CloseFigure();

                    Region oldLoginRegion = btnLogin.Region;
                    btnLogin.Region = new Region(loginPath);
                    oldLoginRegion?.Dispose();
                }
            }

            if (btnRegister.Width > 0 && btnRegister.Height > 0)
            {
                using (GraphicsPath registerPath = new GraphicsPath())
                {
                    int radius = 9;
                    int diameter = radius * 2;

                    registerPath.AddArc(0, 0, diameter, diameter, 180, 90);
                    registerPath.AddArc(btnRegister.Width - diameter, 0, diameter, diameter, 270, 90);
                    registerPath.AddArc(btnRegister.Width - diameter, btnRegister.Height - diameter, diameter, diameter, 0, 90);
                    registerPath.AddArc(0, btnRegister.Height - diameter, diameter, diameter, 90, 90);

                    registerPath.CloseFigure();

                    Region oldRegisterRegion = btnRegister.Region;
                    btnRegister.Region = new Region(registerPath);
                    oldRegisterRegion?.Dispose();
                }
            }
        }

        // EXISTING EMPTY EVENTS
        private void lblWelcomeTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
        }
    }

    // ROUNDED TEXTBOX BORDER CLASS
    public class RoundedTextBoxBorder : Panel
    {
        public RoundedTextBoxBorder()
        {
            BackColor = Color.White;
            BorderStyle = BorderStyle.None;

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0, 0, Width - 1, Height - 1
            );

            using (GraphicsPath path = new GraphicsPath())
            using (Pen borderPen = new Pen(
                Color.FromArgb(228, 220, 220), 1.3f))
            {
                int radius = 9;
                int diameter = radius * 2;

                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

                path.CloseFigure();
                e.Graphics.DrawPath(borderPen, path);
            }
        }
    }

    // CUSTOM ROUNDED ROLE DROPDOWN CLASS
    public class RoundedRoleDropdown : Control
    {
        private string selectedRole = "Student";

        private string[] roles =
        {
            "Student",
            "Professor",
            "Guard"
        };

        private Form popup;
        private FlowLayoutPanel optionsPanel;

        public string SelectedRole
        {
            get { return selectedRole; }
        }

        public event EventHandler SelectedRoleChanged;

        public RoundedRoleDropdown()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );

            Font = new Font("Segoe UI", 9F);
            BackColor = Color.White;
            ForeColor = Color.FromArgb(50, 50, 50);
            Cursor = Cursors.Hand;

            Click += (s, e) => TogglePopup();
        }

        private void TogglePopup()
        {
            if (popup != null && !popup.IsDisposed)
            {
                popup.Close();
                return;
            }

            popup = new Form();

            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.Manual;
            popup.ShowInTaskbar = false;
            popup.BackColor = Color.FromArgb(228, 220, 220);
            popup.Width = Width;
            popup.Height = roles.Length * 34 + 2;
            popup.TopMost = true;

            Point screenPosition = PointToScreen(new Point(0, Height));
            popup.Location = screenPosition;

            // OUTER BORDER
            Panel borderPanel = new Panel();
            borderPanel.Dock = DockStyle.Fill;
            borderPanel.BackColor = Color.FromArgb(228, 220, 220);
            borderPanel.Padding = new Padding(1);

            // OPTIONS CONTAINER
            optionsPanel = new FlowLayoutPanel();
            optionsPanel.Dock = DockStyle.Fill;
            optionsPanel.FlowDirection = FlowDirection.TopDown;
            optionsPanel.WrapContents = false;
            optionsPanel.Padding = Padding.Empty;
            optionsPanel.Margin = Padding.Empty;
            optionsPanel.BackColor = Color.White;

            // CREATE EACH ROLE OPTION
            foreach (string role in roles)
            {
                Button option = new Button();

                option.Text = role;
                option.Width = Width - 2;
                option.Height = 34;
                option.FlatStyle = FlatStyle.Flat;
                option.FlatAppearance.BorderSize = 0;
                option.BackColor = Color.White;
                option.ForeColor = Color.FromArgb(50, 50, 50);
                option.Font = new Font("Segoe UI", 9F);
                option.TextAlign = ContentAlignment.MiddleLeft;
                option.Padding = new Padding(12, 0, 0, 0);
                option.Margin = Padding.Empty;
                option.Cursor = Cursors.Hand;

                option.Click += (s, e) =>
                {
                    selectedRole = role;
                    Invalidate();

                    SelectedRoleChanged?.Invoke(this, EventArgs.Empty);

                    popup.Close();
                };

                option.MouseEnter += (s, e) =>
                {
                    option.BackColor = Color.FromArgb(246, 233, 233);
                };

                option.MouseLeave += (s, e) =>
                {
                    option.BackColor = Color.White;
                };

                optionsPanel.Controls.Add(option);
            }

            borderPanel.Controls.Add(optionsPanel);
            popup.Controls.Add(borderPanel);

            popup.Deactivate += (s, e) =>
            {
                if (!popup.IsDisposed)
                    popup.Close();
            };

            popup.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                0, 0, Width - 1, Height - 1
            );

            using (GraphicsPath path = new GraphicsPath())
            using (SolidBrush background = new SolidBrush(Color.White))
            using (Pen border = new Pen(Color.FromArgb(228, 220, 220), 1.3f))
            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(50, 50, 50)))
            using (Pen arrowPen = new Pen(Color.FromArgb(50, 50, 50), 1.8f))
            {
                int radius = 9;
                int d = radius * 2;

                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

                path.CloseFigure();

                e.Graphics.FillPath(background, path);
                e.Graphics.DrawPath(border, path);

                e.Graphics.DrawString(
                    selectedRole,
                    Font,
                    textBrush,
                    new PointF(12, (Height - Font.Height) / 2f)
                );

                float centerX = Width - 22;
                float centerY = Height / 2f;

                e.Graphics.DrawLine(
                    arrowPen,
                    centerX - 5, centerY - 2,
                    centerX, centerY + 3
                );

                e.Graphics.DrawLine(
                    arrowPen,
                    centerX, centerY + 3,
                    centerX + 5, centerY - 2
                );
            }
        }
    }
}
