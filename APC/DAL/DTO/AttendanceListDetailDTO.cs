using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DTO
{
    public class AttendanceListDetailDTO
    {
        public int AttendanceListID { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public int TotalMembers { get; set; }
        public int TotalFemale { get; set; }
        public int TotalMale { get; set; }
        public int TotalDuesPaid { get; set; }
        public int TotalDuesExpected { get; set; }
        public int TotalDuesBalance { get; set; }
        public int MonthID { get; set; }
    }
}
