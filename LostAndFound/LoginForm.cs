
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LostAndFound
{
    public partial class LoginForm : Form
    {
        private RoundedRoleDropdown roleDropdown;
        private RoundedTextBoxBorder idBorder;
        private RoundedTextBoxBorder passwordBorder;

        public LoginForm()
        {
            InitializeComponent();

            // Hide original ComboBox and border panel
            cmbRole.Visible = false;
            pnlRoleBorder.Visible = false;

            // CUSTOM ROLE DROPDOWN
            roleDropdown = new RoundedRoleDropdown();

            roleDropdown.Parent = pnlLogin;
            roleDropdown.Location = new Point(36, 225);
            roleDropdown.Size = new Size(308, 38);
            roleDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            roleDropdown.BringToFront();

            // ID NUMBER BORDER
            idBorder = new RoundedTextBoxBorder();

            idBorder.Parent = pnlLogin;
            idBorder.Location = new Point(36, 298);
            idBorder.Size = new Size(308, 38);
            idBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // ID NUMBER TEXTBOX
            txtIDNumber.Parent = idBorder;
            txtIDNumber.Location = new Point(8, 5);
            txtIDNumber.Size = new Size(292, 28);
            txtIDNumber.BorderStyle = BorderStyle.None;
            txtIDNumber.BackColor = Color.FromArgb(255, 255, 255);
            txtIDNumber.ForeColor = Color.FromArgb(35, 35, 35);
            txtIDNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            txtIDNumber.TextAlign = HorizontalAlignment.Left;

            idBorder.BringToFront();

            // PASSWORD LABEL
            lblPassword.Parent = pnlLogin;
            lblPassword.Text = "Password";
            lblPassword.Location = new Point(36, 345);
            lblPassword.Size = new Size(308, 20);
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(70, 70, 70);
            lblPassword.BackColor = Color.Transparent;

            // PASSWORD BORDER
            passwordBorder = new RoundedTextBoxBorder();

            passwordBorder.Parent = pnlLogin;
            passwordBorder.Location = new Point(36, 371);
            passwordBorder.Size = new Size(308, 38);
            passwordBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // PASSWORD TEXTBOX
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

            MakeLoginButtonRounded();

            btnLogin.Resize += (s, e) => MakeLoginButtonRounded();
        }

        // MAKE LOGIN BUTTON ROUNDED
        private void MakeLoginButtonRounded()
        {
            if (btnLogin.Width <= 0 || btnLogin.Height <= 0)
                return;

            GraphicsPath path = new GraphicsPath();

            int radius = 9;
            int diameter = radius * 2;

            path.AddArc(0, 0, diameter, diameter, 180, 90);
            path.AddArc(
                btnLogin.Width - diameter, 0,
                diameter, diameter, 270, 90
            );
            path.AddArc(
                btnLogin.Width - diameter,
                btnLogin.Height - diameter,
                diameter, diameter, 0, 90
            );
            path.AddArc(
                0, btnLogin.Height - diameter,
                diameter, diameter, 90, 90
            );

            path.CloseFigure();

            Region oldRegion = btnLogin.Region;
            btnLogin.Region = new Region(path);

            path.Dispose();
            oldRegion?.Dispose();
        }

        private void lblWelcomeTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
        }
    }

    // ROUNDED TEXTBOX BORDER
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

    // CUSTOM ROLE DROPDOWN
    public class RoundedRoleDropdown : Control
    {
        private string selectedRole = "Student";
        private string[] roles = { "Student", "Professor", "Guard" };

        private Form popup;
        private FlowLayoutPanel optionsPanel;

        public string SelectedRole
        {
            get { return selectedRole; }
        }

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

            Point screenPosition = PointToScreen(
                new Point(0, Height)
            );

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
            using (Pen border = new Pen(
                Color.FromArgb(228, 220, 220), 1.3f))
            using (SolidBrush textBrush = new SolidBrush(
                Color.FromArgb(50, 50, 50)))
            using (Pen arrowPen = new Pen(
                Color.FromArgb(50, 50, 50), 1.8f))
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
