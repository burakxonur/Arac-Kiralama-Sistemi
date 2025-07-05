using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.İnterfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIDAsync(int id);
        Task CreateAsync(T entity);
        Task UpdatedAsync(T entity);
        Task RemoveAsync(T entity);
        Task<T?> GetByFılterAsync(Expression<Func<T, bool>> filter);
    }
}
