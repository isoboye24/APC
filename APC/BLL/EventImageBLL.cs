using APC.DAL;
using APC.DAL.DAO;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC.BLL
{
    public class EventImageBLL : IBLL<EventImageDTO, EventImageDetailDTO>
    {
        EventImageDAO dao = new EventImageDAO();
        public bool Delete(EventImageDetailDTO entity)
        {
            EVENT_IMAGE eventImage = new EVENT_IMAGE();
            eventImage.eventImageID = entity.EventImageID;
            return dao.Delete(eventImage);
        }

        public bool GetBack(EventImageDetailDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(EventImageDetailDTO entity)
        {
            EVENT_IMAGE eventImage = new EVENT_IMAGE();
            eventImage.eventID = entity.EventID;
            eventImage.summary = entity.Summary;
            eventImage.imageCaption = entity.ImageCaption;
            eventImage.imagePath = entity.ImagePath;
            return dao.Insert(eventImage);
        }

        public EventImageDTO Select()
        {
            EventImageDTO dto = new EventImageDTO();
            dto.EventImages = dao.Select();
            return dto;
        }

        public bool Update(EventImageDetailDTO entity)
        {
            EVENT_IMAGE eventImage = new EVENT_IMAGE();
            eventImage.eventImageID = entity.EventImageID;
            eventImage.eventID = entity.EventID;
            eventImage.summary = entity.Summary;
            eventImage.imageCaption = entity.ImageCaption;
            eventImage.imagePath = entity.ImagePath;
            return dao.Update(eventImage);
        }
    }
}
