namespace _2NTechBackendCase.Application.Features.Auth.Login
{
    public sealed record LoginCommandResponse(
        string Token,
        string RefreshToken,
        DateTime RefreshTokenExpires);
}
