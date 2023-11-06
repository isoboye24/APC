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
    public class GenderBLL : IBLL<GenderDTO, GenderDetailDTO>
    {
        GenderDAO dao = new GenderDAO();
        public bool Delete(GenderDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(GenderDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(GenderDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public GenderDTO Select()
        {
            GenderDTO dto = new GenderDTO();
            dto.Genders = dao.Select();
            return dto;
        }

        public bool Update(GenderDetailDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
