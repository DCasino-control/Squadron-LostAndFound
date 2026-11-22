using LostAndFoundManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Models
{
    internal class Claim
    {
        private int _claimID;
        private int _foundReportID;
        private string _claimantName;
        private DateTime _claimDate;
        private string _verificationStatus = VerificationStatuses.Pending;
        private string _verificationNotes;
        private DateTime? _returnDate;
        public Claim(int foundReportID, string claimantName, DateTime claimDate)
        {
            if (foundReportID <= 0)
                throw new BusinessRuleException("Please select the found item being claimed.");
            _foundReportID = foundReportID;
            _claimantName = claimantName;
            _claimDate = claimDate;
        }
        public int ClaimID { get { return _claimID; } }
        public int FoundReportID { get { return _foundReportID; } 
        }
        public string ClaimantName
        {
            get { return _claimantName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new BusinessRuleException("Claimant name is required.");
                if (value.Trim().Length > 100)
                    throw new BusinessRuleException("Claimant name must not be longer than 100 characters.");
                _claimantName = value.Trim();
            }
        }

    }
}
