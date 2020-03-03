//using Abp.Dapper.Repositories;
//using Abp.Dependency;
//using Evol.Abp.Component.Model;
//using Evol.Abp.Dto.Customeres;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Evol.Abp.Services
//{
//    public class CustomerService1 : ICustomerService, ITransientDependency
//    {
//        private readonly IDapperRepository<Customer> _customerDapperRepository;

//        public CustomerService1(IDapperRepository<Customer> customerDapperRepository)
//        {
//            _customerDapperRepository = customerDapperRepository;
//        }

//        public async Task AddCustomerAsync(CreateCustomerDto dto)
//        {
//            var customer = new Customer { LoginName = dto.LoginName, Password = dto.Password, Name = dto.Name, Email = dto.Email, Balance = 0, Point = 0, CreateTime = DateTime.Now };
//            await _customerDapperRepository.InsertAsync(customer);
//        }

//        public async Task DeleteCustomerAsync(int customerId)
//        {
//            //await _customerDapperRepository.DeleteAsync(e => e.Id == id);
//            await _customerDapperRepository.ExecuteAsync("DELETE FROM customer WHERE id=@Id", new { Id = customerId });
//        }

//        public async Task<bool> UpdateCustomerAsync(UpdateCustomerDto dto)
//        {
//            var count = await _customerDapperRepository.ExecuteAsync("UPDATE customer SET name=@Name, email=@Email WHERE id=@Id", new { Name = dto.Name, Email = dto.Email, Id = dto.Id });
//            return count > 0;
//        }

//        public async Task<List<Customer>> GetAllAsync()
//        {
//            //var list = await _customerDapperRepository.GetAllAsync();
//            var list = await _customerDapperRepository.QueryAsync("SELECT * FROM customer");
//            return list.ToList();
//        }

//        public async Task<Customer> GetByIdAsync(int customerId)
//        {
//            var list = await _customerDapperRepository.QueryAsync("SELECT * FROM customer WHERE id=@Id", new { Id = customerId });
//            return list.FirstOrDefault();
//            //var item = _customerDapperRepository.FirstOrDefaultAsync(e => e.Id == customerId);
//            //return item;
//        }
//    }
//}
