﻿using APC.BLL;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class CountryDAO : APCContexts, IDAO<CountryDetailDTO, COUNTRY>
    {
        public bool Delete(COUNTRY entity)
        {
            try
            {
                COUNTRY country = db.COUNTRies.First(x => x.countryID == entity.countryID);
                country.isDeleted = true;
                country.deletedDate = DateTime.Today;
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

        public bool Insert(COUNTRY entity)
        {
            try
            {
                db.COUNTRies.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CountryDetailDTO> Select()
        {
            try
            {
                List<CountryDetailDTO> countries = new List<CountryDetailDTO>();
                var list = db.COUNTRies.Where(x=>x.isDeleted==false).ToList();
                foreach (var item in list)
                {
                    CountryDetailDTO dto = new CountryDetailDTO();
                    dto.CountryID = item.countryID;
                    dto.CountryName = item.countryName;
                    countries.Add(dto);
                }
                return countries;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(COUNTRY entity)
        {
            try
            {
                COUNTRY position = db.COUNTRies.First(x => x.countryID == entity.countryID);
                position.countryName = entity.countryName;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}