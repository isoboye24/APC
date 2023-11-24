using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class MemberDAO : APCContexts, IDAO<MemberDetailDTO, MEMBER>
    {
        public bool Delete(MEMBER entity)
        {            
            try
            {
                MEMBER member = db.MEMBERs.First(x => x.memberID == entity.memberID);
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
            throw new NotImplementedException();
        }

        public bool Insert(MEMBER entity)
        {
            try
            {
                db.MEMBERs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public List<MemberDetailDTO> Select()
        {
            try
            {
                List<MemberDetailDTO> members = new List<MemberDetailDTO>();
                var list = (from m in db.MEMBERs.Where(x=>x.isDeleted==false)
                            join g in db.GENDERs on m.genderID equals g.genderID
                            join e in db.EMPLOYMENT_STATUS on m.employmentStatusID equals e.employmentStatusID
                            join p in db.PROFESSIONs on m.professionID equals p.professionID
                            join pos in db.POSITIONs on m.positionID equals pos.positionID
                            join mar in db.MARITAL_STATUS on m.maritalStatusID equals mar.maritalStatusID
                            join c in db.COUNTRies on m.countryID equals c.countryID
                            join n in db.NATIONALITies on m.nationalityID equals n.nationalityID
                            join perm in db.PERMISSIONs on m.permissionID equals perm.permissionID
                            select new
                            {
                                memberID = m.memberID,
                                username = m.username,
                                name = m.name,
                                surname = m.surname,
                                password = m.password,
                                birthday = m.birthday,
                                imagePath = m.imagePath,
                                emailAddress = m.emailAddress,
                                houseAddress = m.houseAddress,
                                membershipDate = m.membershipDate,
                                countryID = m.countryID,
                                countryName = c.countryName,
                                nationalityID = m.nationalityID,
                                nationalityName = n.nationality1,
                                professionID = m.professionID,
                                professionName = p.profession1,
                                positionID = m.positionID,
                                positionName = pos.positionName,
                                genderID = m.genderID,
                                genderName = g.genderName,
                                employmenStatusID = m.employmentStatusID,
                                employmenStatusName = e.employmentStatus,
                                maritalStatusID = m.maritalStatusID,
                                maritalStatusName = mar.maritalStatus,
                                permissionID = m.permissionID,
                                permissionName = perm.permission1,
                                phoneNumber = m.phoneNumber,
                                phoneNumber2 = m.phoneNumber2,
                                phoneNumber3 = m.phoneNumber3
                            }).OrderBy(x=>x.surname).ToList();
                foreach (var item in list)
                {
                    MemberDetailDTO dto = new MemberDetailDTO();
                    dto.MemberID = item.memberID;
                    dto.Username = item.username;
                    dto.Name = item.name;
                    dto.Surname = item.surname;
                    dto.Password = item.password;
                    dto.Birthday = item.birthday;
                    dto.ImagePath = item.imagePath;
                    dto.EmailAddress = item.emailAddress;
                    dto.HouseAddress = item.houseAddress;
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
                    dto.EmploymentStatusID = item.employmenStatusID;
                    dto.EmploymentStatusName = item.employmenStatusName;
                    dto.MaritalStatusID = item.maritalStatusID;
                    dto.MaritalStatusName = item.maritalStatusName;
                    dto.PermissionID = item.permissionID;
                    dto.PermissionName = item.permissionName;
                    dto.PhoneNumber = item.phoneNumber;
                    dto.PhoneNumber2 = item.phoneNumber2;
                    dto.PhoneNumber3 = item.phoneNumber3;
                    members.Add(dto);
                }
                return members;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        public int SelectAllMembersCount()
        {
            try
            {
                int numberOfMembers = db.MEMBERs.Count(x => x.isDeleted == false);
                return numberOfMembers;
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
                int numberOfMembers = db.MEMBERs.Count(x=>x.isDeleted==false && x.genderID==1);
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
                int numberOfMembers = db.MEMBERs.Count(x => x.isDeleted == false && x.genderID == 2);
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
                int numberOfMembers = db.MEMBERs.Count(x => x.isDeleted == false && x.genderID == 3);
                return numberOfMembers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SelectCountUniqueNationality()
        {
            try
            {
                List<string> nationalityList = new List<string>();
                List<MemberDetailDTO> uniqueNationality = new List<MemberDetailDTO>();
                var list = (from m in db.MEMBERs.Where(x => x.isDeleted == false)
                            join n in db.NATIONALITies on m.nationalityID equals n.nationalityID
                            select new
                            {
                                memberID = m.memberID,
                                nationalityID = m.nationalityID,
                                nationality = n.nationality1,
                            }).Distinct().ToList();
                foreach (var item in list)
                {
                    MemberDetailDTO dto = new MemberDetailDTO();
                    dto.NationalityName = item.nationality;
                    nationalityList.Add(item.nationality);
                    uniqueNationality.Add(dto);
                }
                var getUniqueList = nationalityList.Distinct().ToList();
                int nationalityCount = getUniqueList.Count();
                return nationalityCount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(MEMBER entity)
        {
            try
            {
                MEMBER member = db.MEMBERs.First(x => x.memberID == entity.memberID);
                member.surname = entity.surname;
                member.name = entity.name;
                member.username = entity.username;
                member.password = entity.password;
                member.birthday = entity.birthday;
                member.imagePath = entity.imagePath;
                member.houseAddress = entity.houseAddress;
                member.emailAddress = entity.emailAddress;
                member.membershipDate = entity.membershipDate;
                member.countryID = entity.countryID;
                member.nationalityID = entity.nationalityID;
                member.professionID = entity.professionID;
                member.positionID = entity.positionID;
                member.genderID = entity.genderID;
                member.employmentStatusID = entity.employmentStatusID;
                member.maritalStatusID = entity.maritalStatusID;
                member.permissionID = entity.permissionID;
                member.phoneNumber = entity.phoneNumber;
                member.phoneNumber2 = entity.phoneNumber2;
                member.phoneNumber3 = entity.phoneNumber3;
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
