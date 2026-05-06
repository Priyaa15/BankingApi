namespace BankingAPI.Models;

public class Account
{
    public int Id {get; set;}
    public string AccountNumber {get;set;} = string.Empty;
    public string OwnerName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;
    public AccountType Type { get; set; } = AccountType.Savings;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

      // Navigation property - links to transactions
   // public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}

public enum AccountType { Savings, Checking, Business}