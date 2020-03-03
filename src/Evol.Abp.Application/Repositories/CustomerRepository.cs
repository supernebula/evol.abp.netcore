using Abp.Data;
using Abp.Dependency;
using Evol.Abp.Component.Model;
using Evol.Abp.Dapper.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evol.Abp.Repositories
{

    
    public class CustomerRepository : AdvertDapperRepositoryBase<Customer>, ICustomerRepository, ITransientDependency
    {
        public CustomerRepository(IActiveTransactionProvider activeTransactionProvider)
            : base(activeTransactionProvider)
        {
        }


        public async Task DeleteAsync(int customerId)
        {
            await this.ExecuteAsync("DELETE FROM customer WHERE id=@Id", new { Id = customerId });
   
        }

        public async Task<Customer> GetByIdAsync(int customerId)
        {
            var list = await QueryAsync("SELECT * FROM customer WHERE id=@Id", new { Id = customerId });
            return list.FirstOrDefault();
        }

        public async Task<bool> UpdateAsync(string sql, object param)
        {
            var count = await this.ExecuteAsync(sql, param);
            return count > 0;
        }

        public async Task<List<Customer>> GetAllBySqlAsync()
        {
            var list = await QueryAsync("SELECT * FROM customer", null);
            return list.ToList();
        }


    }
}
