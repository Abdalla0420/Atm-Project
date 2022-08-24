using System;
namespace mid
{
    public class CardHolder
    {
        public string _cardNum { get; set; }
        public int _pin { get; set; }
        public string _firstName { get; set; }
        public string _lastName{ get; set; }
        public double _balance { get; set; }
        public bool _pinCorrect { get; set; }


        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            _cardNum = cardNum;
            _pin = pin;
            _firstName = firstName;
            _lastName = lastName;
            _balance = balance;
            _pinCorrect = false;
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

