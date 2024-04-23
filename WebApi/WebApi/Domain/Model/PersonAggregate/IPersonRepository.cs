using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain.Model.PersonAggregate;

namespace WebApi.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(int id);
        Task<List<Person>> GetAllAsync();
        Task<int> AddAsync(Person person);
        Task UpdateAsync(int id, Person person);
        Task DeleteAsync(int id);
    }
}
