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
    public class ProfessionBLL : IBLL<ProfessionDTO, ProfessionDetailDTO>
    {
        ProfessionDAO dao = new ProfessionDAO();
        public bool Delete(ProfessionDetailDTO entity)
        {
            PROFESSION profession = new PROFESSION();
            profession.professionID = entity.ProfessionID;
            return dao.Delete(profession);
        }

        public bool GetBack(ProfessionDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ProfessionDetailDTO entity)
        {
            PROFESSION profession = new PROFESSION();
            profession.profession1 = entity.Profession;
            return dao.Insert(profession);
        }

        public ProfessionDTO Select()
        {
            ProfessionDTO profession = new ProfessionDTO();
            profession.Professions = dao.Select();
            return profession;
        }

        public int ProfessionCount()
        {
            return dao.Count();
        }

        public bool Update(ProfessionDetailDTO entity)
        {
            PROFESSION profession = new PROFESSION();
            profession.professionID = entity.ProfessionID;
            profession.profession1 = entity.Profession;
            return dao.Update(profession);
        }
    }
}