
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace LostAndFound
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();

            SetTitleBarColor();

            // Rounded navigation buttons
            RoundButton(btnDashboard, 8);
            RoundButton(btnReportLost, 8);
            RoundButton(btnPostFound, 8);
            RoundButton(btnSearchMatch, 8);
            RoundButton(btnClaimReturn, 8);

            // Rounded logout button
            RoundButton(btnLogout, 8);

            // Default active button
            SetActiveButton(btnDashboard);

            // Connect click events
            btnDashboard.Click += btnDashboard_Click;
            btnReportLost.Click += btnReportLost_Click;
            btnPostFound.Click += btnPostFound_Click;
            btnSearchMatch.Click += btnSearchMatch_Click;
            btnClaimReturn.Click += btnClaimReturn_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
        }

        // Reset all navigation buttons and highlight selected button
        private void SetActiveButton(Button activeButton)
        {
            Button[] buttons =
            {
                btnDashboard,
                btnReportLost,
                btnPostFound,
                btnSearchMatch,
                btnClaimReturn
            };

            foreach (Button button in buttons)
            {
                button.BackColor = Color.FromArgb(125, 29, 29);
                button.ForeColor = Color.White;
            }

            activeButton.BackColor = Color.White;
            activeButton.ForeColor = Color.FromArgb(125, 29, 29);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
        }

        private void btnReportLost_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReportLost);
        }

        private void btnPostFound_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPostFound);
        }

        private void btnSearchMatch_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSearchMatch);
        }

        private void btnClaimReturn_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnClaimReturn);
        }

        // Rounded button styling
        private void RoundButton(Button button, int radius)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.UseVisualStyleBackColor = false;

            button.Resize += (sender, e) =>
            {
                ApplyRoundedRegion(button, radius);
            };

            ApplyRoundedRegion(button, radius);
        }

        private void ApplyRoundedRegion(Button button, int radius)
        {
            if (button.Width <= 0 || button.Height <= 0)
                return;

            GraphicsPath regionPath = new GraphicsPath();

            int w = button.Width;
            int h = button.Height;
            int d = radius * 2;

            regionPath.AddArc(0, 0, d, d, 180, 90);
            regionPath.AddArc(w - d, 0, d, d, 270, 90);
            regionPath.AddArc(w - d, h - d, d, d, 0, 90);
            regionPath.AddArc(0, h - d, d, d, 90, 90);

            regionPath.CloseFigure();

            button.Region?.Dispose();
            button.Region = new Region(regionPath);

            regionPath.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblUserRole_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }
    }
}
