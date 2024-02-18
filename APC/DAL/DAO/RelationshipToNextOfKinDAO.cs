using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class RelationshipToNextOfKinDAO:APCContexts
    {
        public List<RelationshipToNextOfKinDetailDTO> Select()
        {
            List<RelationshipToNextOfKinDetailDTO> relationshipsToKin = new List<RelationshipToNextOfKinDetailDTO>();
            var list = db.NEXT_OF_KIN_RELATIONSHIP.ToList();
            foreach (var item in list)
            {
                RelationshipToNextOfKinDetailDTO dto = new RelationshipToNextOfKinDetailDTO();
                dto.RelationshipToKinID = item.ID;
                dto.Relationship = item.RelationToNextOfKin;
                relationshipsToKin.Add(dto);
            }
            return relationshipsToKin;
        }
    }
}
