using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    internal class PersonalAttendanceDAO : APCContexts, IDAO<PersonalAttendanceDetailDTO, PERSONAL_ATTENDANCE>
    {
        public bool Delete(PERSONAL_ATTENDANCE entity)
        {
            try
            {
                if (entity.generalAttendanceID != 0)
                {
                    List<PERSONAL_ATTENDANCE> personalAttendance = db.PERSONAL_ATTENDANCE.Where(x => x.generalAttendanceID == entity.generalAttendanceID).ToList();
                    foreach (var item in personalAttendance)
                    {
                        item.isDeleted = true;
                        item.deletedDate = DateTime.Today;
                    }
                    db.SaveChanges();
                }
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

        public bool Insert(PERSONAL_ATTENDANCE entity)
        {
            try
            {
                db.PERSONAL_ATTENDANCE.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PersonalAttendanceDetailDTO> Select()
        {
            throw new NotImplementedException();
        }

        public List<PersonalAttendanceDetailDTO> SelectMembers(int generalAttendanceID)
        {
            try
            {
                List<PersonalAttendanceDetailDTO> personalAttendance = new List<PersonalAttendanceDetailDTO>();

                var list = (from p in db.PERSONAL_ATTENDANCE.Where(x => x.isDeleted == false && x.generalAttendanceID == generalAttendanceID)
                            join ats in db.ATTENDANCE_STATUS on p.attendanceStatusID equals ats.attendanceStatusID
                            join m in db.MEMBERs on p.memberID equals m.memberID
                            join mo in db.MONTHs on p.monthID equals mo.monthID
                            join g in db.GENDERs on m.genderID equals g.genderID
                            select new
                            {
                                attendanceID = p.attendanceID,
                                attendanceStatusID = p.attendanceStatusID,
                                attendanceStatusName = ats.attendanceStatus,
                                day = p.day,
                                monthID = p.monthID,
                                monthName = mo.monthName,
                                year = p.year,
                                memberID = p.memberID,
                                surname = m.surname,
                                name = m.name,
                                imagePath = m.imagePath,
                                genderID = m.genderID,
                                genderName = g.genderName,
                                monthlyDue = p.monthlyDues,
                                expectedMonthlyDue = p.expectedMonthlyDue,
                                balance = p.balance,
                                generalAttendanceID = p.generalAttendanceID,
                            }).OrderBy(x => x.surname).ToList();
                foreach (var item in list)
                {
                    PersonalAttendanceDetailDTO dto = new PersonalAttendanceDetailDTO();
                    dto.AttendanceID = item.attendanceID;
                    dto.AttendanceStatusID = item.attendanceStatusID;
                    dto.AttendanceStatusName = item.attendanceStatusName;
                    dto.Day = (int)item.day;
                    dto.MonthID = item.monthID;
                    dto.MonthName = item.monthName;
                    dto.Year = item.year.ToString();
                    dto.MemberID = item.memberID;
                    dto.Surname = item.surname;
                    dto.Name = item.name;
                    dto.ImagePath = item.imagePath;
                    dto.GenderID = item.genderID;
                    dto.Gender = item.genderName;
                    dto.MonthlyDue = (decimal)item.monthlyDue;
                    dto.ExpectedDue = (decimal)item.expectedMonthlyDue;
                    dto.Balance = (decimal)item.balance;
                    dto.GeneralAttendanceID = item.generalAttendanceID;
                    personalAttendance.Add(dto);
                }
                return personalAttendance;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public int SelectLastMeetingAttendance(int month, int year)
        {
            try
            {
                List<int> lastAttendance = new List<int>();
                var list = db.PERSONAL_ATTENDANCE.Where(x => x.isDeleted == false && x.year == year && x.monthID == month);
                foreach (var item in list)
                {
                    PersonalAttendanceDetailDTO dto = new PersonalAttendanceDetailDTO();
                    dto.AttendanceID = item.attendanceID;
                    lastAttendance.Add(item.memberID);
                }
                int result = lastAttendance.Count();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<PERSONAL_ATTENDANCE> IsUnique(int personID, int attendanceID)
        {
            return db.PERSONAL_ATTENDANCE.Where(x => x.memberID == personID && x.generalAttendanceID == attendanceID).ToList();
        }

        public bool Update(PERSONAL_ATTENDANCE entity)
        {
            try
            {
                PERSONAL_ATTENDANCE personalAttendance = db.PERSONAL_ATTENDANCE.First(x=>x.attendanceID == entity.attendanceID);
                personalAttendance.attendanceStatusID = entity.attendanceStatusID;
                personalAttendance.memberID = entity.memberID;
                personalAttendance.monthlyDues = entity.monthlyDues;
                personalAttendance.expectedMonthlyDue = entity.expectedMonthlyDue;
                personalAttendance.balance = entity.balance;
                personalAttendance.day = entity.day;
                personalAttendance.monthID = entity.monthID;
                personalAttendance.generalAttendanceID = entity.generalAttendanceID;
                personalAttendance.year = entity.year;
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
