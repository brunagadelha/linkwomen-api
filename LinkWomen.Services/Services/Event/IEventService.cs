
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Services.Services
{
    public interface IEventService
    {
        void Add(Event @event);
        void Update(Event @event);
        void Delete(Event @event);
        Event GetById(int id);
        IEnumerable<Event> GetAll();
    }
}
