﻿using APC.DAL;
using APC.DAL.DAO;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.BLL
{
    public class GeneralAttendanceBLL : IBLL<GeneralAttendanceDTO, GeneralAttendanceDetailDTO>
    {
        GeneralAttendanceDAO dao = new GeneralAttendanceDAO();
        PersonalAttendanceDAO personalAttendanceDAO = new PersonalAttendanceDAO();
        MonthDAO monthDAO = new MonthDAO();
        public bool Delete(GeneralAttendanceDetailDTO entity)
        {
            GENERAL_ATTENDANCE generalAttendance = new GENERAL_ATTENDANCE();
            generalAttendance.generalAttendanceID = entity.GeneralAttendanceID;
            dao.Delete(generalAttendance);
            PERSONAL_ATTENDANCE personalAttendance = new PERSONAL_ATTENDANCE();
            personalAttendance.generalAttendanceID = entity.GeneralAttendanceID;
            personalAttendanceDAO.Delete(personalAttendance);
            return true;
        }

        public bool GetBack(GeneralAttendanceDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(GeneralAttendanceDetailDTO entity)
        {
            GENERAL_ATTENDANCE generalAttendance = new GENERAL_ATTENDANCE();
            generalAttendance.day = entity.Day;
            generalAttendance.monthID = entity.MonthID;
            generalAttendance.year = Convert.ToInt32(entity.Year);
            generalAttendance.totalMembersPresent = entity.TotalMembersPresent;
            generalAttendance.totalMembersAbsent = entity.TotalMembersAbsent;
            generalAttendance.totalDuesPaid = entity.TotalDuesPaid;
            generalAttendance.totalDuesExpected = entity.TotalDuesExpected;
            generalAttendance.totalDuesBalance = entity.TotalDuesBalance;
            generalAttendance.summary = entity.Summary;
            return dao.Insert(generalAttendance);
        }

        public GeneralAttendanceDTO Select()
        {
            GeneralAttendanceDTO dto = new GeneralAttendanceDTO();
            dto.Months = monthDAO.Select();
            dto.GeneralAttendance = dao.Select();
            return dto;
        }

        public bool Update(GeneralAttendanceDetailDTO entity)
        {
            GENERAL_ATTENDANCE generalAttendance = new GENERAL_ATTENDANCE();
            generalAttendance.generalAttendanceID = entity.GeneralAttendanceID;
            generalAttendance.day = entity.Day;
            generalAttendance.monthID = entity.MonthID;
            generalAttendance.year = Convert.ToInt32(entity.Year);
            generalAttendance.totalMembersPresent = entity.TotalMembersPresent;
            generalAttendance.totalMembersAbsent = entity.TotalMembersAbsent;
            generalAttendance.totalDuesPaid = entity.TotalDuesPaid;
            generalAttendance.totalDuesExpected = entity.TotalDuesExpected;
            generalAttendance.totalDuesBalance = entity.TotalDuesBalance;
            generalAttendance.summary = entity.Summary;
            return dao.Update(generalAttendance);
        }
    }
}