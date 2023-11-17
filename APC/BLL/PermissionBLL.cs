using APC.DAL.DAO;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.BLL
{
    public class PermissionBLL : IBLL<PermissionDTO, PermissionDetailDTO>
    {
        PermissionDAO dao = new PermissionDAO();
        public bool Delete(PermissionDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(PermissionDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PermissionDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public PermissionDTO Select()
        {
            PermissionDTO dto = new PermissionDTO();
            dto.Permissions = dao.Select();
            return dto;
        }

        public bool Update(PermissionDetailDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
