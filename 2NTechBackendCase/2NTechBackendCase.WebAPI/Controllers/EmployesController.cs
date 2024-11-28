using _2NTechBackendCase.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2NTechBackendCase.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployesController : ApiController
    {
        public EmployesController(IMediator mediator) : base(mediator)
        {
        }
    }
}
