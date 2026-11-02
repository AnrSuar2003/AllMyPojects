using LoginAngular.DTOs;

namespace LoginAngular.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto request);

    }
}
