using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domain.Queries;

namespace WebApplication1.Endpoints
{
    public class GetProductsEndpoint : EndpointBase
    {
        public record GetProductRequest(string Name);
        public GetProductsEndpoint(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [ApiVersion("1.0")]
        public ActionResult GetProducts(GetProductRequest request)
        {
            return Ok(_mediator.Send(new GetProductsQuery(request.Name)));
        }
    }
}
