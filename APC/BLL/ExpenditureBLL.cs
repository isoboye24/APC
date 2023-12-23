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
    public class ExpenditureBLL : IBLL<ExpenditureDTO, ExpenditureDetailDTO>
    {
        ExpenditureDAO dao = new ExpenditureDAO();
        MonthDAO monthDAO = new MonthDAO();
        public bool Delete(ExpenditureDetailDTO entity)
        {
            EXPENDITURE expenditure = new EXPENDITURE();
            expenditure.expenditureID = entity.ExpenditureID;
            return dao.Delete(expenditure);
        }

        public bool GetBack(ExpenditureDetailDTO entity)
        {
            return dao.GetBack(entity.ExpenditureID);
        }

        public bool Insert(ExpenditureDetailDTO entity)
        {
            EXPENDITURE expendtiure = new EXPENDITURE();
            expendtiure.summary = entity.Summary;
            expendtiure.amountSpent = entity.AmountSpent;
            expendtiure.day = entity.Day;
            expendtiure.monthID = entity.MonthID;
            expendtiure.year = Convert.ToInt32(entity.Year);
            return dao.Insert(expendtiure);
        }

        public ExpenditureDTO Select()
        {
            ExpenditureDTO dto = new ExpenditureDTO();
            dto.Expenditures = dao.Select();
            dto.Months = monthDAO.Select();
            return dto;
        }

        public bool Update(ExpenditureDetailDTO entity)
        {
            EXPENDITURE expendtiure = new EXPENDITURE();
            expendtiure.expenditureID = entity.ExpenditureID;
            expendtiure.summary = entity.Summary;
            expendtiure.amountSpent = entity.AmountSpent;
            expendtiure.day = entity.Day;
            expendtiure.monthID = entity.MonthID;
            expendtiure.year = Convert.ToInt32(entity.Year);
            return dao.Update(expendtiure);
        }
    }
}
