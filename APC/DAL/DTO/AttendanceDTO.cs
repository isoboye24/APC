using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DTO
{
    public class AttendanceDTO
    {
        public List<MemberDetailDTO> Members { get; set; }
        public List<MonthDetailDTO> Months { get; set; }
        public List<AttendanceStatusDetailDTO> AttendanceStatuses { get; set; }
        public List<GenderDetailDTO> Genders { get; set; }
        public List<AttendanceDetailDTO> Attendances { get; set; }
        public List<AttendanceListDetailDTO> AttendanceLists { get; set; }
        public List<MonthAndYearListDetailDTO> MonthsAndYears { get; set; }
    }
}
