using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DTO
{
    public class DeadMembersDetailDTO
    {
        public int DeadMemberID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string ImagePath { get; set; }
        public DateTime MembershipDate { get; set; }
        public DateTime DeathDate { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int NationalityID { get; set; }
        public string NationalityName { get; set; }
        public int ProfessionID { get; set; }
        public string ProfessionName { get; set; }
        public int PositionID { get; set; }
        public string PositionName { get; set; }
        public int GenderID { get; set; }
        public string GenderName { get; set; }
        public int MaritalStatusID { get; set; }
        public string MaritalStatusName { get; set; }
    }
}
