using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement
{
    public class Member
    {
        // compiler supplies default constructor
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateEnded { get; set; } // nullable
    }
}
