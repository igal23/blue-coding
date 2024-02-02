using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Endpoints.Integrations
{
    public class SampleIntegrationEndpoint : EndpointBase
    {
        public SampleIntegrationEndpoint(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("forecast")]
        [ApiVersion("1.0")]
        public ActionResult ForecastIntegration()
        {
            // Execute code
            return Ok();
        }
    }
}
