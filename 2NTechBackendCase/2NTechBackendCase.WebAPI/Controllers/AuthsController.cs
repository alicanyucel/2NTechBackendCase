﻿using _2NTechBackendCase.Application.Features.Auth.Login;
using _2NTechBackendCase.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _2NTechBackendCase.WebAPI.Controllers
{
    [AllowAnonymous]
    public sealed class AuthsController : ApiController
    {
        public AuthsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
