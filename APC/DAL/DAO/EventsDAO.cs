﻿using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.DAL.DAO
{
    public class EventsDAO : APCContexts, IDAO<EventsDetailDTO, EVENT>
    {
        public bool Delete(EVENT entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(EVENT entity)
        {
            try
            {
                db.EVENTS.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EventsDetailDTO> Select()
        {
            try
            {
                List<EventsDetailDTO> events = new List<EventsDetailDTO>();
                var list = (from e in db.EVENTS.Where(x => x.isDeleted == false)
                            join m in db.MONTHs on e.monthID equals m.monthID
                            select new
                            {
                                eventID = e.eventID,
                                eventTitle = e.title,
                                summary = e.summary,
                                coverImagePath = e.coverImagePath,
                                day = e.day,
                                monthID = e.monthID,
                                monthName = m.monthName,
                                year = e.year
                            }).OrderByDescending(x => x.year).ToList();
                foreach (var item in list)
                {
                    EventsDetailDTO dto = new EventsDetailDTO();
                    dto.EventID = item.eventID;
                    dto.EventTitle = item.eventTitle;
                    dto.Summary = item.summary;
                    dto.CoverImagePath = item.coverImagePath;
                    dto.Day = item.day;
                    dto.MonthID = item.monthID;
                    dto.MonthName = item.monthName;
                    dto.Year = item.year.ToString();
                    events.Add(dto);
                }
                return events;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(EVENT entity)
        {
            try
            {
                EVENT events = db.EVENTS.First(x => x.eventID == entity.eventID);
                events.summary = entity.summary;
                events.title = entity.title;
                events.coverImagePath = entity.coverImagePath;
                events.day = entity.day;
                events.monthID = entity.monthID;
                events.year = entity.year;
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