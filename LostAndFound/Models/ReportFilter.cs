using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LostAndFoundManagementSystem.Models
{
    /// Search options. Any property left null/empty is ignored.
    public class ReportFilter
    {
        public string Keyword { get; set; }
        public string ReportType { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }

    /// Numbers shown on the dashboard cards.
    public class DashboardCounts
    {
        public int LostRecords { get; set; }
        public int FoundRecords { get; set; }
        public int UnclaimedItems { get; set; }
        public int ReturnedItems { get; set; }
    }
}
