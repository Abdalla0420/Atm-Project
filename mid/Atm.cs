using System;
namespace mid
{
    public class Atm
    {
        public bool DepositMoney(CardHolder cardHolder, int money)
        {
            if (!cardHolder._pinCorrect && CheckDepositAmount(money))
            {
                cardHolder.setBalance(cardHolder._balance + money);
                return true;
            }
            return false;
        }

        private bool CheckDepositAmount(int money)
        {
            if (money  > 10 && money < 300)
            {
                return true;
            }
            return false;
        }

        public bool WithdrawalMoney(CardHolder cardHolder, int money)
        {
            if (!cardHolder._pinCorrect && CheckWithdrawalAmount(money))
            {
                cardHolder.setBalance(cardHolder._balance + money);
                return true;
            }
            return false;
        }

        private bool CheckWithdrawalAmount(int money)
        {
            if (money > 10 && money < 250)
            {
                return true;
            }
            return false;
        }    

        public void balance(CardHolder currentUser)
            
        {
            Console.WriteLine("CUrrent balance: " + currentUser.getBalance());
        }
        
    }
}

