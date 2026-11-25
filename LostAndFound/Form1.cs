
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
        // Allows Windows to customize the title bar color.
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int attribute,
            ref int value,
            int size);

        // Sets the title bar to the primary burgundy color.
        private void SetTitleBarColor()
        {
            int color = ColorTranslator.ToWin32(
                Color.FromArgb(165, 42, 42));

            DwmSetWindowAttribute(
                this.Handle, 35, ref color, sizeof(int));
        }

        // Initializes the form and applies the visual styles.
        public Form1()
        {
            InitializeComponent();

            SetTitleBarColor();

            // Applies styling to all four dashboard cards.
            StyleTotalItemsPanel();
            StyleOpenPanel();
            StyleMatchedPanel();
            StyleClaimedPanel();

            // Makes the dashboard header divider match the card outlines.
            StyleHeaderLine();

            // Rounds the navigation buttons.
            RoundButton(btnDashboard, 8);
            RoundButton(btnReportLost, 8);
            RoundButton(btnPostFound, 8);
            RoundButton(btnSearchMatch, 8);
            RoundButton(btnClaimReturn, 8);

            // Rounds the logout button.
            RoundButton(btnLogout, 8);

            // Sets Dashboard as the default active button.
            SetActiveButton(btnDashboard);

            // Connects navigation button click events.
            btnDashboard.Click += btnDashboard_Click;
            btnReportLost.Click += btnReportLost_Click;
            btnPostFound.Click += btnPostFound_Click;
            btnSearchMatch.Click += btnSearchMatch_Click;
            btnClaimReturn.Click += btnClaimReturn_Click;
        }

        // Styles the Total Items card.
        private void StyleTotalItemsPanel()
        {
            StyleRoundedPanel(pnlTotalItems);
        }

        // Styles the Open card.
        private void StyleOpenPanel()
        {
            StyleRoundedPanel(pnlOpen);
        }

        // Styles the Matched card.
        private void StyleMatchedPanel()
        {
            StyleRoundedPanel(pnlMatched);
        }

        // Styles the Claimed card.
        private void StyleClaimedPanel()
        {
            StyleRoundedPanel(pnlClaimed);
        }

        // Applies rounded corners, a light border, and a subtle shadow.
        private void StyleRoundedPanel(Panel panel)
        {
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.None;

            // Draws a subtle shadow behind the card.
            panel.Parent.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle shadowBounds = new Rectangle(
                    panel.Left,
                    panel.Top + 2,
                    panel.Width,
                    panel.Height
                );

                using (GraphicsPath shadowPath =
                    CreateRoundedPath(shadowBounds, 10))
                {
                    // Soft outer shadow.
                    using (Pen shadow = new Pen(
                        Color.FromArgb(4, 80, 20, 20), 6))
                    {
                        e.Graphics.DrawPath(shadow, shadowPath);
                    }

                    using (Pen shadow = new Pen(
                        Color.FromArgb(6, 80, 20, 20), 4))
                    {
                        e.Graphics.DrawPath(shadow, shadowPath);
                    }

                    using (Pen shadow = new Pen(
                        Color.FromArgb(8, 80, 20, 20), 2))
                    {
                        e.Graphics.DrawPath(shadow, shadowPath);
                    }
                }
            };

            // Draws the card outline using the shared HTML border color.
            panel.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle bounds = new Rectangle(
                    0, 0, panel.Width - 1, panel.Height - 1);

                using (GraphicsPath path = CreateRoundedPath(bounds, 10))
                using (Pen border = new Pen(
                    Color.FromArgb(228, 220, 220), 1))
                {
                    e.Graphics.DrawPath(border, path);
                }
            };

            // Updates the card shape and shadow when resized.
            panel.Resize += (sender, e) =>
            {
                ApplyRoundedPanelRegion(panel, 10);
                panel.Parent.Invalidate();
                panel.Invalidate();
            };

            // Applies the rounded shape when initialized.
            ApplyRoundedPanelRegion(panel, 10);
            panel.Parent.Invalidate();
            panel.Invalidate();
        }

        // Styles the dashboard header divider.
        // Uses exactly the same color as the four card outlines.
        private void StyleHeaderLine()
        {
            pnlHeaderLine.BackColor = Color.FromArgb(228, 220, 220);
            pnlHeaderLine.BorderStyle = BorderStyle.None;
            pnlHeaderLine.Visible = true;
            pnlHeaderLine.BringToFront();
        }

        // Creates a rounded rectangle path for cards and shadows.
        private GraphicsPath CreateRoundedPath(
            Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(
                bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);

            path.CloseFigure();

            return path;
        }

        // Applies rounded corners to the actual panel boundaries.
        private void ApplyRoundedPanelRegion(Panel panel, int radius)
        {
            if (panel.Width <= 0 || panel.Height <= 0)
                return;

            int w = panel.Width;
            int h = panel.Height;
            int d = radius * 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(w - d, 0, d, d, 270, 90);
                path.AddArc(
                    w - d, h - d, d, d, 0, 90);
                path.AddArc(0, h - d, d, d, 90, 90);

                path.CloseFigure();

                panel.Region?.Dispose();
                panel.Region = new Region(path);
            }
        }

        // Form load event.
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Empty Designer event handlers retained from your original code.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
        }

        // Resets navigation buttons and highlights the selected button.
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

            // Gives the selected button a white background and dark red text.
            activeButton.BackColor = Color.White;
            activeButton.ForeColor = Color.FromArgb(125, 29, 29);
        }

        // Dashboard navigation.
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
        }

        // Report Lost navigation.
        private void btnReportLost_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReportLost);
        }

        // Post Found navigation.
        private void btnPostFound_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPostFound);
        }

        // Search and Match navigation.
        private void btnSearchMatch_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSearchMatch);
        }

        // Claim and Return navigation.
        private void btnClaimReturn_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnClaimReturn);
        }

        // Applies flat styling and rounded corners to buttons.
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

        // Creates and applies the rounded shape of a button.
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
            regionPath.AddArc(
                w - d, h - d, d, d, 0, 90);
            regionPath.AddArc(0, h - d, d, d, 90, 90);

            regionPath.CloseFigure();

            button.Region?.Dispose();
            button.Region = new Region(regionPath);

            regionPath.Dispose();
        }

        // Original Designer event handlers.
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

        private void lblTotalItemsTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblTotalItemsCount_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlDivider_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblBrand_Click(object sender, EventArgs e)
        {
        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblUserRole_Click_1(object sender, EventArgs e)
        {
        }

        private void pnlFooterLine_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlOpen_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblDashboardTitle_Click(object sender, EventArgs e)
        {
        }

        private void lblDashboardSubtitle_Click(object sender, EventArgs e)
        {
        }

        private void pnlTotalItems_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblOpenCount_Click(object sender, EventArgs e)
        {
        }

        private void lblOpenTitle_Click(object sender, EventArgs e)
        {
        }

        private void pnlMatched_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblMatchedCount_Click(object sender, EventArgs e)
        {
        }

        private void pnlClaimed_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
        }

        private void lblClaimedTitle_Click(object sender, EventArgs e)
        {
        }

        private void pnlHeaderLine_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
