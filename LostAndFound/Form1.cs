
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

            SetActiveButton(btnDashboard);
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

        // Select only one navigation button at a time
        private void SetActiveButton(Button activeButton)
        {
            btnDashboard.BackColor = Color.FromArgb(125, 29, 29);
            btnDashboard.ForeColor = Color.White;

            btnReportLost.BackColor = Color.FromArgb(125, 29, 29);
            btnReportLost.ForeColor = Color.White;

            btnPostFound.BackColor = Color.FromArgb(125, 29, 29);
            btnPostFound.ForeColor = Color.White;

            btnSearchMatch.BackColor = Color.FromArgb(125, 29, 29);
            btnSearchMatch.ForeColor = Color.White;

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

        // Smooth rounded button edges
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

            int scale = 4;

            using (Bitmap bitmap = new Bitmap(
                button.Width * scale,
                button.Height * scale))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        int width = button.Width * scale;
                        int height = button.Height * scale;
                        int diameter = radius * 2 * scale;

                        path.AddArc(0, 0, diameter, diameter, 180, 90);
                        path.AddArc(width - diameter, 0,
                            diameter, diameter, 270, 90);
                        path.AddArc(width - diameter, height - diameter,
                            diameter, diameter, 0, 90);
                        path.AddArc(0, height - diameter,
                            diameter, diameter, 90, 90);

                        path.CloseFigure();

                        graphics.FillPath(Brushes.Black, path);
                    }
                }

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
        }
    }
}
