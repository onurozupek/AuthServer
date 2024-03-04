using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        IQueryable<TEntity> Where(Expression<Func<TEntity,bool>> predicate);

        //product = productRepository.where(x=>x.id>5); id si 5 ten büyük olanlar geldi
        //Henüz db ye yansımadı
        //product.ToList dediğin zaman tek bir sorguya dönüştürülüp çağırılır o zaman db ye yansır.

        Task AddAsync(TEntity entity);
        void Remove(TEntity entity);
        TEntity Update(TEntity entity);
    }
}
