using System;
using System.Diagnostics;

public class bankUser
{
    String firstName;
    String lastName;
    String cardNumber;
    int pin;
    double balance;

    //create bankUser constructor
    public bankUser(string firstName, string lastName, string cardNumber, int pin, double balance)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.balance = balance;
    }

    //getters and setters
    public string getFirstName()
    {
        return firstName;
    }

    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }

    public String getCardNumber()
    {
        return cardNumber;
    }

    public void setCardNumber(String cardNumber)
    {
        this.cardNumber= cardNumber;
    }

    public int getPin()
    {
        return pin;
    }

    public void setPin(int pin)
    {
        this.pin = pin;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setBalance(double balance)
    {
        this.balance = balance;
    }

}
