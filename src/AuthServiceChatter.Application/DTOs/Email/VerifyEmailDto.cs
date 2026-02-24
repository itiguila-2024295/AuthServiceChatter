using System.ComponentModel.DataAnnotations;

namespace AuthServiceChatter.Application.DTOs.Email;

public class VerifyEmailDto
{
    [Required]
    public string Token { get; set; } = string.Empty;
}