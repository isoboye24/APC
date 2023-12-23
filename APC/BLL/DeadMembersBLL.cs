using APC.DAL.DAO;
using APC.DAL;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.BLL
{
    public class DeadMembersBLL : IBLL<DeadMembersDTO, DeadMembersDetailDTO>
    {
        DeadMembersDAO dao = new DeadMembersDAO();
        ProfessionDAO professionDAO = new ProfessionDAO();
        PositionDAO positionDAO = new PositionDAO();
        NationalityDAO nationalityDAO = new NationalityDAO();
        GenderDAO genderDAO = new GenderDAO();
        MaritalStatusDAO marStatusDAO = new MaritalStatusDAO();
        CountryDAO countryDAO = new CountryDAO();
        public bool Delete(DeadMembersDetailDTO entity)
        {
            DEATH_MEMBER member = new DEATH_MEMBER();
            member.deadMemberID = entity.DeadMemberID;
            return dao.Delete(member);
        }

        public bool GetBack(DeadMembersDetailDTO entity)
        {
            return dao.GetBack(entity.DeadMemberID);
        }

        public bool Insert(DeadMembersDetailDTO entity)
        {
            DEATH_MEMBER member = new DEATH_MEMBER();
            member.name = entity.Name;
            member.surname = entity.Surname;
            member.birthday = entity.Birthday;
            member.deathDate = entity.DeathDate;
            member.imagePath = entity.ImagePath;
            member.membershipDate = entity.MembershipDate;
            member.countryID = entity.CountryID;
            member.nationalityID = entity.NationalityID;
            member.professionID = entity.ProfessionID;
            member.positionID = entity.PositionID;
            member.genderID = entity.GenderID;
            member.maritalStatusID = entity.MaritalStatusID;
            return dao.Insert(member);
        }

        public DeadMembersDTO Select()
        {
            DeadMembersDTO dto = new DeadMembersDTO();
            dto.DeadMembers = dao.Select();
            dto.Professions = professionDAO.Select();
            dto.Countries = countryDAO.Select();
            dto.Nationalities = nationalityDAO.Select();
            dto.Genders = genderDAO.Select();
            dto.Positions = positionDAO.Select();
            dto.MaritalStatuses = marStatusDAO.Select();
            return dto;
        }
        public int SelectCountMale()
        {
            return dao.SelectCountMale();
        }
        public int SelectCountFemale()
        {
            return dao.SelectCountFemale();
        }
        public int SelectCountDivisor()
        {
            return dao.SelectCountDivisor();
        }

        public bool Update(DeadMembersDetailDTO entity)
        {
            DEATH_MEMBER member = new DEATH_MEMBER();
            member.deadMemberID = entity.DeadMemberID;
            member.name = entity.Name;
            member.surname = entity.Surname;
            member.birthday = entity.Birthday;
            member.deathDate = entity.DeathDate;
            member.imagePath = entity.ImagePath;
            member.membershipDate = entity.MembershipDate;
            member.countryID = entity.CountryID;
            member.nationalityID = entity.NationalityID;
            member.professionID = entity.ProfessionID;
            member.positionID = entity.PositionID;
            member.genderID = entity.GenderID;
            member.maritalStatusID = entity.MaritalStatusID;
            return dao.Update(member);
        }
    }
}
