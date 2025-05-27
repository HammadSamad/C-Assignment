using System;
using System.Linq;

BankAccount Atif = new();
Atif.accountNum("12345678901234");
Atif.accountName("atif");
Atif.deposit(3000);
Atif.withdraw(2100);
Atif.accountInfo();
Atif.pinPass("1234");
//Console.WriteLine(Atif.getBalance());
public class BankAccount
{
    private string accountNumber;
    private string accountHolderName;
    private double accountBalance;
    private int pinCode;

    public void accountInfo() => Console.WriteLine($"Account Number:{accountNumber}\nName:{accountHolderName}\nBalance:{accountBalance}");

    public void accountNum(string numLimit)
    {
        if (numLimit.Length == 14 && numLimit.All(char.IsDigit))
        {
            accountNumber = numLimit;
        }
        else if (numLimit.Length < 14) Console.WriteLine("Account Number must contain 14 digits");
        else if (numLimit.Length > 14) Console.WriteLine("Number limit exceeded");
    }

    public void accountName(string name)
    {
        if (name == "") Console.WriteLine("Name is required");
        else if (name.Length > 20) Console.WriteLine("Characters limit exceeded");
        else if (!name.All(char.IsLetter)) Console.WriteLine("Invalid name Only alphabets are allowed");
        else
        {
            accountHolderName = name;
        }
    }

    public void deposit(double amount)
    {
        if (amount > 0) accountBalance += amount;
    }

    public void withdraw(double amount)
    {
        if (amount <= accountBalance && amount > 0) accountBalance -= amount;
        else if (amount > accountBalance) Console.WriteLine("Insufficient Balance");
    }

    public void pinPass(string pin)
    {
        if (pin.Length != 4) Console.WriteLine("pin Code must be exactly 4 digits");
        else if (!pin.All(char.IsDigit)) Console.WriteLine("only digits are allowed");
        else
        {
            pinCode = int.Parse(pin);
            Console.WriteLine("pin Code set successfully");
        }
    }

    public double getBalance()
    {
        return accountBalance;
    }
}

