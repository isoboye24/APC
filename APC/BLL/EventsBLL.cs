﻿using APC.DAL;
using APC.DAL.DAO;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.BLL
{
    public class EventsBLL : IBLL<EventsDTO, EventsDetailDTO>
    {
        EventsDAO dao = new EventsDAO();
        public bool Delete(EventsDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(EventsDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(EventsDetailDTO entity)
        {
            EVENT events = new EVENT();
            events.summary = entity.Summary;
            events.title = entity.EventTitle;
            events.coverImagePath = entity.CoverImagePath;
            events.day = entity.Day;
            events.monthID = entity.MonthID;
            events.year = Convert.ToInt32(entity.Year);
            return dao.Insert(events);
        }

        public EventsDTO Select()
        {
            EventsDTO dto = new EventsDTO();
            dto.Events = dao.Select();
            return dto;
        }

        public bool Update(EventsDetailDTO entity)
        {
            EVENT events = new EVENT();
            events.eventID = entity.EventID;
            events.summary = entity.Summary;
            events.title = entity.EventTitle;
            events.coverImagePath = entity.CoverImagePath;
            events.day = entity.Day;
            events.monthID = entity.MonthID;
            events.year = Convert.ToInt32(entity.Year);
            return dao.Update(events);
        }
    }
}