using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticalAssignmentAPIOlderVersion.Business.Models;
using PracticalAssignmentAPIOlderVersion.Business.Services;
using PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalAssignmentAPIOlderVersion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<KService, TEntity, TResponseModel,TRequestModel> : ControllerBase 
        where KService : IBaseService<TEntity, TRequestModel, TResponseModel>
        where TEntity : BaseEntity
        where TRequestModel : BaseRequestModel
        where TResponseModel : BaseResponseModel
    {
        protected readonly KService service;
        public BaseController(KService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var models = await service.GetAllAsync();

            return Ok(models);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var model = await service.GetByIdAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TRequestModel requestModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            await service.CreateAsync(requestModel);
            return Ok();
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Delete([FromRoute]Guid id)
        {
            try
            {
                await service.DeleteAsync(id);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpPut("id")]
        public async Task<IActionResult> Update(TRequestModel requestModel,[FromRoute] Guid id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await service.UpdateAsync(id, requestModel);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

    }
}
