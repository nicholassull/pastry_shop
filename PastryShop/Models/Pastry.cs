using System;

namespace PastryShop.Models
{
  public class Pastry
  {
    public int Cost { get; set; }

    public Pastry()
    {
      Cost = 2;
    }

    public static int FindTotal(int number)
    {
      int total = 0;
      if (number % 6 == 0)
      {
        int setOfSix = number / 6;
        total = setOfSix * 10;
      }
      else if (number > 2)
      {
        total = (number * 2) - 1;
      }
      else
      {
        total = number * 2;
      }
      return total;
    }
  }
}