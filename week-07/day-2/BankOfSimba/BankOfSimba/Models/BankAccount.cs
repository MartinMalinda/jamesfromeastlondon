using System;
namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }

        public BankAccount(string name, decimal balance, string animalType, bool isKing)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
        }
    }
}
