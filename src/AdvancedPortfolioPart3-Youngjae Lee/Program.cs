/*
 * 
 *        Purpose: Write a program that allows the user to 
 *                  
 *                  -load account and transaction from the file.
 *                  
 *                  -create a bank account by setting its accountID, initial balance, and annual interest rate.
 *                  
 *                  -check the current bank account by having an option to display its current information.
 *        
 *                  -withdraw and deposit funds as well as deposit monthly interest to the bank account.
 *                             
 *                  -display all the transactions done with the account.
 *                  
 *                  -save account & transactions to file and exit program

 *        Input: accountID (int), initial account balance (double), annual interest rate (double), amount to deposit or withdraw (double),  user choice to option (int)
 *        
 *        
 *        Process: This advanced portfolio will continue from core portfolio 2 and some of the existing methods from core portfolio 2 will be modified. Also, one method
 *                 will be added for the menu option 1. The methods to be modified are WithdrawFundsAndWriteToFile(), DepositFundsAndWriteToFile(), AddInterestAndWriteToFile(),
 *                 ReadFromFileAndDisplayTransaction(). The method to be added is LoadAccountAndTransactionFromFile().
 *                 
 *                 The WithdrawFundsAndWriteToFile(), DepositFundsAndWriteToFile(), and AddInterestAndWriteToFile() will be changed to WithdrawFundsAndAddTransactionToList(),
 *                 DepositFundsAndAddTransactionToList(), and AddInterestAndAddTransactionToList() respectively.
 *                 
 *                 As the name suggests, instead of performing a transaction and writing to a file, it will add the transaction to the list in the BankAccount object.
 *                 
 *                 All of the methods will be passed one parameter which is a bank account object. It will perform the transactions and simply create a new transaction object
 *                 based on the bank account object's fields and also the amount of transaction entered by the user. It will then add the newly created transaction object to
 *                 bank account's list. All of the methods will be structured the same except for one method which is AddInterestAndAddTransactionToList() method. This method
 *                 will display the message "Interest already added for this month!" if a transaction with the same month already exists in the bank account's list. 
 *                 This will be done by using the if statement in the for-each loop to see each transaction object in the bank account's list and determine if a transaction
 *                 with the same month exist. If it exists, it will set the bool variable named "interestAlreadyAdded" to true and display the message. Otherwise, it will
 *                 add the transaction to the bank account's list.
 *                 
 *                 Another method to be modified is ReadFromFileAndDisplayTransaction() method. The method's name will be changed to "DisplayTransactions()". It will take a bank
 *                 account object as its parameter and it will just display the fields of the transaction objects that are in the bank account object's list. No need to read from 
 *                 a file anymore.
 *                  
 *                 
 *                 The method to be added is LoadAccountAndTransactionFromFile(). This method will be used for menu option 1. It will take a bank account object as its parameter
 *                 and modify its fields according to the information retrieved from the account file. It will also create transaction objects from the transaction file and add them
 *                 to the bank account object's list. Then, it will display the number of transactions read. The while loop will be used to prompt the user to enter the accountID of 
 *                 the file to be retrieved and StreamReader class will be used to read from the files.
 *                 
 *                 
 *                 In the main method, StreamWriter object and filepath variable will be deleted as no need to write to file every time the user makes a transaction and the file path
 *                 must be defined in the switch case to follow the updated bank account object's information. Some switch cases will be modified, the ones to be modified are case 1,4,
 *                 5,6,7,8. Case 1 will now call the LoadAccountAndTransactionFromFile() method. Case 4,5,6,7 will simply implement the newly modified methods while deleting the old ones.
 *                 Case 8 will create account and transaction files by using the StreamWriter class.
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------        
 *        Output: 1. Bank Account Menu
 *                        1. Load Account & Transactions from File
 *                        2. Create Bank Account
 *                        3. Display Account Information
 *                        4. Withdraw Funds
 *                        5. Deposit Funds
 *                        6. Add Interest
 *                        7. Display Transactions
 *                        8. Save Account & Transactions to File and Exit Program
 *                   Option:
 *                
 *                
 *                2. If the user selects 1
 *                        1. Enter account ID:
 *                        
 *                        2. If files exist for the account ID
 *                               1.(Number of transaction read) transactions read from file
 *                               
 *                           If files do not exist for the account ID
 *                               1. The file, (The file path), does not exist
 *                                  0 transactions read from file
 *                   
 *                   
 *                   If the user selects 2
 *                        1. Create Bank Account Menu
 *                               1. Enter Account ID
 *                               2. Enter Initial Account Balance
 *                               3. Set Annual Interest Rate
 *                               4. Exit Account Creation
 *                           Option:
 *                               
 *                        2. If the user selects 1
 *                              1. Enter account ID:
 *                          
 *                           If the user selects 2
 *                              1. Enter initial account balance:
 *                              
 *                           If the user selects 3
 *                              1. Enter annual interest rate:
 *                           
 *                           if the user selects 4
 *                              1. (returned to the main menu)
 *                              
 *                   If the user selects 3
 *                        1. Account ID: (accountID)
 *                           Created: (date created)
 *                           Balance: $(current balance)
 *                           Annual Interest Rate: (annual interest rate in percentage)%
 *                   
 *                   If the user selects 4
 *                        1. Enter withdrawal amount:
 *                        
 *                   If the user selects 5
 *                        1. Enter deposit amount: 
 *                        
 *                   If the user selects 6
 *                        1. If the same type of transaction for the same month does not exist
 *                              1. Added $(monthly interest amount) in interest  
 *                              
 *                           If the same type of transaction for the same month exist
 *                              1. Interest already added for this month!
 *                        
 *                   If the user selects 7
 *                        1. Account     Type       Amount                              Date                   Ending Balance
 *                          (accountID)  (type)   (amount involved in transaction)     (date of transation)    (remaining balance)
 *                              .           .                    .                              .                       .
 *                              .           .                    .                              .                       .
 *                              .           .                    .                              .                       .
 *                        
 *                   If the user selects 8
 *                        1. Goodbye ... 
 *                  
 *        
 *   ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------        
 *        Test plan
 *        
 *        Test case 1: Create a bank account (menu option 2) and check it by displaying the account information (menu option 3)
 *        Test data: 123456 for accountID, 1000 for initial account balance, 1.45 for annual interest rate
 *        Expected result: 1. Account ID: 123456
 *                            Created: 2021-04-10
 *                            Balance: $1000
 *                            Annual Interest Rate: 1.45%
 *        
 *        Test case 2: Withdraw funds (menu option 4) from the bank account and check it by displaying the account information (menu option 3)
 *        Test data: 255.75 for withdrawal amount
 *        Expected result: 1. Account ID: 123456
 *                            Created: 2021-04-10
 *                            Balance: $744.25
 *                            Annual Interest Rate: 1.45%
 *        
 *        Test case 3: Deposit funds to the bank account (menu option 5) and check it by displaying the account information (menu option 3)
 *        Test data: 355.84 for the deposit amount
 *        Expected result: 1. Account ID: 123456
 *                            Created: 2021-04-10
 *                            Balance: $1100.09
 *                            Annual Interest Rate 1.45%
 *        
 *        Test case 4: Deposit monthly interest to the bank account (menu option 6) and check it by displaying the account information (menu option 3)
 *        Test data: N/A
 *        Expected result: 1. Added $1.33 in interest
 *        
 *                         2. Account ID: 123456
 *                            Created: 2021-04-10
 *                            Balance: $1101.42
 *                            Annual Interest Rate 1.45%
 *        
 *        
 *        Test case 5: Display all the transactions performed in the previous tests (menu option 7)
 *        Test data: N/A
 *        Expected result: 1. Account     Type       Amount                              Date                   Ending Balance
 *                            123456        W          $255.75                           2021-04-10              $744.25
 *                            123456        D          $355.84                           2021-04-10              $1100.09
 *                            123456        I          $1.33                             2021-04-10              $1101.42
 *        
 *        Test case 6: Save account & transactions to file and exit program (menu option 8). Check to see if the csv file for account information and transactions are created and saved.
 *        Test data: N/A
 *        Expected result: 1. Goodbye ...
 *        
 *                         2. 123456.csv and 123456_transactions.csv file created in directory C:\Users\skske\Documents
 *                         
 *        Test case 7: Load account & transactions from file
 *        Test data: 123456 for accountID
 *        Expected result: 1. 3 transactions read from file
 *        
 *        
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------       
 *        Author: Youngjae Lee
 *        
 *        Last modified date: 2021 Apr 10
 */

