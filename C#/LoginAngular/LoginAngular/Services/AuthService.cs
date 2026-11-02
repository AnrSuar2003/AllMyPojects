using LoginAngular.Data;
using LoginAngular.DTOs;
using LoginAngular.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LoginAngular.Services;

public class AuthService : IAuthService
{
    private readonly AuthDbContext _context;
    private readonly IConfiguration _config;

    public AuthService(AuthDbContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    public async Task<LoginResponseDto?> LoginAsync(LoginRequestDto request)
    {
        var user = await _context.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u =>
                u.Username == request.Username && u.IsActive);

        if (user == null)
            return null;

       // if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
       //     return null;

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.Role.Name)
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(
                int.Parse(_config["Jwt:ExpireMinutes"]!)),
            signingCredentials:
                new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
        );

        return new LoginResponseDto(
            new JwtSecurityTokenHandler().WriteToken(token),
            user.Role.Name
        );
    }
}
