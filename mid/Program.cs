using System;

public class cardHolder
{
    String cardNum;
    int pin;
    string firstName;
    String lastName;
    double balance;
    

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;

    }

    public String getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(string newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }


    public static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit: ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
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

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("CUrrent balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("999", 1234, "John", "griffith", 158.23));
        cardHolders.Add(new cardHolder("3857439694036835", 7544, "Bob", "ling", 25.32));
        cardHolders.Add(new cardHolder("3295789357429543", 9838, "Steve", "shaba", 119.98));
        cardHolders.Add(new cardHolder("9437684935947369", 9684,"Garry", "utah", 657.11));

        Console.WriteLine("welcome to simpleATM");

        Console.WriteLine("please instert your debit card");
        string debitCardNum = "";
        cardHolder currentUser;

        while(true)
        {
            try
            {

                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum); 
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
            if(option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you! have a nice day");
    }

}
