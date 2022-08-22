using System;
using mid;

public class Program
{
    public static void Main(string[] args)
    {
        string test = "test";
        CardHolder testCard = new CardHolder("234",1234,"card1","",246);
        
        Atm atm = new Atm();
        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("999", 1234, "John", "griffith", 158.23));
        cardHolders.Add(new CardHolder("3857439694036835", 7544, "Bob", "ling", 25.32));
        cardHolders.Add(new CardHolder("3295789357429543", 9838, "Steve", "shaba", 119.98));
        cardHolders.Add(new CardHolder("9437684935947369", 9684, "Garry", "utah", 657.11));
        cardHolders.Add(new CardHolder("234", 1234, "card1", "", 246));
        

        void printOptions()
        {
            Console.WriteLine("Please choose from the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        Console.WriteLine("welcome to simpleATM");

        Console.WriteLine("please instert your debit card");
        string debitCardNum = "";
        CardHolder currentUser;

        while(true)
        {
            try
            {

                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a=> a.getCardNum() == debitCardNum); 
                if(currentUser != null) { break; }
                else { Console.WriteLine("Card not recognised please try again"); }
            }
            catch { Console.WriteLine("Card not recognised please try again"); }
        }

        Console.WriteLine("please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin please try again "); }
            }
            catch { Console.WriteLine("Incorrect pin please try again"); }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + " :)" );
        int option = 0;

        do

        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if(option == 1) { atm.deposit(currentUser); }
            else if (option == 2) { atm.withdraw(currentUser); }
            else if (option == 3) { atm.balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you! have a nice day");
    }

}
