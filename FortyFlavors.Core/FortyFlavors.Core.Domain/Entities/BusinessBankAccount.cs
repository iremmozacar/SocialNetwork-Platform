using System;

namespace FortyFlavors.Core.Domain.Entities
{
    public class BusinessBankAccount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BusinessId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string AccountHolderName { get; set; }
        public Business Business { get; set; }
        public bool IsBusinessAccount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}