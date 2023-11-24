using APC.DAL;
using APC.DAL.DAO;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC.BLL
{
    public class MemberBLL : IBLL<MemberDTO, MemberDetailDTO>
    {
        MemberDAO memberDAO = new MemberDAO();
        ProfessionDAO professionDAO = new ProfessionDAO();
        PositionDAO positionDAO = new PositionDAO();
        NationalityDAO nationalityDAO = new NationalityDAO();
        GenderDAO genderDAO = new GenderDAO();
        MaritalStatusDAO marStatusDAO = new MaritalStatusDAO();
        EmploymentStatusDAO empStatusDAO = new EmploymentStatusDAO();
        PermissionDAO permissionDAO = new PermissionDAO();
        CountryDAO countryDAO = new CountryDAO();
        public bool Delete(MemberDetailDTO entity)
        {
            MEMBER member = new MEMBER();
            member.memberID = entity.MemberID;
            return memberDAO.Delete(member);
        }

        public bool GetBack(MemberDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(MemberDetailDTO entity)
        {
            MEMBER member = new MEMBER();
            member.username = entity.Username;
            member.password = entity.Password;
            member.name = entity.Name;
            member.surname = entity.Surname;
            member.birthday = entity.Birthday;
            member.imagePath = entity.ImagePath;
            member.houseAddress = entity.HouseAddress;
            member.emailAddress = entity.EmailAddress;
            member.membershipDate = entity.MembershipDate;
            member.countryID = entity.CountryID;
            member.nationalityID = entity.NationalityID;
            member.professionID = entity.ProfessionID;
            member.positionID = entity.PositionID;
            member.genderID = entity.GenderID;
            member.employmentStatusID = entity.EmploymentStatusID;
            member.maritalStatusID = entity.MaritalStatusID;
            member.permissionID = entity.PermissionID;
            member.phoneNumber = entity.PhoneNumber;
            member.phoneNumber2 = entity.PhoneNumber2;
            member.phoneNumber3 = entity.PhoneNumber3;
            return memberDAO.Insert(member);
        }

        public MemberDTO Select()
        {
            MemberDTO dto = new MemberDTO();
            dto.Members = memberDAO.Select();            
            dto.Professions = professionDAO.Select();
            dto.Countries = countryDAO.Select();
            dto.Nationalities = nationalityDAO.Select();
            dto.EmploymentStatuses = empStatusDAO.Select();
            dto.Genders = genderDAO.Select();
            dto.Positions = positionDAO.Select();
            dto.MaritalStatuses = marStatusDAO.Select();
            return dto;
        }
        public int SelectAllMembersCount()
        {
            return memberDAO.SelectAllMembersCount();
        }
        
        public int SelectCountMale()
        {
            return memberDAO.SelectCountMale();
        }
        public int SelectCountFemale()
        {
            return memberDAO.SelectCountFemale();
        }
        public int SelectCountDivisor()
        {
            return memberDAO.SelectCountDivisor();
        }
        public int SelectCountUniqueNationality()
        {
            return memberDAO.SelectCountUniqueNationality();
        }

        public bool Update(MemberDetailDTO entity)
        {
            MEMBER member = new MEMBER();
            member.memberID = entity.MemberID;
            member.surname = entity.Surname;
            member.name = entity.Name;
            member.username = entity.Username;
            member.password = entity.Password;
            member.birthday = entity.Birthday;
            member.imagePath = entity.ImagePath;
            member.houseAddress = entity.HouseAddress;
            member.emailAddress = entity.EmailAddress;
            member.membershipDate = entity.MembershipDate;
            member.countryID = entity.CountryID;
            member.nationalityID = entity.NationalityID;
            member.professionID = entity.ProfessionID;
            member.positionID = entity.PositionID;
            member.genderID = entity.GenderID;
            member.employmentStatusID = entity.EmploymentStatusID;
            member.maritalStatusID = entity.MaritalStatusID;
            member.permissionID = entity.PermissionID;
            member.phoneNumber = entity.PhoneNumber;
            member.phoneNumber2 = entity.PhoneNumber2;
            member.phoneNumber3 = entity.PhoneNumber3;
            return memberDAO.Update(member);
        }
    }
}
