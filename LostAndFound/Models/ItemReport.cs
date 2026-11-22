using LostAndFound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Models
{
    /// 
    /// ABSTRACTION: the shared idea of "a report about an item". You can never create a plain
    /// ItemReport - it is always a LostItemReport or a FoundItemReport.
    /// ENCAPSULATION: every field is private; properties validate before storing, and Status can
    /// only be changed through UpdateStatus().
    /// 
    public abstract class ItemReport
    {
        private int _reportID;
        private string _itemName;
        private string _category;
        private string _description;
        private DateTime _reportDate;
        private string _status;

        protected ItemReport(string itemName, string category, string description, DateTime reportDate, string initialStatus)
        {
            ItemName = itemName;
            Category = category;
            Description = description;
            ReportDate = reportDate;
            _status = initialStatus;
        }

        public int ReportID { get { return _reportID; } }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = RequireText(value, "Item name", 100); }
        }

        public string Category
        {
            get { return _category; }
            set { _category = RequireText(value, "Category", 50); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = RequireText(value, "Description", 500); }
        }

        public DateTime ReportDate
        {
            get { return _reportDate; }
            set
            {
                if (value.Date > DateTime.Today)
                    throw new BusinessRuleException("The date cannot be in the future.");
                _reportDate = value.Date;
            }
        }

        /// Read-only from outside. Change it with UpdateStatus().
        public string Status { get { return _status; } }

        /// "Lost" or "Found" - supplied by each child class.
        public abstract string ReportType { get; }

        /// Where the item was last seen (lost) or found (found).
        public abstract string Location { get; }

        protected abstract string[] AllowedStatuses { get; }

        /// POLYMORPHISM: each child class builds its own summary text.
        public abstract string GetReportSummary();

        /// Changes the status only if the new value is allowed for this report type.
        public virtual void UpdateStatus(string newStatus)
        {
            if (string.IsNullOrWhiteSpace(newStatus))
                throw new BusinessRuleException("Status is required.");
            if (Array.IndexOf(AllowedStatuses, newStatus) < 0)
                throw new BusinessRuleException("'" + newStatus + "' is not a valid status for a " + ReportType.ToLower() + " item report.");
            if (_status == ReportStatus.Returned && newStatus != ReportStatus.Returned)
                throw new BusinessRuleException("A returned item cannot be reopened.");
            _status = newStatus;
        }

        /// Used by the repositories to put database values back into the object.
        internal void Restore(int reportId, string status)
        {
            _reportID = reportId;
            _status = status;
        }

        protected string IdText
        {
            get { return _reportID == 0 ? "(new)" : "#" + _reportID; }
        }

        protected static string RequireText(string value, string fieldName, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new BusinessRuleException(fieldName + " is required.");
            string trimmed = value.Trim();
            if (trimmed.Length > maxLength)
                throw new BusinessRuleException(fieldName + " must not be longer than " + maxLength + " characters.");
            return trimmed;
        }
    }
}