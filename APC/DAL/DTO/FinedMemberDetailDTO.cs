using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DTO
{
    public class FinedMemberDetailDTO
    {
        public int FinedMemberID { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal ExpectedAmount { get; set; }
        public decimal Balance { get; set; }
        public string Summary { get; set; }
        public string FineStatus { get; set; }
        public int ConstitutionID { get; set; }
        public int MemberID { get; set; }
        public int Day { get; set; }
        public int MonthID { get; set; }
        public string MonthName { get; set; }
        public int Year { get; set; }
    }
}
