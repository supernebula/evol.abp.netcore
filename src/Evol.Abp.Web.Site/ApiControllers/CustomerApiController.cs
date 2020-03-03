using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evol.Abp.Dto.Customeres;
using Evol.Abp.Services;
using Evol.Abp.Web.Site.Controllers;
using Evol.Abp.Web.Site.Models.Customeres;
using Microsoft.AspNetCore.Mvc;

namespace Evol.Abp.Web.Site.ApiControllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerApiController : AdvertControllerBase
    {

        ICustomerService _customerService;

        public CustomerApiController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/customer/all
        [HttpGet("all")]
        public async Task<List<CustomerViewModel>> GetAll()
        {
            var list = await _customerService.GetAllAsync();
            var result = list.Select(e => ObjectMapper.Map<CustomerViewModel>(e)).ToList();
            return result;
        }

        // GET: api/customer/get/1
        [HttpGet("get/{id}")]
        public async Task<CustomerViewModel> Get(int id)
        {
            var item = await _customerService.GetByIdAsync(id);
            var result = ObjectMapper.Map<CustomerViewModel>(item);
            return result;
        }



        // POST: api/customer/add
        [HttpPost("add")]
        public async Task Post([FromBody] CreateCustomerDto dto)
        {
            //var dto = new CreateCustomerDto() { LoginName = "abc", Password = "11", Name = "ABC", Email = "abc@qq.com" };
            await _customerService.AddCustomerAsync(dto);
        }

        // PUT: api/customer/udpate/1
        [HttpPut("udpate/{id}")]
        public async Task<bool> Put(int id, [FromBody] UpdateCustomerDto dto)
        {
            var item = await _customerService.GetByIdAsync(id);
            if (item == null) throw new ArgumentException("没有找到指定id的记录");
            var result = await _customerService.UpdateCustomerAsync(dto);
            return result;
        }


        // DELETE: api/delete/1
        [HttpDelete("delete/{id}")]
        public async Task Delete(int id)
        {
            await _customerService.DeleteCustomerAsync(id);
        }
    }
}
