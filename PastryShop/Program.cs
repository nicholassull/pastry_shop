using System;
using PastryShop.Models;


namespace PastryShop
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakey online ording service!");
      Console.WriteLine("=====================");
      Console.WriteLine("We sell loafs of bread and pastries. In fact, we're having a huge sale right now!");
      purchasingInterface();
    }
    static void purchasingInterface()
    {
      Console.WriteLine("Here are our current prices...");
        Console.WriteLine("=====================");
        Console.WriteLine("== Bread ==");
        Console.WriteLine("1 Loaf: $5");
        Console.WriteLine("3 Loaves: $10");
        Console.WriteLine("== Pastries ==");
        Console.WriteLine("1 Pastry: $2");
        Console.WriteLine("3 Pastry: $5");
        Console.WriteLine("4 Pastry: $7");
        Console.WriteLine("5 Pastry: $9");
        Console.WriteLine("6 Pastry: $10");
        Console.WriteLine("=====================");
        Console.WriteLine("How many loaves of bread would you like?");
        int breadAmount = int.Parse(Console.ReadLine());
        Console.WriteLine("How many Pastries would you like?");
        int pastryAmount = int.Parse(Console.ReadLine());
        int totalPrice = calculatePrice(breadAmount, pastryAmount);
        Console.WriteLine("=====================");
        Console.WriteLine("For your order of " + breadAmount + " loaves of bread and " + pastryAmount + " pastries...");
        Console.WriteLine("The total comes to $" + totalPrice + " dollars.");
        nextOrder();
    }
    static int calculatePrice(int breadAmount, int pastryAmount)
    {
      int breadTotal = Bread.FindTotal(breadAmount);
      int pastryTotal = Pastry.FindTotal(pastryAmount);
      return breadTotal + pastryTotal;
    }
    static void nextOrder()
    {
      Console.WriteLine("=====================");
      Console.WriteLine("Would you like to make another order? (Y = 'yes', N = 'no')");
      string userAnswer = Console.ReadLine().ToLower();
      if (userAnswer == "y")
      {
        purchasingInterface();
      }
      else
      {
        Console.WriteLine("Thank you for supporting Pierre's Bakery! We hope to see you again soon!");
      }
    }
  }
}