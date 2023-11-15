namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("How much will you be depositing?");

            var amountToDep = double.Parse(Console.ReadLine());
            
            account.Deposit (amountToDep);

            Console.WriteLine($"Thank you! Your balance is currently ${amountToDep}.");
        }
    }
}
