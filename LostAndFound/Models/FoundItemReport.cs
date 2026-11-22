using LostAndFound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LostAndFound.Models
{
    /// INHERITANCE NI DIRI KAY GI reuses NIYA ANG everything from ItemReport and adds found-item details.
    public class FoundItemReport : ItemReport
    {
        private string _foundLocation;
        private string _storageLocation;

        public FoundItemReport(string itemName, string category, string description, DateTime dateFound,
                               string foundLocation, string storageLocation)
            : base(itemName, category, description, dateFound, ReportStatus.Found)
        {
            FoundLocation = foundLocation;
            StorageLocation = storageLocation;
        }

        public string FoundLocation
        {
            get { return _foundLocation; }
            set { _foundLocation = RequireText(value, "Found location", 150); }
        }

        public string StorageLocation
        {
            get { return _storageLocation; }
            set { _storageLocation = RequireText(value, "Storage location", 150); }
        }

        public override string ReportType { get { return ReportTypes.Found; } }
        public override string Location { get { return FoundLocation; } }
        protected override string[] AllowedStatuses { get { return ReportStatus.ForFoundReports; } }

        /// Makes sure a brand-new found report is ready to be saved.
        public void RecordFoundItem()
        {
            if (ReportID != 0)
                throw new BusinessRuleException("This found item report has already been recorded.");
            if (Status != ReportStatus.Found)
                throw new BusinessRuleException("A new found item report must start with the status 'Found'.");
        }

        public override string GetReportSummary()
        {
            string nl = Environment.NewLine;
            return "FOUND ITEM REPORT " + IdText + nl +
                   "Item: " + ItemName + nl +
                   "Category: " + Category + nl +
                   "Date found: " + ReportDate.ToString("dd MMM yyyy") + nl +
                   "Found at: " + FoundLocation + nl +
                   "Kept at: " + StorageLocation + nl +
                   "Status: " + Status + nl + nl +
                   "Description:" + nl + Description;
        }
    }
}

