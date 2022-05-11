using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedPortfolioPart3_Youngjae_Lee
{
    class BankAccount
    {
        //fields
        private int _accountID = 0;
        private double _balance = 0;
        private double _annaulInterestRate = 0;
        private DateTime _dateCreated = DateTime.Now;
        private List<Transaction> _transactionList = new List<Transaction>();

        //constructor with no parameters
        public BankAccount()
        {

        }

        //parameterized constructor
        public BankAccount(int accountID, double balance, double annualInterestRate, DateTime dateCreated)
        {
            AccountID = accountID;
            Balance = balance;
            AnnualInterestRate = annualInterestRate;
            DateCreated = dateCreated;
        }

        //getter and setter for accountID
        public int AccountID
        {
            get
            {
                return _accountID;
            }

            set
            {
                if(value >= 0)
                {
                    _accountID = value;
                }
                else
                {
                    throw new Exception($"Account ID must be zero or greater");
                }
            }
        }

        //getter and setter for balance
        public double Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    throw new Exception($"Balance must be zero or greater");
                }
            }
        }

        //getter and setter for annual interest rate
        public double AnnualInterestRate
        {
            get
            {
                return _annaulInterestRate;
            }

            set
            {
                if (value >= 0)
                {
                    _annaulInterestRate = value;
                }
                else
                {
                    throw new Exception($"Annual interest rate must be zero or greater");
                }
            }
        }

        //getter and setter for date created
        public DateTime DateCreated
        {
            get
            {
                return _dateCreated;
            }

            set
            {
                _dateCreated = value;
            }
        }

        //getter and setter for transaction list
        public List<Transaction> TransactionList
        {
            get
            {
                return _transactionList;
            }

            set
            {
                _transactionList = value;
            }
        }

        //returns monthly interest
        public double CalculateMonthlyInterestRate()
        {
            double monthlyInterestRate = (_annaulInterestRate/100) / 12;

            return monthlyInterestRate;
        }

        //returns monthly interest earned
        public double CalculateMonthlyInterest()
        {
            double monthlyInterest = _balance * CalculateMonthlyInterestRate();

            return monthlyInterest;
        }

        //withdraws money
        public void WithDraw(double amount)
        {
            _balance -= amount;
        }

        //deposits money
        public void Deposit(double amount)
        {
            _balance += amount;
        }




    }
}
