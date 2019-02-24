
namespace Shop.Web.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    public interface IGenericRepository<T> where T : class
    {
        // devuelve una lista de T que es lo que yo le ponga
        IQueryable<T> GetAll();

        // devuelve una lista de T que es lo que yo le ponga
        Task<T> GetByIdAsync(int id);

        // devuelve una lista de T que es lo que yo le ponga
        Task CreateAsync(T entity);

        // devuelve una lista de T que es lo que yo le ponga
        Task UpdateAsync(T entity);

        // devuelve una lista de T que es lo que yo le ponga
        Task DeleteAsync(T entity);

        Task<bool> ExistAsync(int id);
    }

}
