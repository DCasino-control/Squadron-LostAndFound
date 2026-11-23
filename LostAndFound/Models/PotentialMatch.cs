using LostAndFound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFoundManagementSystem.Models
{
    /// 
    /// A suggested pairing of one lost report and one found report. It is only a suggestion until
    /// the administrator reviews it (Pending -> Confirmed or Rejected).
    /// 
    public class PotentialMatch
    {
        private int _matchID;
        private string _reviewStatus = MatchReviewStatuses.Pending;
        private DateTime? _reviewedDate;

        public PotentialMatch(int lostReportID, int foundReportID, int score)
        {
            if (lostReportID <= 0 || foundReportID <= 0)
                throw new BusinessRuleException("A match needs both a lost report and a found report.");
            LostReportID = lostReportID;
            FoundReportID = foundReportID;
            Score = score;
        }

        public int MatchID { get { return _matchID; } }
        public int LostReportID { get; private set; }
        public int FoundReportID { get; private set; }
        public int Score { get; private set; }
        public string ReviewStatus { get { return _reviewStatus; } }
        public DateTime? ReviewedDate { get { return _reviewedDate; } }

        /// Filled by the repository for display.
        public string LostItemName { get; internal set; }
        public string FoundItemName { get; internal set; }

        public void Review(bool confirm)
        {
            if (_reviewStatus != MatchReviewStatuses.Pending)
                throw new BusinessRuleException("This match has already been reviewed.");
            _reviewStatus = confirm ? MatchReviewStatuses.Confirmed : MatchReviewStatuses.Rejected;
            _reviewedDate = DateTime.Now;
        }

        internal void Restore(int matchId, string reviewStatus, DateTime? reviewedDate)
        {
            _matchID = matchId;
            _reviewStatus = reviewStatus;
            _reviewedDate = reviewedDate;
        }
    }
}

