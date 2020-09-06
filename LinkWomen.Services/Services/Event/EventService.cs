using LinkWomen.Data.Repositories;
using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkWomen.Services.Services
{
    public class EventService : IEventService
    {
        private readonly IGenericRepository<Event> _eventRepository; 

        public EventService(IGenericRepository<Event> eventRepository)
        {
            _eventRepository = eventRepository; 
        }

        public void Add(Event @event)
        {
            @event.CreatedAt = DateTime.Now; 
            _eventRepository.Add(@event); 
        }

        public void Delete(Event @event)
        {
            @event.Deleted = true; 
            _eventRepository.Update(@event);
        }

        public IEnumerable<Event> GetAll()
        {
            return _eventRepository.GetAll().Where(x => x.Active && !x.Deleted).ToList(); 
        }

        public Event GetById(int id)
        {
            return _eventRepository.GetById(id);
        }

        public void Update(Event @event)
        {
            @event.UpdatedAt = DateTime.Now;
            _eventRepository.Update(@event);
        }
    }
}
