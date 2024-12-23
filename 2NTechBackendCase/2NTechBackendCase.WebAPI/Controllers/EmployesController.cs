﻿using _2NTechBackendCase.Application;
using _2NTechBackendCase.WebAPI.Abstractions;
using MediatR;
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
        // burada sorun var eklemede
        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddPersonelCommand request, CancellationToken cancellationToken)
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
