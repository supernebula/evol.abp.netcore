using Abp.Dapper.Repositories;
using Abp.Data;
using Abp.Domain.Entities;
using Evol.Abp.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Evol.Abp.Dapper.Repositories
{
    public class AdvertDapperRepositoryBase<TEntity> : DapperEfRepositoryBase<AdvertDbContext, TEntity> where TEntity : class, IEntity<int>
    {
        public AdvertDapperRepositoryBase(IActiveTransactionProvider activeTransactionProvider) : base(activeTransactionProvider)
        {
        }

        public async Task InsertBySqlAsync(string sql, object param)
        {
            await this.ExecuteAsync(sql, param);
        }

        public async Task DeleteBySqlAsync(string sql, object param)
        {
            await this.ExecuteAsync(sql, param);
        }

        public async Task UpdateBySqlAsync(string sql, object param)
        {
            await this.ExecuteAsync(sql, param);
        }

    }
}
