using APC.DAL;
using APC.DAL.DAO;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.BLL
{
    internal class AttendanceBLL : IBLL<AttendanceDTO, AttendanceDetailDTO>
    {
        MemberDAO memberDAO = new MemberDAO();
        GenderDAO genderDAO = new GenderDAO();
        AttendanceStatusDAO attendStatusDAO = new AttendanceStatusDAO();
        MonthDAO monthDAO = new MonthDAO();
        AttendanceDAO dao = new AttendanceDAO();
        public bool Delete(AttendanceDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(AttendanceDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(AttendanceDetailDTO entity)
        {
            ATTENDANCE attendance = new ATTENDANCE();
            attendance.attendanceStatusID = entity.AttendanceStatusID;
            attendance.memberID = entity.MemberID;
            attendance.monthlyDues = entity.MonthlyDue;
            attendance.expectedMonthlyDue = entity.ExpectedDue;
            attendance.balance = entity.Balance;
            attendance.day = entity.Day;
            attendance.monthID = entity.MonthID;
            attendance.year = Convert.ToInt32(entity.Year);
            return dao.Insert(attendance);
        }

        public AttendanceDTO Select()
        {
            AttendanceDTO dto = new AttendanceDTO();
            dto.Months = monthDAO.Select();
            dto.AttendanceStatuses = attendStatusDAO.Select();
            dto.Genders = genderDAO.Select();
            dto.Members = memberDAO.Select();
            dto.Attendances = dao.Select();
            dto.AttendanceLists = dao.SelectAttendanceList();
            return dto;
        }

        public bool Update(AttendanceDetailDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
