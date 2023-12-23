using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class DeadMembersDAO : APCContexts, IDAO<DeadMembersDetailDTO, DEATH_MEMBER>
    {
        public bool Delete(DEATH_MEMBER entity)
        {
            try
            {
                DEATH_MEMBER member = db.DEATH_MEMBER.First(x => x.deadMemberID == entity.deadMemberID);
                member.isDeleted = true;
                member.deletedDate = DateTime.Today;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetBack(int ID)
        {
            try
            {
                DEATH_MEMBER deadMember = db.DEATH_MEMBER.First(x=>x.deadMemberID==ID);
                deadMember.isDeleted = false;
                deadMember.deletedDate = null;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(DEATH_MEMBER entity)
        {
            try
            {
                db.DEATH_MEMBER.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public List<DeadMembersDetailDTO> Select()
        {
            try
            {
                List<DeadMembersDetailDTO> members = new List<DeadMembersDetailDTO>();
                var list = (from d in db.DEATH_MEMBER.Where(x => x.isDeleted == false)
                            join g in db.GENDERs on d.genderID equals g.genderID
                            join p in db.PROFESSIONs.Where(x => x.isDeleted == false) on d.professionID equals p.professionID
                            join pos in db.POSITIONs.Where(x => x.isDeleted == false) on d.positionID equals pos.positionID
                            join mar in db.MARITAL_STATUS.Where(x => x.isDeleted == false) on d.maritalStatusID equals mar.maritalStatusID
                            join c in db.COUNTRies.Where(x => x.isDeleted == false) on d.countryID equals c.countryID
                            join n in db.NATIONALITies.Where(x => x.isDeleted == false) on d.nationalityID equals n.nationalityID
                            select new
                            {
                                memberID = d.deadMemberID,
                                name = d.name,
                                surname = d.surname,
                                birthday = d.birthday,
                                died = d.deathDate,
                                imagePath = d.imagePath,
                                membershipDate = d.membershipDate,
                                countryID = d.countryID,
                                countryName = c.countryName,
                                nationalityID = d.nationalityID,
                                nationalityName = n.nationality1,
                                professionID = d.professionID,
                                professionName = p.profession1,
                                positionID = d.positionID,
                                positionName = pos.positionName,
                                genderID = d.genderID,
                                genderName = g.genderName,
                                maritalStatusID = d.maritalStatusID,
                                maritalStatusName = mar.maritalStatus,
                            }).OrderByDescending(x => x.died).ToList();
                foreach (var item in list)
                {
                    DeadMembersDetailDTO dto = new DeadMembersDetailDTO();
                    dto.DeadMemberID = item.memberID;
                    dto.Name = item.name;
                    dto.Surname = item.surname;
                    dto.Birthday = item.birthday;
                    dto.DeathDate = item.died;
                    dto.ImagePath = item.imagePath;
                    dto.MembershipDate = (DateTime)item.membershipDate;
                    dto.CountryID = item.countryID;
                    dto.CountryName = item.countryName;
                    dto.NationalityID = item.nationalityID;
                    dto.NationalityName = item.nationalityName;
                    dto.ProfessionID = item.professionID;
                    dto.ProfessionName = item.professionName;
                    dto.PositionID = item.positionID;
                    dto.PositionName = item.positionName;
                    dto.GenderID = item.genderID;
                    dto.GenderName = item.genderName;
                    dto.MaritalStatusID = item.maritalStatusID;
                    dto.MaritalStatusName = item.maritalStatusName;
                    members.Add(dto);
                }
                return members;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DeadMembersDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<DeadMembersDetailDTO> members = new List<DeadMembersDetailDTO>();
                var list = (from d in db.DEATH_MEMBER.Where(x => x.isDeleted == isDeleted)
                            join g in db.GENDERs on d.genderID equals g.genderID
                            join p in db.PROFESSIONs on d.professionID equals p.professionID
                            join pos in db.POSITIONs on d.positionID equals pos.positionID
                            join mar in db.MARITAL_STATUS on d.maritalStatusID equals mar.maritalStatusID
                            join c in db.COUNTRies on d.countryID equals c.countryID
                            join n in db.NATIONALITies on d.nationalityID equals n.nationalityID
                            select new
                            {
                                memberID = d.deadMemberID,
                                name = d.name,
                                surname = d.surname,
                                birthday = d.birthday,
                                died = d.deathDate,
                                imagePath = d.imagePath,
                                membershipDate = d.membershipDate,
                                countryID = d.countryID,
                                countryName = c.countryName,
                                nationalityID = d.nationalityID,
                                nationalityName = n.nationality1,
                                professionID = d.professionID,
                                professionName = p.profession1,
                                positionID = d.positionID,
                                positionName = pos.positionName,
                                genderID = d.genderID,
                                genderName = g.genderName,
                                maritalStatusID = d.maritalStatusID,
                                maritalStatusName = mar.maritalStatus,
                                isCountryDeleted = c.isDeleted,
                                isNationalityDeleted = n.isDeleted,
                                isProfessionDeleted = p.isDeleted,
                                isPositionDeleted = pos.isDeleted,
                                isMarStatusDeleted = mar.isDeleted,
                            }).OrderByDescending(x => x.died).ToList();
                foreach (var item in list)
                {
                    DeadMembersDetailDTO dto = new DeadMembersDetailDTO();
                    dto.DeadMemberID = item.memberID;
                    dto.Name = item.name;
                    dto.Surname = item.surname;
                    dto.Birthday = item.birthday;
                    dto.DeathDate = item.died;
                    dto.ImagePath = item.imagePath;
                    dto.MembershipDate = (DateTime)item.membershipDate;
                    dto.CountryID = item.countryID;
                    dto.CountryName = item.countryName;
                    dto.NationalityID = item.nationalityID;
                    dto.NationalityName = item.nationalityName;
                    dto.ProfessionID = item.professionID;
                    dto.ProfessionName = item.professionName;
                    dto.PositionID = item.positionID;
                    dto.PositionName = item.positionName;
                    dto.GenderID = item.genderID;
                    dto.GenderName = item.genderName;
                    dto.MaritalStatusID = item.maritalStatusID;
                    dto.MaritalStatusName = item.maritalStatusName;
                    dto.isCountryDeleted = item.isCountryDeleted;
                    dto.isNationalityDeleted = item.isNationalityDeleted;
                    dto.isProfessionDeleted = item.isProfessionDeleted;
                    dto.isPositionDeleted = item.isPositionDeleted;
                    dto.isMarStatusDeleted = item.isMarStatusDeleted;
                    members.Add(dto);
                }
                return members;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SelectCountMale()
        {
            try
            {
                int numberOfMembers = db.DEATH_MEMBER.Count(x => x.isDeleted == false && x.genderID == 1);
                return numberOfMembers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SelectCountFemale()
        {
            try
            {
                int numberOfMembers = db.DEATH_MEMBER.Count(x => x.isDeleted == false && x.genderID == 2);
                return numberOfMembers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SelectCountDivisor()
        {
            try
            {
                int numberOfMembers = db.DEATH_MEMBER.Count(x => x.isDeleted == false && x.genderID == 3);
                return numberOfMembers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(DEATH_MEMBER entity)
        {
            try
            {
                DEATH_MEMBER member = db.DEATH_MEMBER.First(x => x.deadMemberID == entity.deadMemberID);
                member.surname = entity.surname;
                member.name = entity.name;
                member.birthday = entity.birthday;
                member.deathDate = entity.deathDate;
                member.imagePath = entity.imagePath;
                member.membershipDate = entity.membershipDate;
                member.countryID = entity.countryID;
                member.nationalityID = entity.nationalityID;
                member.professionID = entity.professionID;
                member.positionID = entity.positionID;
                member.genderID = entity.genderID;
                member.maritalStatusID = entity.maritalStatusID;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
