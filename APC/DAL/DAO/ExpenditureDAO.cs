﻿using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class ExpenditureDAO : APCContexts, IDAO<ExpenditureDetailDTO, EXPENDITURE>
    {
        public bool Delete(EXPENDITURE entity)
        {
            try
            {
                EXPENDITURE expenditure = db.EXPENDITUREs.First(x => x.expenditureID == entity.expenditureID);
                expenditure.isDeleted = true;
                expenditure.deletedDate = DateTime.Today;
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

        public bool Insert(EXPENDITURE entity)
        {
            try
            {
                db.EXPENDITUREs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExpenditureDetailDTO> Select()
        {
            try
            {
                List<ExpenditureDetailDTO> expenditures = new List<ExpenditureDetailDTO>();
                var list = (from e in db.EXPENDITUREs.Where(x => x.isDeleted == false)
                            join m in db.MONTHs on e.monthID equals m.monthID
                            select new
                            {
                                expenditureID = e.expenditureID,
                                amountSpent = e.amountSpent,
                                summary = e.summary,
                                day = e.day,
                                monthID = e.monthID,
                                monthName = m.monthName,
                                year = e.year,
                            }).OrderByDescending(x => x.year).ToList();
                foreach (var item in list)
                {
                    ExpenditureDetailDTO dto = new ExpenditureDetailDTO();
                    dto.ExpenditureID = item.expenditureID;
                    dto.Summary = item.summary;
                    dto.AmountSpent = item.amountSpent;
                    dto.Day = item.day;
                    dto.MonthID = item.monthID;
                    dto.Month = item.monthName;
                    dto.Year = item.year.ToString();
                    expenditures.Add(dto);
                }
                return expenditures;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(EXPENDITURE entity)
        {
            try
            {
                EXPENDITURE expenditure = db.EXPENDITUREs.First(x => x.expenditureID == entity.expenditureID);
                expenditure.summary = entity.summary;
                expenditure.amountSpent = entity.amountSpent;
                expenditure.day = entity.day;
                expenditure.monthID = entity.monthID;
                expenditure.year = entity.year;
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