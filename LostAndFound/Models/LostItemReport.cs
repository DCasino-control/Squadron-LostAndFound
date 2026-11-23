using LostAndFound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LostAndFoundManagementSystem.Models
{
    /// INHERITANCE: reuses everything from ItemReport and adds lost-item details.
    public class LostItemReport : ItemReport
    {
        private string _lastSeenLocation;
        private string _reporterContact;

        public LostItemReport(string itemName, string category, string description, DateTime dateLost,
                              string lastSeenLocation, string reporterContact)
            : base(itemName, category, description, dateLost, ReportStatus.Lost)
        {
            LastSeenLocation = lastSeenLocation;
            ReporterContact = reporterContact;
        }

        public string LastSeenLocation
        {
            get { return _lastSeenLocation; }
            set { _lastSeenLocation = RequireText(value, "Last seen location", 150); }
        }

        public string ReporterContact
        {
            get { return _reporterContact; }
            set { _reporterContact = RequireText(value, "Reporter contact", 100); }
        }

        public override string ReportType { get { return ReportTypes.Lost; } }
        public override string Location { get { return LastSeenLocation; } }
        protected override string[] AllowedStatuses { get { return ReportStatus.ForLostReports; } }

        /// Makes sure a brand-new lost report is ready to be saved.
        public void RecordLostItem()
        {
            if (ReportID != 0)
                throw new BusinessRuleException("This lost item report has already been recorded.");
            if (Status != ReportStatus.Lost)
                throw new BusinessRuleException("A new lost item report must start with the status 'Lost'.");
        }

        public override string GetReportSummary()
        {
            string nl = Environment.NewLine;
            return "LOST ITEM REPORT " + IdText + nl +
                   "Item: " + ItemName + nl +
                   "Category: " + Category + nl +
                   "Date lost: " + ReportDate.ToString("dd MMM yyyy") + nl +
                   "Last seen at: " + LastSeenLocation + nl +
                   "Reporter contact: " + ReporterContact + nl +
                   "Status: " + Status + nl + nl +
                   "Description:" + nl + Description;
        }
    }
}
