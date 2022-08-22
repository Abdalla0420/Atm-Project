using System;
namespace mid
{
    public class Atm
    {
        CardHolder _cardHolder;



        public void deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }

        public void withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal = double.Parse(Console.ReadLine());
            //check if the user has enough money
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insuffcient funds :(");
            }


            else
            {
                double newBalance = currentUser.getBalance() - withdrawal;
                currentUser.setBalance(newBalance);
                Console.WriteLine("Thank you for your patience. Your new balance is: " + currentUser.getBalance()); ;
            }

        }

        public void balance(CardHolder currentUser)
        {
            Console.WriteLine("CUrrent balance: " + currentUser.getBalance());
        }
    }
}

