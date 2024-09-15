using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class FinedMemberDAO : APCContexts, IDAO<FinedMemberDetailDTO, FINED_MEMBER>
    {
        public bool Delete(FINED_MEMBER entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(FINED_MEMBER entity)
        {
            throw new NotImplementedException();
        }

        public List<FinedMemberDetailDTO> Select()
        {
            throw new NotImplementedException();
        }

        public bool Update(FINED_MEMBER entity)
        {
            throw new NotImplementedException();
        }
    }
}
