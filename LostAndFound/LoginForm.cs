
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LostAndFound
{
    public partial class LoginForm : Form
    {
        private RoundedRoleDropdown roleDropdown;

        public LoginForm()
        {
            InitializeComponent();

            // Hide the original ComboBox and border panel
            cmbRole.Visible = false;
            pnlRoleBorder.Visible = false;

            // Create custom HTML-style dropdown
            roleDropdown = new RoundedRoleDropdown();

            roleDropdown.Parent = pnlLogin;
            roleDropdown.Location = new Point(36, 225);
            roleDropdown.Size = new Size(308, 38);
            roleDropdown.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            roleDropdown.BringToFront();
        }
    }

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

            // Outer border
            Panel borderPanel = new Panel();
            borderPanel.Dock = DockStyle.Fill;
            borderPanel.BackColor = Color.FromArgb(228, 220, 220);
            borderPanel.Padding = new Padding(1);

            // Options container
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
                path.AddArc(
                    rect.Right - d, rect.Bottom - d,
                    d, d, 0, 90
                );
                path.AddArc(
                    rect.X, rect.Bottom - d,
                    d, d, 90, 90
                );

                path.CloseFigure();

                e.Graphics.FillPath(background, path);
                e.Graphics.DrawPath(border, path);

                e.Graphics.DrawString(
                    selectedRole,
                    Font,
                    textBrush,
                    new PointF(
                        12,
                        (Height - Font.Height) / 2f
                    )
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
