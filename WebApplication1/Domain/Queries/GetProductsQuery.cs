using WebApplication1.Repositories;

namespace WebApplication1.Domain.Queries
{
    public record GetProductsQuery(string Code);

    public record GetProductsResponse(IEnumerable<ProducDetails> Products);

    public record ProducDetails(string Code, string Name);

    public class GetProductsQueryHandler
    {
        private readonly IProductRepository _productRepository;

        public GetProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetProductsResponse> Handle(GetProductsQuery query, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetByCode(query.Code, cancellationToken);

            return new 
                GetProductsResponse(products.Select(x => new ProducDetails(x.Code, x.Name)));
        }
    }
}
