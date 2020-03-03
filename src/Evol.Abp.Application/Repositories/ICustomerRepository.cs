using Abp.Dependency;
using Evol.Abp.Component.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Evol.Abp.Repositories
{
    public interface ICustomerRepository: ITransientDependency
    {

        Task InsertAsync(Customer item);

        Task DeleteAsync(int customerId);

        Task<bool> UpdateAsync(string sql, object param);

        Task<IEnumerable<Customer>> QueryAsync(string sql, object param);

        Task<Customer> GetByIdAsync(int customerId);

        Task<List<Customer>> GetAllBySqlAsync();
    }
}
