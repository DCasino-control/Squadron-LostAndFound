using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Models
{
    /// The two kinds of report. Stored in ItemReports.ReportType.
    public static class ReportTypes
    {
        public const string Lost = "Lost";
        public const string Found = "Found";
    }

    /// Allowed values for ItemReport.Status. Lost reports use Lost/Matched/Returned, found reports use Found/Matched/Returned.
    public static class ReportStatus
    {
        public const string Lost = "Lost";
        public const string Found = "Found";
        public const string Matched = "Matched";
        public const string Returned = "Returned";

        public static readonly string[] ForLostReports = { Lost, Matched, Returned };
        public static readonly string[] ForFoundReports = { Found, Matched, Returned };
        public static readonly string[] All = { Lost, Found, Matched, Returned };
    }

    public static class VerificationStatuses
    {
        public const string Pending = "Pending";
        public const string Verified = "Verified";
        public const string Rejected = "Rejected";
        public static readonly string[] All = { Pending, Verified, Rejected };
    }

    public static class MatchReviewStatuses
    {
        public const string Pending = "Pending";
        public const string Confirmed = "Confirmed";
        public const string Rejected = "Rejected";
        public static readonly string[] All = { Pending, Confirmed, Rejected };
    }

    public static class ItemCategories
    {
        public static readonly string[] All =
        {
            "Personal Belongings", "Electronics", "Documents / IDs", "Bags", "Clothing",
            "Keys", "School Supplies / Books", "Accessories / Jewelry", "Water Bottles / Containers", "Others"
        };
    }
}

