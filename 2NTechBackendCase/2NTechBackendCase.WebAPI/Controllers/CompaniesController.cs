using _2NTechBackendCase.Application;
using _2NTechBackendCase.Application.Features.Company;
using _2NTechBackendCase.Application.Features.Company.AddCompany;
using _2NTechBackendCase.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _2NTechBackendCase.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> AddCompany(AddCompanyCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
        [HttpPost]
        public async Task<IActionResult> GetAllCompanies(GetAllCompanyQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateCompany(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteCompany(DeleteCompanyByIdCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);

        }
    }
}
