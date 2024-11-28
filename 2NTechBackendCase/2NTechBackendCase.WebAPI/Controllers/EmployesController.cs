using _2NTechBackendCase.Application.Features.Company.AddCompany;
using _2NTechBackendCase.Application.Features.Company;
using _2NTechBackendCase.Application;
using _2NTechBackendCase.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _2NTechBackendCase.Application.Features.Personel;
using Microsoft.AspNetCore.Authorization;

namespace _2NTechBackendCase.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployesController : ApiController
    {
        
        public EmployesController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
        [HttpPost]
        public async Task<IActionResult> GetAllEmployes(GetAllPersonelQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(UpdatePersonelCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteEmployee(DeletePersonelByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
    }
}
