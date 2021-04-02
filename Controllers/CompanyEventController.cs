using eria_back.DB.Entity;
using eria_back.Models;
using eria_back.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eria_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyEventController : ControllerBase
    {
        private ICompanyEventService _companyEventService;
        public CompanyEventController(ICompanyEventService companyEventService)
        {
            _companyEventService = companyEventService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyEvent>>> GetAll()
        {
            return await _companyEventService.GetAllEvents();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            _companyEventService.DeleteEvent(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Save(CompanyEventModel model)
        {
            var response = _companyEventService.SaveEvent(model);
            return Ok();
        }
    }
}
