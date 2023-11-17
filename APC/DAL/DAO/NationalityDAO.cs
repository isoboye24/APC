using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class NationalityDAO : APCContexts, IDAO<NationalityDetailDTO, NATIONALITY>
    {
        public bool Delete(NATIONALITY entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(NATIONALITY entity)
        {
            try
            {
                db.NATIONALITies.Add(entity);                
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NationalityDetailDTO> Select()
        {
            try
            {
                List<NationalityDetailDTO> nationalities = new List<NationalityDetailDTO>();
                var list = db.NATIONALITies.Where(x=>x.isDeleted==false);
                foreach (var item in list)
                {
                    NationalityDetailDTO dto = new NationalityDetailDTO();
                    dto.NationalityID = item.nationalityID;
                    dto.Nationality = item.nationality1;
                    nationalities.Add(dto);
                }
                return nationalities;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(NATIONALITY entity)
        {
            try
            {
                NATIONALITY nationality = db.NATIONALITies.First(x => x.nationalityID == entity.nationalityID);
                nationality.nationality1 = entity.nationality1;
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
