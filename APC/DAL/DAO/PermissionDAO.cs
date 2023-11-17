using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace APC.DAL.DAO
{
    public class PermissionDAO : APCContexts, IDAO<PermissionDetailDTO, PERMISSION>
    {
        public bool Delete(PERMISSION entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PERMISSION entity)
        {
            throw new NotImplementedException();
        }

        public List<PermissionDetailDTO> Select()
        {
            List<PermissionDetailDTO> permissions = new List<PermissionDetailDTO>();
            var list = db.PERMISSIONs.Where(x => x.isDeleted == false);
            foreach ( var item in list)
            {
                PermissionDetailDTO dto = new PermissionDetailDTO();
                dto.PermissionID = item.permissionID;
                dto.Permission = item.permission1;
                permissions.Add(dto);
            }
            return permissions;
        }

        public bool Update(PERMISSION entity)
        {
            throw new NotImplementedException();
        }
    }
}
