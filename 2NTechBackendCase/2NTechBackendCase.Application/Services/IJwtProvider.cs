using _2NTechBackendCase.Application.Features.Auth.Login;
using _2NTechBackendCase.Domain.Entities;

namespace _2NTechBackendCase.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
