using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Si;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SisController : ControllerBase
    {
        public ISiService _service { get; set; }
        public SisController(ISiService service)
        {
            _service = service;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Get(id);
                if(result == null)
                    return NotFound();
                     
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}