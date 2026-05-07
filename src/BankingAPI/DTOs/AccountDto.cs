using System.ComponentModel.DataAnnotations;
using BankingAPI.Models;

namespace BankingAPI.DTOs;

public record AccountResponseDto
(
    int Id,
    string AccountNumber,
    string OwnerName,
    string Email,
    decimal Balance,
    string Type,
    bool isActive,
    DateTime CreateAt
);

public record CreateAccountDto(
    [Required][StringLength(100)] string OwnerName,
    [Required][EmailAddress] string Email,
    AccountType Type = AccountType.Savings
);

public record UpdateAccountDto(
    [StringLength(100)] string? OwnerName,
    [EmailAddress] string? Email
);