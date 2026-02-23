
using AuthServiceChatter.Domain.Entities;

namespace AuthServiceChatter.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken(User user);
}