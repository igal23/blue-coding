using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Endpoints
{
    public abstract class EndpointBase : ControllerBase
    {
        protected readonly MediatR.IMediator _mediator;

        protected EndpointBase(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
