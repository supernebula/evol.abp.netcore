using Abp.Application.Services;
using Abp.Dependency;
using Evol.Abp.Component.Model;
using Evol.Abp.Dto.Customeres;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Evol.Abp.Services
{
    public interface ICustomerService : IApplicationService, ITransientDependency
    {
        Task AddCustomerAsync(CreateCustomerDto dto);

        Task DeleteCustomerAsync(int customerId);

        Task<bool> UpdateCustomerAsync(UpdateCustomerDto dto);

        Task<List<Customer>> GetAllAsync();

        Task<Customer> GetByIdAsync(int customerId);
    }
}
