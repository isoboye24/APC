using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class GenderDAO : APCContexts, IDAO<GenderDetailDTO, GENDER>
    {
        public bool Delete(GENDER entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(GENDER entity)
        {
            throw new NotImplementedException();
        }

        public List<GenderDetailDTO> Select()
        {
            try
            {
                List<GenderDetailDTO> genders = new List<GenderDetailDTO>();
                var list = db.GENDERs.ToList();
                foreach (var item in list)
                {
                    GenderDetailDTO dto = new GenderDetailDTO();
                    dto.GenderID = item.genderID;
                    dto.GenderName = item.genderName;
                    genders.Add(dto);
                }
                return genders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(GENDER entity)
        {
            throw new NotImplementedException();
        }
    }
}
