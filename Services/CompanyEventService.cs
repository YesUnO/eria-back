using eria_back.DB.Data;
using eria_back.DB.Entity;
using eria_back.Models;
using eria_back.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eria_back.Services
{
    public class CompanyEventService : ICompanyEventService
    {
        private EriaContext _context;
        public CompanyEventService(EriaContext eriaContext)
        {
            _context = eriaContext;
        }

        public void DeleteEvent(int id)
        {
            CompanyEvent companyEvent = new CompanyEvent() { Id = id };
            _context.CompanyEvents.Attach(companyEvent);
            _context.CompanyEvents.Remove(companyEvent);
            _context.SaveChanges(); 

        }

        public async Task<List<CompanyEvent>> GetAllEvents()
        {
            return await  _context.CompanyEvents.ToListAsync();
        }

        public CompanyEvent SaveEvent(CompanyEventModel model)
        {
            CompanyEvent companyEvent;
            companyEvent = new CompanyEvent
            {
                Id = model.Id,
                Name = model.Name,
                TimeFrom = model.TimeFrom,
                TimeTo = model.TimeTo,
                Type = model.Type
            };
            _context.Add(companyEvent);
            _context.SaveChanges();
            return companyEvent;
        }
    }
}
