using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DTO
{
    public class AttendanceDetailDTO
    {
        public int AttendanceID { get; set; }
        public int AttendanceStatusID { get; set; }
        public int Day { get; set; }
        public string MonthName { get; set; }
        public string Year { get; set; }
        public string AttendanceStatusName { get; set; }
        public int MemberID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public int GenderID { get; set; }
        public string Gender { get; set; }
        public int MonthlyDue { get; set; }
        public int ExpectedDue { get; set; }
        public int Balance { get; set; }
        public int MonthID { get; set; }
    }
}
