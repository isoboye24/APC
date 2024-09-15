using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class ConstitutionDAO : APCContexts, IDAO<ConstitutionDetailDTO, CONSTITUTION>
    {
        public bool Delete(CONSTITUTION entity)
        {
            try
            {
                CONSTITUTION constit = db.CONSTITUTIONs.First(x => x.constitutionID == entity.constitutionID);
                constit.isDeleted = true;
                constit.deletedDate = DateTime.Today;
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
                CONSTITUTION constit = db.CONSTITUTIONs.First(x => x.constitutionID == ID);
                constit.isDeleted = false;
                constit.deletedDate = null;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(CONSTITUTION entity)
        {
            try
            {
                db.CONSTITUTIONs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ConstitutionDetailDTO> Select()
        {
            try
            {
                List<ConstitutionDetailDTO> constitutions = new List<ConstitutionDetailDTO>();
                var list = db.CONSTITUTIONs.Where(x => x.isDeleted == false).ToList();
                foreach (var item in list)
                {
                    ConstitutionDetailDTO dto = new ConstitutionDetailDTO();
                    dto.ConstitutionID = item.constitutionID;
                    dto.Section = item.section;
                    dto.ConstitutionText = item.constitution1;
                    dto.Fine = item.fine;
                    dto.FineWithCurrency = "€ " + item.fine;
                    constitutions.Add(dto);
                }
                return constitutions;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public bool Update(CONSTITUTION entity)
        {
            try
            {
                CONSTITUTION constit = new CONSTITUTION();
                constit = db.CONSTITUTIONs.First(x => x.constitutionID == entity.constitutionID);
                constit.constitution1 = entity.constitution1;
                constit.fine = entity.fine;
                constit.section = entity.section;
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
