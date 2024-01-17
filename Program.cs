using System;
using System.Diagnostics;

public class bankUser
{
    String bankId;
    String firstName;
    String lastName;
    String cardNumber;
    int pin;
    double balance;

    //create bankUser constructor
    public bankUser(string bankId, string firstName, string lastName, string cardNumber, int pin, double balance)
    {
        this.bankId = bankId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.balance = balance;
    }

    // getters
    public string getBankId()
    {
        return bankId;
    }
    public string getFirstName()
    {
        return firstName;
    }


    public string getLastName()
    {
        return lastName;
    }

    public String getCardNumber()
    {
        return cardNumber;
    }


    public int getPin()
    {
        return pin;
    }

    public double getBalance()
    {
        return balance;
    }

    // setters
    public void setBankId(String bankId)
    {
        this.bankId = bankId;
    }
    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }

    public void setCardNumber(String cardNumber)
    {
        this.cardNumber = cardNumber;
    }

    public void setBalance(double balance)
    {
        this.balance = balance;
    }

    public void setPin(int pin)
    {
        this.pin = pin;
    }
    
    // creating a main method to run the program from
    public static void Main(String[] args)
    {
        //method to present options to user
        void printOptions()
        {
            Console.WriteLine("\nSelect from the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }//end printOptions

        //method for deposit
        void depositMoney(bankUser currentUser)
        {
            Console.WriteLine("\nHow much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you. Youre new balance is: "+currentUser.getBalance());
        }//end depositMoney

        //method for withdraw
        void withdrawMoney(bankUser currentUser)
        {
            Console.WriteLine("\nHow much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            //validate there is enough to withdraw
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("This exceeds your limit. Please try again.");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you. Youre new balance is: " + currentUser.getBalance());
            }
        }//end withdrawMoney

        //method to show users balance
        void balance(bankUser currentUser)
        {
            Console.Write(currentUser.getBalance());
        }

        //method for closing the application

        //creating a list of bank users
        List<bankUser> bankUsers = new List<bankUser>();
        bankUsers.Add(new bankUser("1", "Briggs", "Dolphin", "123456", 123, 1200));
        bankUsers.Add(new bankUser("2", "Kingston", "Marklund", "654321", 234, 400));
        bankUsers.Add(new bankUser("3", "Lissy", "Aurelius", "567890", 345, 5000));
        bankUsers.Add(new bankUser("4", "Onida", "Hulmes", "098765", 456, 300));
        bankUsers.Add(new bankUser("5", "Ade", "Esh", "345678", 567, 90));
        bankUsers.Add(new bankUser("6", "Francisco", "987654", "2415434450", 678, 850));
        bankUsers.Add(new bankUser("7", "Gwyn", "Bothbie", "647382", 897, 5));

        //prompt the user
        Console.WriteLine("Welcome to C# ATM");
        Console.WriteLine("\nPlease enter your card number: ");
        String debitCardNumber = "";
        bankUser currentUser;

        while (true)
        {
            try
            {
                debitCardNumber = Console.ReadLine();
                //check against list of card numbers
                currentUser = bankUsers.FirstOrDefault(a => a.cardNumber == debitCardNumber); //this allows us to cycle through list and find a match and return all from that data in the list
                //if there is a match, break out of the loop. If not we let the user know there isn't a match
                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card not found. Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("Card not found. Please try again.");
            }
        }//end while

        //ask the user for their pin
        Console.WriteLine("\nPlease enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                //check the user pin
                if (currentUser.getPin() == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect pin. Please try again.");
                }
            }
            catch
            {
                Console.WriteLine("Incorrect pin. Please try again.");
            }
        }//end while

        Console.WriteLine("\nWelcome "+ currentUser.getFirstName() + " : ) ");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {

            }
            if (option == 1)
            {
                depositMoney(currentUser);
            }
            else if (option == 2)
            {
                withdrawMoney(currentUser);
            }
            else if (option == 3)
            {
                balance(currentUser);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;
            }
        }
        while (option != 4);
        Console.WriteLine("\nGoodbye!");

    }//end main

}//end class
