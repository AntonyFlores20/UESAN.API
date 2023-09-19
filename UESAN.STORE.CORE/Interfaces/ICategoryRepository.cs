using UESAN.STORE.CORE.Entities;

namespace UESAN.Store.CORE.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetALL();
    }
}