using Abp.Dependency;
using Evol.Abp.Component.Model;
using Evol.Abp.Dto.Customeres;
using Evol.Abp.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Evol.Abp.Services
{
    public class CustomerService : AdvertAppServiceBase, ICustomerService, ITransientDependency
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddCustomerAsync(CreateCustomerDto dto)
        {
            var customer = new Customer { LoginName = dto.LoginName, Password = dto.Password, Name = dto.Name, Email = dto.Email, Balance = 0, Point = 0, CreateTime = DateTime.Now };
            await _customerRepository.InsertAsync(customer);
        }

        public async Task DeleteCustomerAsync(int customerId)
        {
            await _customerRepository.DeleteAsync(customerId);
        }

        public async Task<bool> UpdateCustomerAsync(UpdateCustomerDto dto)
        {
            return await _customerRepository.UpdateAsync("UPDATE customer SET name=@Name, email=@Email WHERE id=@Id", new { Name = dto.Name, Email = dto.Email, Id = dto.Id });
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            //var list = await _customerRepository.GetAllAsync();
            var list = await _customerRepository.GetAllBySqlAsync();
            return list;
        }

        public async Task<Customer> GetByIdAsync(int customerId)
        {
            var item = await _customerRepository.GetByIdAsync(customerId);
            return item;
        }
    }
}
