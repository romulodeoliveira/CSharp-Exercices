namespace Exercice01;

public class BankAccount
{
    public int AccountNumber { get; private set; }
    public string Name { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(int id, string name, double deposit)
    {
        this.AccountNumber = id;
        this.Name = name;
        this.Balance = deposit;
    }

    public void WithdrawMoney(double amount)
    {
        if (this.Balance <= 0)
        {
            throw new InvalidOperationException("Não é possível sacar dinheiro de uma conta com saldo negativo.");
        }

        else if ((5 + amount) > this.Balance)
        {
            throw new InvalidOperationException("Você não possui saldo suficiente para saque..");
        }
        
        {
            this.Balance = this.Balance - 5 - amount;
        }
    }

    public void DepositMoney(double amount)
    {
        this.Balance += amount;
    }
}
