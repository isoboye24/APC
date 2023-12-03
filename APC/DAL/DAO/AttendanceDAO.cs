using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    internal class AttendanceDAO : APCContexts, IDAO<AttendanceDetailDTO, ATTENDANCE>
    {
        public bool Delete(ATTENDANCE entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ATTENDANCE entity)
        {
            try
            {
                db.ATTENDANCEs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AttendanceDetailDTO> Select()
        {
            try
            {
                List<AttendanceDetailDTO> attendances = new List<AttendanceDetailDTO>();
                var list = (from a in db.ATTENDANCEs.Where(x => x.isDeleted == false)
                            join ats in db.ATTENDANCE_STATUS on a.attendanceStatusID equals ats.attendanceStatusID
                            join m in db.MONTHs on a.monthID equals m.monthID
                            join mem in db.MEMBERs on a.memberID equals mem.memberID
                            join g in db.GENDERs on mem.genderID equals g.genderID
                            select new
                            {
                                attendanceID = a.attendanceID,
                                attendanceStatusID = a.attendanceStatusID,
                                attendanceStatusName = ats.attendanceStatus,
                                day = a.day,
                                monthID = a.monthID,
                                monthName = m.monthName,
                                year = a.year,
                                memberID = a.memberID,
                                surname = mem.surname,
                                name = mem.name,
                                imagePath = mem.imagePath,
                                genderID = mem.genderID,
                                genderName = g.genderName,
                                monthlyDue = a.monthlyDues,
                                expectedMonthlyDue = a.expectedMonthlyDue,
                                balance = a.balance,
                            }).OrderByDescending(x => x.year).ToList();
                foreach (var item in list)
                {
                    AttendanceDetailDTO dto = new AttendanceDetailDTO();
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
                    dto.MonthlyDue = (int)item.monthlyDue;
                    dto.ExpectedDue = item.expectedMonthlyDue;
                    dto.Balance = item.balance;
                    attendances.Add(dto);
                }
                return attendances;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public List<AttendanceListDetailDTO> SelectAttendanceList()
        {
            try
            {
                List<AttendanceListDetailDTO> attendanceList = new List<AttendanceListDetailDTO>();
                List<string> months = new List<string>();
                List<string> allMonths = new List<string>();
                List<int> years = new List<int>();
                List<int> allYears = new List<int>();

                var list = (from a in db.ATTENDANCEs.Where(x => x.isDeleted == false)
                            join ats in db.ATTENDANCE_STATUS on a.attendanceStatusID equals ats.attendanceStatusID
                            join m in db.MONTHs on a.monthID equals m.monthID
                            join mem in db.MEMBERs on a.memberID equals mem.memberID
                            join g in db.GENDERs on mem.genderID equals g.genderID
                            select new
                            {
                                attendanceID = a.attendanceID,
                                yearName = a.year,
                            }).OrderByDescending(x => x.yearName).ToList();
                foreach (var item in list)
                {
                    years.Add(item.yearName);
                }
                allYears = years.Distinct().ToList();
                foreach (var oneYear in allYears)
                {
                    var monthList = (from a in db.ATTENDANCEs.Where(x => x.isDeleted == false && x.year == oneYear)
                                     join ats in db.ATTENDANCE_STATUS on a.attendanceStatusID equals ats.attendanceStatusID
                                     join m in db.MONTHs on a.monthID equals m.monthID
                                     join mem in db.MEMBERs on a.memberID equals mem.memberID
                                     join g in db.GENDERs on mem.genderID equals g.genderID
                                     select new
                                     {
                                         attendanceID = a.attendanceID,
                                         monthID = a.monthID,
                                         monthName = m.monthName,
                                         yearName = a.year,
                                     }).OrderByDescending(x => x.yearName).ThenByDescending(x => x.monthID).ToList();
                    foreach (var item2 in monthList)
                    {
                        months.Add(item2.monthName);
                    }
                    allMonths = months.Distinct().ToList();
                    
                    foreach (var oneMonth in allMonths)
                    {
                        List<int> totalMembers = new List<int>();
                        List<int> totalMale = new List<int>();
                        List<int> totalFemale = new List<int>();
                        List<int> totalMonthlyBalance = new List<int>();
                        List<int> totalMonthlyDuesExpected = new List<int>();
                        List<int> totalMonthlyDues = new List<int>();
                        List<int> monthIDs = new List<int>();
                        AttendanceListDetailDTO dto = new AttendanceListDetailDTO();
                        dto.AttendanceListID += 1;
                        var inOneMonthList = (from a in db.ATTENDANCEs.Where(x => x.isDeleted == false && x.year == oneYear)
                                              join ats in db.ATTENDANCE_STATUS on a.attendanceStatusID equals ats.attendanceStatusID
                                              join m in db.MONTHs.Where(x => x.monthName == oneMonth) on a.monthID equals m.monthID
                                              join mem in db.MEMBERs on a.memberID equals mem.memberID
                                              join g in db.GENDERs on mem.genderID equals g.genderID
                                              select new
                                              {
                                                  attendanceID = a.attendanceID,
                                                  attendanceStatusID = a.attendanceStatusID,
                                                  attendanceStatusName = ats.attendanceStatus,
                                                  day = a.day,
                                                  monthID = a.monthID,
                                                  monthName = m.monthName,
                                                  year = a.year,
                                                  memberID = a.memberID,
                                                  surname = mem.surname,
                                                  name = mem.name,
                                                  imagePath = mem.imagePath,
                                                  genderID = mem.genderID,
                                                  genderName = g.genderName,
                                                  monthlyDue = a.monthlyDues,
                                                  expectedMonthlyDue = a.expectedMonthlyDue,
                                                  balance = a.balance,
                                              }).ToList();
                        foreach (var item3 in inOneMonthList)
                        {

                            if (item3.attendanceStatusName == "Present")
                            {
                                totalMembers.Add(item3.memberID);
                            }
                            if (item3.genderName == "Male")
                            {
                                totalMale.Add(item3.genderID);
                            }
                            if (item3.genderName == "Female")
                            {
                                totalFemale.Add(item3.genderID);
                            }
                            totalMonthlyBalance.Add(Convert.ToInt32(item3.balance));
                            totalMonthlyDuesExpected.Add(Convert.ToInt32(item3.expectedMonthlyDue));
                            totalMonthlyDues.Add(Convert.ToInt32(item3.monthlyDue));
                            dto.MonthID = item3.monthID;
                        }
                        var theTotalMembers = totalMembers.Distinct().ToList();
                        dto.TotalMembers = theTotalMembers.Count();
                        dto.TotalMale = totalMale.Count();
                        dto.TotalFemale = totalFemale.Count();
                        dto.TotalDuesBalance = totalMonthlyBalance.Sum();
                        dto.TotalDuesExpected = totalMonthlyDuesExpected.Sum();
                        dto.TotalDuesPaid = totalMonthlyDues.Sum();
                        dto.Month = oneMonth.ToString();
                        dto.Year = oneYear.ToString();
                        attendanceList.Add(dto);
                    }
                }
                return attendanceList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(ATTENDANCE entity)
        {
            throw new NotImplementedException();
        }
    }
}
