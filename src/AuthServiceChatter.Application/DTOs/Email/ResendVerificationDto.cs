using System.ComponentModel.DataAnnotations;

namespace AuthServiceChatter.Application.DTOs.Email;

public class ResendVerificationDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}