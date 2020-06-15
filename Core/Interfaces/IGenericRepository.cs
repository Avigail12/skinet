using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
         Task <T> GetByIdAysnc(int id);
         
         Task <IReadOnlyList<T>> ListAllAysnc();

         Task<T> GetEntityWithSpec(ISpecifications<T> spec);

         Task<IReadOnlyList<T>> ListAysnc(ISpecifications<T> spec);
    }
}