using System;
using System.IO;
using System.Collections.Generic;


namespace AdvancedPortfolioPart3_Youngjae_Lee
{
    class Program
    {
        //getting the user-input(double) method
        static double GetSafeDouble(string message)
        {
            double doubleValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(message);
                validInput = double.TryParse(Console.ReadLine(), out doubleValue);
                if (!validInput)
                {
                    Console.WriteLine("  Invalid input! You must enter a double value for the answer");
                    Console.WriteLine();
                }
            }

            return doubleValue;
        }

        //getting the user-input(int) method
        static int GetSafeInt(string message)
        {
            int intValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(message);
                validInput = int.TryParse(Console.ReadLine(), out intValue);
                if (!validInput)
                {
                    Console.WriteLine("  Invalid input! You must enter an int value for the answer");
                    Console.WriteLine();
                }
            }

            return intValue;
        }


        //displays menu options to prompt accountID, balance, and annual interest rate. It returns a BankAccount object with what user had entered.
        static BankAccount CreateBankAccount()
        {
            //create a BankAccount object
            BankAccount bankAccount = new BankAccount();

            //setting DateCreated field to current date
            bankAccount.DateCreated = DateTime.Now;

            //setting exit initially to false
            bool exit = false;

            do
            {
                //calling the DisplayCreateBankAccountMenu to display options
                DisplayCreateBankAccountMenu();

                //prompting user for choice and storing in userChoice variable
                int userChoice = GetSafeInt("Option: ");

                //setting invalidInput initially to true
                bool invalidInput = true;
                switch (userChoice)
                {

                    //accountID
                    case 1:
                        
                        do
                        {
                            try
                            {
                                //prompt for account ID and store it in the class field
                                bankAccount.AccountID = GetSafeInt("Enter account ID: ");
                                invalidInput = false;
                            }

                            //catching exception that occurs if the accountID entered is not greater than zero
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        } while (invalidInput);

                        //resetting invalidInput to true
                        invalidInput = true;
                        break;

                    //balance
                    case 2:

                        do
                        {
                            try
                            {
                                //prompt for balance and store it in the class field
                                bankAccount.Balance = GetSafeDouble("Enter initial account balance: ");
                                invalidInput = false;
                            }

                            //catching exception that occurs if the balance entered is not greater than zero
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        } while (invalidInput);

                        //resetting invalidInput to true
                        invalidInput = true;
                        break;

                    //annual interest rate
                    case 3:
                        do
                        {
                            try
                            {
                                //prompt for annualInterestRate and store it in the class field
                                bankAccount.AnnualInterestRate = GetSafeDouble("Enter annual interest rate: ");
                                invalidInput = false;
                            }


                            //catching exception that occurs if the annual interest rate entered is not greater than zero
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        } while (invalidInput);

                        //resetting invalidInput to true
                        invalidInput = true;
                        break;

                    //quit
                    case 4:

                        //setting exit to true
                        exit = true;
                        break;

                    //setting default case to display invalid input message
                    default:
                        Console.WriteLine("  Invalid input. Please try again.");
                        break;


                }

            } while (!exit);

            //returning the BankAccount object
            return bankAccount;
        }

        //displays account information
        static void DisplayAccountInformation(BankAccount bankAccount)
        {
            Console.WriteLine($"Account ID : {bankAccount.AccountID}");
            Console.WriteLine($"Created: {bankAccount.DateCreated}");
            Console.WriteLine($"Balance: ${Math.Round((bankAccount.Balance),2)}");
            Console.WriteLine($"Annual Interest Rate: {bankAccount.AnnualInterestRate}%");
        }

        //displays menu
        static void DisplayMenu()
        {
            Console.WriteLine("Bank Account Menu");
            Console.WriteLine("\t1. Load Account & Transactions from File");
            Console.WriteLine("\t2. Create Bank Account");
            Console.WriteLine("\t3. Display Account Information");
            Console.WriteLine("\t4. Withdraw Funds");
            Console.WriteLine("\t5. Deposit Funds");
            Console.WriteLine("\t6. Add Interest");
            Console.WriteLine("\t7. Display Transactions");
            Console.WriteLine("\t8. Save Account & Transactions to File and Exit Program");
        }

        //displays CreateBankAccount menu
        static void DisplayCreateBankAccountMenu()
        {
            Console.WriteLine("Create Bank Account Menu");
            Console.WriteLine("\t1. Enter Account ID");
            Console.WriteLine("\t2. Enter Initial Account Balance");
            Console.WriteLine("\t3. Set Annual Interest Rate");
            Console.WriteLine("\t4. Exit Account Creation");

        }

        //withdraws funds and write the transaction to the file
        static void WithdrawFundsAndAddTransactionToList(BankAccount bankAccount)
        {

            //prompts the user to enter for the amount to withdraw and stores the input value
            double amount = GetSafeDouble("Enter withdrawal amount: ");

            //calling WithDraw() class method to withdraw
            bankAccount.WithDraw(amount);

            //creating a transaction object 
            Transaction transaction = new Transaction(bankAccount.AccountID, 'W', amount, DateTime.Now, bankAccount.Balance);

            //adding the transaction object to list in class
            bankAccount.TransactionList.Add(transaction);
        }

        //deposits funds and write the transaction to the file
        static void DepositFundsAndAddTransactionToList(BankAccount bankAccount)
        {

            //prompts the user to enter for the amount to deposit and stores the input value
            double amount = GetSafeDouble("Enter deposit amount: ");

            //calling Deposit() class method to deposit
            bankAccount.Deposit(amount);

            //creating a transaction object 
            Transaction transaction = new Transaction(bankAccount.AccountID, 'D', amount, DateTime.Now, bankAccount.Balance);

            //adding the transaction object to list in class
            bankAccount.TransactionList.Add(transaction);
        }

        //calculates monthly interest and add the amount to the balance
        static void AddInterestAndAddTransactionToList(BankAccount bankAccount)
        {

            //calculates monthly interest using CalculateMonthlyInterest() class method
            double monthlyInterest = bankAccount.CalculateMonthlyInterest();

            //bool variable to check if the interest had already been added
            bool interestAlreadyAdded = false;

            //foreach loop declaration to check every transaction in bank account's transaction list
            foreach (Transaction transactions in bankAccount.TransactionList)
            {
                //if the interest had already been added for this month
                if ((transactions.TransactionDate.Year == DateTime.Now.Year) && (transactions.TransactionDate.Month == DateTime.Now.Month) && (transactions.Type == 'I'))
                {
                    //setting interestAlreadyAdded to true
                    interestAlreadyAdded = true;
                }
            }

            //if interest had not been added for this month
            if (!interestAlreadyAdded)
            {
                //calling Deposit() class method to deposit the monthly interest
                bankAccount.Deposit(monthlyInterest);

                //displaying the amount added to the balance
                Console.WriteLine($"Added ${Math.Round((monthlyInterest), 2)} in interest");

                //creating a transaction object 
                Transaction transaction = new Transaction(bankAccount.AccountID, 'I', monthlyInterest, DateTime.Now, bankAccount.Balance);

                //adding the transaction object to list in class
                bankAccount.TransactionList.Add(transaction);
            }

            //if interest had already been added for this month
            else
            {
                //displaying a message that interest had already been added
                Console.WriteLine("Interest already added for this month!");
            }
        }


        
        //loads account and transaction from file
        static void LoadAccountAndTransactionFromFile(BankAccount bankAccount)
        {
            //setting invalid input to true
            bool invalidInput = true;

            //stores accountID retrieved from the user
            int getAccountID;

            //stores the file path for transaction file
            string filepathForTransaction = "null";

            //stores the file path for account
            string filepathForAccount = "null";

            //while loop
            while (invalidInput)
            {
                try
                {
                    //prompt the user to enter the accountID to retrieve from
                    getAccountID = GetSafeInt("Enter account ID: ");

                    //if what the user entered is less than zero
                    if (getAccountID < 0)
                    {
                        //throw a customized exception
                        throw new Exception($"Account ID must be zero or greater");
                    }

                    
                    else
                    {
                        //setting the filepath for transaction and account files based on what the user had entered
                        filepathForTransaction = $"C:\\Users\\skske\\Documents\\{getAccountID}_transactions.csv";
                        filepathForAccount = $"C:\\Users\\skske\\Documents\\{getAccountID}.csv";

                        //setting invalidInput to false
                        invalidInput = false;
                    }
                }

                //will catch the exception that occurs when the user enters accountID less than zero
                catch(Exception ex)
                {
                    //displaying the error message
                    Console.WriteLine(ex.Message);
                }
            }

            try
            {
                //constructing a StreamReader instance for transaction file
                StreamReader readerForTransaction = new StreamReader(filepathForTransaction);

                //constructing a StreamReader instance for account file
                StreamReader readerForAccount = new StreamReader(filepathForAccount);

                //creating a string variable to store the line read from the csv file
                string lineText;

                //setting counter initially to 0 to count the number of transactions read
                int counter = 0;

                //reading one line at time until we reach the end of the file (EOF)
                while ((lineText = readerForTransaction.ReadLine()) != null)
                {

                    //splitting the line values into an array of value 
                    string[] lineArrayForTransaction = lineText.Split(',');

                    //storing the first element (The account ID) of the lineArray array
                    int accountID = int.Parse(lineArrayForTransaction[0]);

                    //storing the second element (The type) of the lineArray array
                    char type = char.Parse(lineArrayForTransaction[1]);

                    //storing the third element (The amount) of the lineArray array
                    double amount = double.Parse(lineArrayForTransaction[2]);

                    //storing the fourth element (The date) of the lineArray array
                    DateTime date = DateTime.Parse(lineArrayForTransaction[3]);

                    //storing the fifth element (The ending balance) of the lineArray aray
                    double endingBalance = double.Parse(lineArrayForTransaction[4]);

                    //creating a new transaction based on the file information
                    Transaction transaction = new Transaction(accountID, type, amount, date, endingBalance);

                    //adding the transaction to the list in class
                    bankAccount.TransactionList.Add(transaction);

                    //incrementing counter by 1
                    counter++;      
                }

                //displaying number of transactions read
                Console.WriteLine($"{counter} transactions read from file");

                //reading one line from the account file
                lineText = readerForAccount.ReadLine();

                //splitting the line values into an array of value 
                string[] lineArrayForAccount = lineText.Split(',');

                //storing the first element (The account ID) of the lineArray array
                bankAccount.AccountID = int.Parse(lineArrayForAccount[0]);

                //storing the second element (The type) of the lineArray array
                bankAccount.Balance = double.Parse(lineArrayForAccount[1]);

                //storing the third element (The amount) of the lineArray array
                bankAccount.AnnualInterestRate = double.Parse(lineArrayForAccount[2]);

                //storing the fourth element (The date) of the lineArray array
                bankAccount.DateCreated = DateTime.Parse(lineArrayForAccount[3]);


                //closing the file for transaction
                readerForTransaction.Close();

                //closing the file for account
                readerForAccount.Close();
            }

            //handles file not found exception
            catch (FileNotFoundException)
            {
                //displays the error message
                Console.WriteLine($"The file, {filepathForTransaction}, does not exist 0 transactions read from file");
            }

            //catches any exception in reading file
            catch (Exception ex)
            {
                //displays the error message
                Console.WriteLine($"Error reading from file path {filepathForTransaction} with exception {ex.Message}");
            }

 

        }

        //displays transactions that are in bank account class list
        static void DisplayTransactions(BankAccount bankAccount)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4, 30}", "Account", "Type", "Amount", "Date", "Ending Balance");

            foreach (Transaction transaction in bankAccount.TransactionList)
            {
                //displaying the accountID, type, amount, date, and ending balance
                Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4, 12}", $"{transaction.AccountID}", $"{transaction.Type}", $"${Math.Round(transaction.Amount,2)}", $"{transaction.TransactionDate}", $"${Math.Round(transaction.EndingBalance, 2)}");
            }
        }

        static void Main(string[] args)
        {
            //setting quit variable initially to false
            bool quit = false;

            //creating a bankaccount with its default value
            BankAccount bankAccount = new BankAccount();

            //do while loop
            do
            {
                //display menu
                DisplayMenu();

                //prompt the user for the choice and storing it in the userChoice variable
                int userChoice = GetSafeInt("Option: ");

                //switch statement
                switch (userChoice)
                {
                    case 1:
                        LoadAccountAndTransactionFromFile(bankAccount);
                        break;

                    //if the user wants to create a bank account
                    case 2:

                        //calling the CreateBankAccount() method and updating the bankAccount object based on its return value
                        bankAccount = CreateBankAccount();
                        break;

                    //if the user wants to display bank account information
                    case 3:
                        
                        //displays account information
                        DisplayAccountInformation(bankAccount);
                        break;

                    //if the user wants to withdraw
                    case 4:

                        //withdraws funds and adds transaction to list
                        WithdrawFundsAndAddTransactionToList(bankAccount);
                        break;

                    //if the user wants to deposit
                    case 5:

                        //deposits funds and adds transaction to list
                        DepositFundsAndAddTransactionToList(bankAccount);
                        break;

                    case 6:

                        //deposits monthly interest and adds transaction to list
                        AddInterestAndAddTransactionToList(bankAccount);
                        break;

                    //if the user wants to display transactions
                    case 7:

                        DisplayTransactions(bankAccount);
                        break;

                    //if the user wants to save account & transactions to file and exit program
                    case 8:

                        try
                        {
                            // hardcoding the file path
                            string filepathForTransaction = $"C:\\Users\\skske\\Documents\\{bankAccount.AccountID}_transactions.csv";

                            //create a StreamWriter object to create a file in the file path specified
                            StreamWriter writer = new StreamWriter(filepathForTransaction);

                            foreach(Transaction transaction in bankAccount.TransactionList)
                            {
                                writer.Write($"{transaction.AccountID},{transaction.Type},{transaction.Amount},{transaction.TransactionDate},{transaction.EndingBalance}");
                                writer.WriteLine();
                            }

                            //closing the file
                            writer.Close();
                        }

                        catch (Exception ex)
                        {
                            //display the error message
                            Console.WriteLine($"Error writing to the file with exception {ex.Message}");
                        }

                        try
                        {
                            //constructing a StreamWriter instance for writing to a csv file
                            StreamWriter writerForAccount = new StreamWriter($"C:\\Users\\skske\\Documents\\{bankAccount.AccountID}.csv");

                            //writing the account information to file
                            writerForAccount.Write($"{bankAccount.AccountID}, {bankAccount.Balance}, {bankAccount.AnnualInterestRate}, {bankAccount.DateCreated}");

                            //add a line
                            writerForAccount.WriteLine();

                            //close the file
                            writerForAccount.Close();
                        }

                        //catches any exceptions made from writing to file
                        catch (Exception ex)
                        {
                            //display the error message
                            Console.WriteLine($"Error writing to the file with exception {ex.Message}");
                        }

                        //good-bye message
                        Console.WriteLine("Goodbye ...");

                        //setting quit to true
                        quit = true;
                        break;

                    //setting default case to display invalid input message
                    default:
                        Console.WriteLine("  Invalid input. Please try again");
                        break;


                }
            } while (!quit);

        }
    }
}
