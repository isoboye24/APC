﻿using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class ProfessionDAO : APCContexts, IDAO<ProfessionDetailDTO, PROFESSION>
    {
        public bool Delete(PROFESSION entity)
        {
            try
            {
                PROFESSION profession = db.PROFESSIONs.First(x => x.professionID == entity.professionID);
                profession.isDeleted = true;
                profession.deletedDate = DateTime.Today;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PROFESSION entity)
        {
            try
            {
                db.PROFESSIONs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProfessionDetailDTO> Select()
        {
            try
            {
                List<ProfessionDetailDTO> professions = new List<ProfessionDetailDTO>();
                var list = db.PROFESSIONs.Where(x => x.isDeleted == false).ToList();
                foreach (var item in list)
                {
                    ProfessionDetailDTO dto = new ProfessionDetailDTO();
                    dto.ProfessionID = item.professionID;
                    dto.Profession = item.profession1;
                    professions.Add(dto);
                }
                return professions;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Count()
        {
            try
            {
                int numberOfProfession = db.PROFESSIONs.Count(x => x.isDeleted == false);
                return numberOfProfession;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool Update(PROFESSION entity)
        {
            try
            {
                PROFESSION profession = db.PROFESSIONs.First(x => x.professionID == entity.professionID);
                profession.profession1 = entity.profession1;
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