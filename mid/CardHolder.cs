using System;
namespace mid
{
    public class CardHolder
    {
        string _cardNum;
        int _pin;
        string _firstName;
        string _lastName;
        double _balance;


        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            _cardNum = cardNum;
            _pin = pin;
            _firstName = firstName;
            _lastName = lastName;
            _balance = balance;

        }

        public string getNum()
        {
            return _cardNum;
        }

        public int getPin()
        {
            return _pin;
        }

        public string getFirstName()
        {
            return _firstName;
        }

        public string getLastName()
        {
            return _lastName;
        }

        public double getBalance()
        {
            return _balance;
        }

        public string getCardNum()
        {
            return _cardNum;
        }
        public void setNum(string newCardNum)
        {
            _cardNum = newCardNum;
        }

        public void setPin(int newPin)
        {
            _pin = newPin;
        }

        public void setFirstName(string newFirstName)
        {
            _firstName = newFirstName;
        }

        public void setLastName(string newLastName)
        {
            _lastName = newLastName;
        }

        public void setBalance(double newBalance)
        {
            _balance = newBalance;
        }

    }
}

