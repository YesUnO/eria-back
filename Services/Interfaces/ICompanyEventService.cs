using eria_back.DB.Entity;
using eria_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eria_back.Services.Interfaces
{
    public interface ICompanyEventService
    {
        CompanyEvent SaveEvent(CompanyEventModel model);
        void DeleteEvent(int id);
        public Task<List<CompanyEvent>> GetAllEvents();
    }
}
