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
    public class NationalityBLL : IBLL<NationalityDTO, NationalityDetailDTO>
    {
        NationalityDAO dao = new NationalityDAO();
        public bool Delete(NationalityDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(NationalityDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(NationalityDetailDTO entity)
        {
            NATIONALITY nationality = new NATIONALITY();
            nationality.nationality1 = entity.Nationality;
            dao.Insert(nationality);
            return true;
        }

        public NationalityDTO Select()
        {
            NationalityDTO dto = new NationalityDTO();
            dto.Nationalities = dao.Select();
            return dto;
        }

        public bool Update(NationalityDetailDTO entity)
        {
            NATIONALITY nationality = new NATIONALITY();
            nationality.nationalityID = entity.NationalityID;
            nationality.nationality1 = entity.Nationality;
            dao.Update(nationality);
            return true;
        }
    }
}