﻿using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class GeneralAttendanceDAO : APCContexts, IDAO<GeneralAttendanceDetailDTO, GENERAL_ATTENDANCE>
    {
        public bool Delete(GENERAL_ATTENDANCE entity)
        {
            try
            {
                GENERAL_ATTENDANCE generalAttendance = db.GENERAL_ATTENDANCE.First(x=>x.generalAttendanceID == entity.generalAttendanceID);
                generalAttendance.isDeleted = true;
                generalAttendance.deletedDate = DateTime.Today;
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

        public bool Insert(GENERAL_ATTENDANCE entity)
        {
            try
            {
                db.GENERAL_ATTENDANCE.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<GeneralAttendanceDetailDTO> Select()
        {
            try
            {
                List<GeneralAttendanceDetailDTO> generalAttendance = new List<GeneralAttendanceDetailDTO>();
                var list = (from g in db.GENERAL_ATTENDANCE.Where(x => x.isDeleted == false)
                            join m in db.MONTHs on g.monthID equals m.monthID
                            select new
                            {
                                generalAttendanceID = g.generalAttendanceID,
                                day = g.day,
                                monthID = g.monthID,
                                monthName = m.monthName,
                                year = g.year,
                                totalMembersPresent = g.totalMembersPresent,
                                totalMembersAbsent = g.totalMembersAbsent,
                                totalDuesPaid = g.totalDuesPaid,
                                totalDuesExpected = g.totalDuesExpected,
                                totalDuesBalance = g.totalDuesBalance,
                                summary = g.summary,
                            }).OrderByDescending(x => x.year).ThenByDescending(x=>x.monthID).ToList();
                foreach (var item in list)
                {
                    GeneralAttendanceDetailDTO dto = new GeneralAttendanceDetailDTO();
                    dto.GeneralAttendanceID = item.generalAttendanceID;
                    dto.Day = item.day;
                    dto.MonthID = item.monthID;
                    dto.Month = item.monthName;
                    dto.Year = item.year.ToString();
                    dto.TotalMembersPresent = (int)item.totalMembersPresent;
                    dto.TotalMembersAbsent = (int)item.totalMembersAbsent;
                    dto.TotalDuesPaid = (decimal)item.totalDuesPaid;
                    dto.TotalDuesExpected = (decimal)item.totalDuesExpected;
                    dto.TotalDuesBalance = (decimal)item.totalDuesBalance;
                    dto.Summary = item.summary;
                    generalAttendance.Add(dto);
                }
                return generalAttendance;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        public bool Update(GENERAL_ATTENDANCE entity)
        {
            try
            {
                GENERAL_ATTENDANCE generalAttendance = db.GENERAL_ATTENDANCE.First(x=>x.generalAttendanceID == entity.generalAttendanceID);
                generalAttendance.summary = entity.summary;
                generalAttendance.day = entity.day;
                generalAttendance.monthID = entity.monthID;
                generalAttendance.year = entity.year;
                generalAttendance.totalMembersPresent = entity.totalMembersPresent;
                generalAttendance.totalMembersAbsent = entity.totalMembersAbsent;
                generalAttendance.totalDuesPaid = entity.totalDuesPaid;
                generalAttendance.totalDuesExpected = entity.totalDuesExpected;
                generalAttendance.totalDuesBalance = entity.totalDuesBalance;
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