using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class FinancialReportDAO : APCContexts, IDAO<FinancialReportDetailDTO, FINANCIAL_REPORT>
    {
        public bool Delete(FINANCIAL_REPORT entity)
        {
            try
            {
                FINANCIAL_REPORT financialReport = db.FINANCIAL_REPORT.First(x=>x.financialReportID == entity.financialReportID);
                financialReport.isDeleted = true;
                financialReport.deletedDate = DateTime.Today;
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

        public bool Insert(FINANCIAL_REPORT entity)
        {
            try
            {
                db.FINANCIAL_REPORT.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<FinancialReportDetailDTO> Select()
        {
            try
            {
                List<FinancialReportDetailDTO> financialReport = new List<FinancialReportDetailDTO>();
                var list = db.FINANCIAL_REPORT.Where(x => x.isDeleted == false);
                foreach (var item in list)
                {
                    FinancialReportDetailDTO dto = new FinancialReportDetailDTO();
                    dto.FinancialReportID = item.financialReportID;
                    dto.TotalAmountRaised = item.totalAmountRaised;
                    dto.TotalAmountSpent = item.totalAmountSpent;
                    dto.Year = item.year.ToString();
                    dto.Summary = item.summary;
                    financialReport.Add(dto);
                }
                return financialReport;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal SelectTotalRaisedAmount()
        {
            try
            {                
                List<decimal> totalRaisedAmount = new List<decimal>();
                var list = db.FINANCIAL_REPORT.Where(x => x.isDeleted == false);
                foreach (var item in list)
                {
                    FinancialReportDetailDTO dto = new FinancialReportDetailDTO();
                    dto.FinancialReportID = item.financialReportID;
                    totalRaisedAmount.Add(item.totalAmountRaised);
                }
                decimal totalAmount = totalRaisedAmount.Sum();
                return totalAmount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal SelectTotalSpentAmount()
        {
            try
            {
                List<decimal> totalSpentAmount = new List<decimal>();
                var list = db.FINANCIAL_REPORT.Where(x => x.isDeleted == false);
                foreach (var item in list)
                {
                    FinancialReportDetailDTO dto = new FinancialReportDetailDTO();
                    dto.FinancialReportID = item.financialReportID;
                    totalSpentAmount.Add(item.totalAmountSpent);
                }
                decimal totalAmount = totalSpentAmount.Sum();
                return totalAmount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(FINANCIAL_REPORT entity)
        {
            try
            {
                FINANCIAL_REPORT financialReport = db.FINANCIAL_REPORT.First(x => x.financialReportID == entity.financialReportID);
                financialReport.summary = entity.summary;
                financialReport.year = entity.year;
                financialReport.totalAmountRaised = entity.totalAmountRaised;
                financialReport.totalAmountSpent = entity.totalAmountSpent;
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
