using MediatR;
using WebApplication1.Domain.Models;
using WebApplication1.Entities;
using WebApplication1.Repositories;

namespace WebApplication1.Domain.Commands
{
    public record CreateProductCommand(string Name, string Code): IRequest<ApplicationResponseResult<EmptyResult>>;

    public class CreateProductCommandHandler
            : IRequestHandler<CreateProductCommand, ApplicationResponseResult<EmptyResult>>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ApplicationResponseResult<EmptyResult>> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var result = new ApplicationResponseResult<EmptyResult>();

            try
            {
                await _productRepository.Add(new Product
                {
                    Code = command.Code,
                    Name = command.Name,
                });

                result.Success();
            }
            catch (Exception e)
            {
                result.AddErrorMessage(e.Message);
                result.Failure();
            }

            return result;
        }
    }
}
