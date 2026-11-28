
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
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnPostFound = new System.Windows.Forms.Button();
            this.btnReportLost = new System.Windows.Forms.Button();
            this.btnSearchMatch = new System.Windows.Forms.Button();
            this.btnClaimReturn = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.pnlFooterLine = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDashboardHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.lblDashboardSubtitle = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.pnlClaimed = new System.Windows.Forms.Panel();
            this.lblClaimedTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMatched = new System.Windows.Forms.Panel();
            this.lblMatchedTitle = new System.Windows.Forms.Label();
            this.lblMatchedCount = new System.Windows.Forms.Label();
            this.pnlOpen = new System.Windows.Forms.Panel();
            this.lblOpenTitle = new System.Windows.Forms.Label();
            this.lblOpenCount = new System.Windows.Forms.Label();
            this.pnlTotalItems = new System.Windows.Forms.Panel();
            this.lblTotalItemsTitle = new System.Windows.Forms.Label();
            this.lblTotalItemsCount = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDashboardHeader.SuspendLayout();
            this.pnlClaimed.SuspendLayout();
            this.pnlMatched.SuspendLayout();
            this.pnlOpen.SuspendLayout();
            this.pnlTotalItems.SuspendLayout();
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
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.pnlDivider.Location = new System.Drawing.Point(15, 95);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(180, 1);
            this.pnlDivider.TabIndex = 1;
            this.pnlDivider.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDivider_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnPostFound
            // 
            this.btnPostFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnPostFound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostFound.FlatAppearance.BorderSize = 0;
            this.btnPostFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostFound.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnReportLost
            // 
            this.btnReportLost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnReportLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportLost.FlatAppearance.BorderSize = 0;
            this.btnReportLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportLost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSearchMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMatch.FlatAppearance.BorderSize = 0;
            this.btnSearchMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnClaimReturn
            // 
            this.btnClaimReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnClaimReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClaimReturn.FlatAppearance.BorderSize = 0;
            this.btnClaimReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaimReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaimReturn.ForeColor = System.Drawing.Color.White;
            this.btnClaimReturn.Location = new System.Drawing.Point(15, 315);
            this.btnClaimReturn.MaximumSize = new System.Drawing.Size(180, 42);
            this.btnClaimReturn.MinimumSize = new System.Drawing.Size(180, 42);
            this.btnClaimReturn.Name = "btnClaimReturn";
            this.btnClaimReturn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClaimReturn.Size = new System.Drawing.Size(180, 42);
            this.btnClaimReturn.TabIndex = 6;
            this.btnClaimReturn.Text = "Claim and Return";
            this.btnClaimReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaimReturn.UseVisualStyleBackColor = false;
            this.btnClaimReturn.Click += new System.EventHandler(this.button2_Click);
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
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(15, 25);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(179, 31);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Lost and Found";
            this.lblBrand.Click += new System.EventHandler(this.lblBrand_Click);
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
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
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
            // lblUserRole
            // 
            this.lblUserRole.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserRole.Location = new System.Drawing.Point(15, 32);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(180, 18);
            this.lblUserRole.TabIndex = 1;
            this.lblUserRole.Text = "Student";
            this.lblUserRole.Click += new System.EventHandler(this.lblUserRole_Click_1);
            // 
            // pnlFooterLine
            // 
            this.pnlFooterLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.pnlFooterLine.Location = new System.Drawing.Point(15, 3);
            this.pnlFooterLine.Name = "pnlFooterLine";
            this.pnlFooterLine.Size = new System.Drawing.Size(180, 1);
            this.pnlFooterLine.TabIndex = 1;
            this.pnlFooterLine.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooterLine_Paint);
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.pnlItems);
            this.pnlMain.Controls.Add(this.pnlDashboardHeader);
            this.pnlMain.Controls.Add(this.pnlClaimed);
            this.pnlMain.Controls.Add(this.pnlMatched);
            this.pnlMain.Controls.Add(this.pnlOpen);
            this.pnlMain.Controls.Add(this.pnlTotalItems);
            this.pnlMain.Location = new System.Drawing.Point(210, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(924, 661);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlDashboardHeader
            // 
            this.pnlDashboardHeader.BackColor = System.Drawing.Color.White;
            this.pnlDashboardHeader.Controls.Add(this.pnlHeaderLine);
            this.pnlDashboardHeader.Controls.Add(this.lblDashboardSubtitle);
            this.pnlDashboardHeader.Controls.Add(this.lblDashboardTitle);
            this.pnlDashboardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardHeader.Name = "pnlDashboardHeader";
            this.pnlDashboardHeader.Size = new System.Drawing.Size(924, 100);
            this.pnlDashboardHeader.TabIndex = 7;
            this.pnlDashboardHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDashboardHeader_Paint);
            // 
            // pnlHeaderLine
            // 
            this.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.pnlHeaderLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlHeaderLine.Location = new System.Drawing.Point(0, 99);
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.Size = new System.Drawing.Size(924, 1);
            this.pnlHeaderLine.TabIndex = 6;
            this.pnlHeaderLine.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeaderLine_Paint);
            // 
            // lblDashboardSubtitle
            // 
            this.lblDashboardSubtitle.AutoSize = true;
            this.lblDashboardSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblDashboardSubtitle.Location = new System.Drawing.Point(15, 60);
            this.lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            this.lblDashboardSubtitle.Size = new System.Drawing.Size(182, 15);
            this.lblDashboardSubtitle.TabIndex = 1;
            this.lblDashboardSubtitle.Text = "Overview of lost and found items";
            this.lblDashboardSubtitle.Click += new System.EventHandler(this.lblDashboardSubtitle_Click);
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblDashboardTitle.Location = new System.Drawing.Point(15, 25);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(159, 38);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            this.lblDashboardTitle.Click += new System.EventHandler(this.lblDashboardTitle_Click);
            // 
            // pnlClaimed
            // 
            this.pnlClaimed.Controls.Add(this.lblClaimedTitle);
            this.pnlClaimed.Controls.Add(this.label1);
            this.pnlClaimed.Location = new System.Drawing.Point(672, 115);
            this.pnlClaimed.Name = "pnlClaimed";
            this.pnlClaimed.Size = new System.Drawing.Size(210, 82);
            this.pnlClaimed.TabIndex = 5;
            this.pnlClaimed.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClaimed_Paint);
            // 
            // lblClaimedTitle
            // 
            this.lblClaimedTitle.AutoSize = true;
            this.lblClaimedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblClaimedTitle.Location = new System.Drawing.Point(16, 46);
            this.lblClaimedTitle.Name = "lblClaimedTitle";
            this.lblClaimedTitle.Size = new System.Drawing.Size(51, 15);
            this.lblClaimedTitle.TabIndex = 7;
            this.lblClaimedTitle.Text = "Claimed";
            this.lblClaimedTitle.Click += new System.EventHandler(this.lblClaimedTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // pnlMatched
            // 
            this.pnlMatched.Controls.Add(this.lblMatchedTitle);
            this.pnlMatched.Controls.Add(this.lblMatchedCount);
            this.pnlMatched.Location = new System.Drawing.Point(453, 115);
            this.pnlMatched.Name = "pnlMatched";
            this.pnlMatched.Size = new System.Drawing.Size(210, 82);
            this.pnlMatched.TabIndex = 4;
            this.pnlMatched.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMatched_Paint);
            // 
            // lblMatchedTitle
            // 
            this.lblMatchedTitle.AutoSize = true;
            this.lblMatchedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblMatchedTitle.Location = new System.Drawing.Point(16, 46);
            this.lblMatchedTitle.Name = "lblMatchedTitle";
            this.lblMatchedTitle.Size = new System.Drawing.Size(54, 15);
            this.lblMatchedTitle.TabIndex = 1;
            this.lblMatchedTitle.Text = "Matched";
            this.lblMatchedTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMatchedCount
            // 
            this.lblMatchedCount.AutoSize = true;
            this.lblMatchedCount.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchedCount.ForeColor = System.Drawing.Color.Brown;
            this.lblMatchedCount.Location = new System.Drawing.Point(16, 12);
            this.lblMatchedCount.Name = "lblMatchedCount";
            this.lblMatchedCount.Size = new System.Drawing.Size(29, 35);
            this.lblMatchedCount.TabIndex = 0;
            this.lblMatchedCount.Text = "0";
            this.lblMatchedCount.Click += new System.EventHandler(this.lblMatchedCount_Click);
            // 
            // pnlOpen
            // 
            this.pnlOpen.BackColor = System.Drawing.Color.White;
            this.pnlOpen.Controls.Add(this.lblOpenTitle);
            this.pnlOpen.Controls.Add(this.lblOpenCount);
            this.pnlOpen.Location = new System.Drawing.Point(234, 115);
            this.pnlOpen.Name = "pnlOpen";
            this.pnlOpen.Size = new System.Drawing.Size(210, 82);
            this.pnlOpen.TabIndex = 3;
            this.pnlOpen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpen_Paint);
            // 
            // lblOpenTitle
            // 
            this.lblOpenTitle.AutoSize = true;
            this.lblOpenTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblOpenTitle.Location = new System.Drawing.Point(16, 46);
            this.lblOpenTitle.Name = "lblOpenTitle";
            this.lblOpenTitle.Size = new System.Drawing.Size(36, 15);
            this.lblOpenTitle.TabIndex = 1;
            this.lblOpenTitle.Text = "Open";
            this.lblOpenTitle.Click += new System.EventHandler(this.lblOpenTitle_Click);
            // 
            // lblOpenCount
            // 
            this.lblOpenCount.AutoSize = true;
            this.lblOpenCount.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenCount.ForeColor = System.Drawing.Color.Brown;
            this.lblOpenCount.Location = new System.Drawing.Point(16, 12);
            this.lblOpenCount.Name = "lblOpenCount";
            this.lblOpenCount.Size = new System.Drawing.Size(29, 35);
            this.lblOpenCount.TabIndex = 0;
            this.lblOpenCount.Text = "0";
            this.lblOpenCount.Click += new System.EventHandler(this.lblOpenCount_Click);
            // 
            // pnlTotalItems
            // 
            this.pnlTotalItems.BackColor = System.Drawing.Color.White;
            this.pnlTotalItems.Controls.Add(this.lblTotalItemsTitle);
            this.pnlTotalItems.Controls.Add(this.lblTotalItemsCount);
            this.pnlTotalItems.Location = new System.Drawing.Point(15, 115);
            this.pnlTotalItems.Name = "pnlTotalItems";
            this.pnlTotalItems.Size = new System.Drawing.Size(210, 82);
            this.pnlTotalItems.TabIndex = 2;
            this.pnlTotalItems.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTotalItems_Paint);
            // 
            // lblTotalItemsTitle
            // 
            this.lblTotalItemsTitle.AutoSize = true;
            this.lblTotalItemsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lblTotalItemsTitle.Location = new System.Drawing.Point(16, 46);
            this.lblTotalItemsTitle.Name = "lblTotalItemsTitle";
            this.lblTotalItemsTitle.Size = new System.Drawing.Size(65, 15);
            this.lblTotalItemsTitle.TabIndex = 4;
            this.lblTotalItemsTitle.Text = "Total Items";
            this.lblTotalItemsTitle.Click += new System.EventHandler(this.lblTotalItemsTitle_Click);
            // 
            // lblTotalItemsCount
            // 
            this.lblTotalItemsCount.AutoSize = true;
            this.lblTotalItemsCount.BackColor = System.Drawing.Color.White;
            this.lblTotalItemsCount.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsCount.ForeColor = System.Drawing.Color.Brown;
            this.lblTotalItemsCount.Location = new System.Drawing.Point(16, 12);
            this.lblTotalItemsCount.Name = "lblTotalItemsCount";
            this.lblTotalItemsCount.Size = new System.Drawing.Size(29, 35);
            this.lblTotalItemsCount.TabIndex = 3;
            this.lblTotalItemsCount.Text = "0";
            this.lblTotalItemsCount.Click += new System.EventHandler(this.lblTotalItemsCount_Click);
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.Color.White;
            this.pnlItems.Location = new System.Drawing.Point(15, 215);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(894, 380);
            this.pnlItems.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campus Lost and Found System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlDashboardHeader.ResumeLayout(false);
            this.pnlDashboardHeader.PerformLayout();
            this.pnlClaimed.ResumeLayout(false);
            this.pnlClaimed.PerformLayout();
            this.pnlMatched.ResumeLayout(false);
            this.pnlMatched.PerformLayout();
            this.pnlOpen.ResumeLayout(false);
            this.pnlOpen.PerformLayout();
            this.pnlTotalItems.ResumeLayout(false);
            this.pnlTotalItems.PerformLayout();
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
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblDashboardSubtitle;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel pnlTotalItems;
        private System.Windows.Forms.Label lblTotalItemsCount;
        private System.Windows.Forms.Label lblTotalItemsTitle;
        private System.Windows.Forms.Panel pnlOpen;
        private System.Windows.Forms.Label lblOpenCount;
        private System.Windows.Forms.Label lblOpenTitle;
        private System.Windows.Forms.Panel pnlMatched;
        private System.Windows.Forms.Label lblMatchedTitle;
        private System.Windows.Forms.Label lblMatchedCount;
        private System.Windows.Forms.Panel pnlClaimed;
        private System.Windows.Forms.Label lblClaimedTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDashboardHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlItems;
    }
}
