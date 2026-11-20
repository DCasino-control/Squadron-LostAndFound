
namespace LostAndFound
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnReportLost = new System.Windows.Forms.Button();
            this.btnSearchMatch = new System.Windows.Forms.Button();
            this.btnPostFound = new System.Windows.Forms.Button();
            this.btnClaimReturn = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlFooterLine = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlSidebar.Controls.Add(this.pnlDivider);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnPostFound);
            this.pnlSidebar.Controls.Add(this.btnReportLost);
            this.pnlSidebar.Controls.Add(this.btnSearchMatch);
            this.pnlSidebar.Controls.Add(this.btnClaimReturn);
            this.pnlSidebar.Controls.Add(this.lblSubtitle);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Controls.Add(this.pnlFooter);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(210, 661);
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(15, 115);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(180, 42);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lblSubtitle.Location = new System.Drawing.Point(15, 53);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(114, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "UM Tagum College";
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(15, 25);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(166, 30);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Lost and Found";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlFooter.Controls.Add(this.btnLogout);
            this.pnlFooter.Controls.Add(this.lblUserRole);
            this.pnlFooter.Controls.Add(this.pnlFooterLine);
            this.pnlFooter.Controls.Add(this.lblUserName);
            this.pnlFooter.Location = new System.Drawing.Point(0, 520);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(210, 180);
            this.pnlFooter.TabIndex = 7;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.pnlDivider.Location = new System.Drawing.Point(15, 95);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(180, 1);
            this.pnlDivider.TabIndex = 1;
            // 
            // btnReportLost
            // 
            this.btnReportLost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnReportLost.FlatAppearance.BorderSize = 0;
            this.btnReportLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportLost.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportLost.ForeColor = System.Drawing.Color.White;
            this.btnReportLost.Location = new System.Drawing.Point(15, 165);
            this.btnReportLost.Name = "btnReportLost";
            this.btnReportLost.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReportLost.Size = new System.Drawing.Size(180, 42);
            this.btnReportLost.TabIndex = 2;
            this.btnReportLost.Text = "Report Lost Item";
            this.btnReportLost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportLost.UseVisualStyleBackColor = false;
            this.btnReportLost.Click += new System.EventHandler(this.btnReportLost_Click);
            // 
            // btnSearchMatch
            // 
            this.btnSearchMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnSearchMatch.FlatAppearance.BorderSize = 0;
            this.btnSearchMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMatch.ForeColor = System.Drawing.Color.White;
            this.btnSearchMatch.Location = new System.Drawing.Point(15, 265);
            this.btnSearchMatch.Name = "btnSearchMatch";
            this.btnSearchMatch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearchMatch.Size = new System.Drawing.Size(180, 42);
            this.btnSearchMatch.TabIndex = 4;
            this.btnSearchMatch.Text = "Search and Match";
            this.btnSearchMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMatch.UseVisualStyleBackColor = false;
            this.btnSearchMatch.Click += new System.EventHandler(this.btnSearchMatch_Click);
            // 
            // btnPostFound
            // 
            this.btnPostFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnPostFound.FlatAppearance.BorderSize = 0;
            this.btnPostFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostFound.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostFound.ForeColor = System.Drawing.Color.White;
            this.btnPostFound.Location = new System.Drawing.Point(15, 215);
            this.btnPostFound.Name = "btnPostFound";
            this.btnPostFound.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPostFound.Size = new System.Drawing.Size(180, 42);
            this.btnPostFound.TabIndex = 5;
            this.btnPostFound.Text = "Post Found Item";
            this.btnPostFound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostFound.UseVisualStyleBackColor = false;
            this.btnPostFound.Click += new System.EventHandler(this.btnPostFound_Click);
            // 
            // btnClaimReturn
            // 
            this.btnClaimReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnClaimReturn.FlatAppearance.BorderSize = 0;
            this.btnClaimReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaimReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaimReturn.ForeColor = System.Drawing.Color.White;
            this.btnClaimReturn.Location = new System.Drawing.Point(15, 315);
            this.btnClaimReturn.Name = "btnClaimReturn";
            this.btnClaimReturn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClaimReturn.Size = new System.Drawing.Size(190, 45);
            this.btnClaimReturn.TabIndex = 6;
            this.btnClaimReturn.Text = "Claim and Return";
            this.btnClaimReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaimReturn.UseVisualStyleBackColor = false;
            this.btnClaimReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(15, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(180, 18);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Maria Santos";
            this.lblUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlFooterLine
            // 
            this.pnlFooterLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.pnlFooterLine.Location = new System.Drawing.Point(15, 3);
            this.pnlFooterLine.Name = "pnlFooterLine";
            this.pnlFooterLine.Size = new System.Drawing.Size(180, 1);
            this.pnlFooterLine.TabIndex = 1;
            // 
            // lblUserRole
            // 
            this.lblUserRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserRole.Location = new System.Drawing.Point(15, 32);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(180, 18);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "Student";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Brown;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(15, 55);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campus Lost and Found System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Button btnReportLost;
        private System.Windows.Forms.Button btnSearchMatch;
        private System.Windows.Forms.Button btnPostFound;
        private System.Windows.Forms.Button btnClaimReturn;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlFooterLine;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnLogout;
    }
}
