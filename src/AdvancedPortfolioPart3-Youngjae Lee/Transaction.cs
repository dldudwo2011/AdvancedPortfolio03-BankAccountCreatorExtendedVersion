using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedPortfolioPart3_Youngjae_Lee
{
    class Transaction
    {
        //fields
        private int _accountID = 0;
        private char _type = 'D';
        private double _amount = 0;
        private DateTime _transactionDate = DateTime.Now;
        private double _endingBalance = 0;

        //empty constructor
        public Transaction()
        {

        }

        //parameterized constructor
        public Transaction(int accountID, char type, double amount, DateTime transactionDate, double endingBalance)
        {
            AccountID = accountID;
            Type = type;
            Amount = amount;
            TransactionDate = transactionDate;
            EndingBalance = endingBalance;
        }

        //getter and setter for account ID
        public int AccountID
        {
            get
            {
                return _accountID;
            }

            set
            {
                if (value >= 0)
                {
                    _accountID = value;
                }
                else
                {
                    throw new Exception($"Account ID must be zero or greater");
                }
            }
        }

        //getter and setter for type
        public char Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        //getter and setter for amount
        public double Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                if (value >= 0)
                {
                    _amount = value;
                }
                else
                {
                    throw new Exception($"Amount must be zero or greater");
                }
            }
        }

        //getter and setter for transaction date
        public DateTime TransactionDate
        {
            get
            {
                return _transactionDate;
            }

            set
            {
                _transactionDate = value;
            }
        }

        public double EndingBalance
        {
            get
            {
                return _endingBalance;
            }

            set
            {
                if (value >= 0)
                {
                    _endingBalance = value;
                }
                else
                {
                    throw new Exception($"Ending balance must be zero or greater");
                }
            }
        }
    }
}
