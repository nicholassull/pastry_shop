
namespace PastryShop.Models
{
  public class Bread
  {
    public int Cost { get; set;}

    public Bread()
    {
      Cost = 5;
    }
    
    public static int FindTotal(int number)
    {
      int total = 0;
      for (int i = 0; i <= number; i++ )
      {
        if (i % 3 == 0)
        {
          continue;
        }
        else
        {
          total += 5;
        }
      }
      return total;
    }
  }
}