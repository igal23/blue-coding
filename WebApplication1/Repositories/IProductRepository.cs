using WebApplication1.Entities;

namespace WebApplication1.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetByCode(string code, CancellationToken cancellationToken);

        Task Add(Product product);
    }
}
