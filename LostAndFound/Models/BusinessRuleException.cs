using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Models
{
    /// 
    /// Thrown when input or an operation breaks a rule of the system
    /// (empty required field, claim not verified, item already returned, ...).
    /// The UI shows its message to the user as a friendly warning.
    /// 
    public class BusinessRuleException : Exception
    {
        public BusinessRuleException(string message) : base(message) { }
    }
}
