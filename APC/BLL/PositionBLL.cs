﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APC.DAL;
using APC.DAL.DAO;
using APC.DAL.DTO;

namespace APC.BLL
{
    public class PositionBLL : IBLL<PositionDTO, PositionDetailDTO>
    {
        PositionDAO dao = new PositionDAO();
        public bool Delete(PositionDetailDTO entity)
        {
            POSITION position = new POSITION();
            position.positionID = entity.PositionID;            
            return dao.Delete(position);
        }

        public bool GetBack(PositionDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PositionDetailDTO entity)
        {
            POSITION position = new POSITION();
            position.positionName = entity.PositionName;
            return dao.Insert(position);
        }

        public PositionDTO Select()
        {
            PositionDTO dto = new PositionDTO();
            dto.Positions = dao.Select();
            return dto;
        }

        public bool Update(PositionDetailDTO entity)
        {
            POSITION position = new POSITION();
            position.positionID = entity.PositionID;
            position.positionName = entity.PositionName;
            return dao.Update(position);
        }
    }
}