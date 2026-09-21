using System;
namespace Task1
{
   class Program
   {
     static void Main()
     {
       Random rnd = new  Random();
       int [] numbers = new int[10];
       for (int i = 0; i < numbers.Length; i++)
      {
        numbers [i] = rnd.Next(1,101);
      }
      System.Console.WriteLine("массив : " + string.Join(",",numbers));
      int sum = 0;
      double product = 1;
      int evenCount = 0;
      foreach (int num in numbers)
      {
        sum += num;
        product *= num;
        if (num %2 == 0)
        {
          evenCount++;
        } 

        double average = (double)sum / numbers.Length;
        int aboveAverageCount = 0;
        foreach (int num1 in numbers)
        {
          if (num1 > average)
          {
            aboveAverageCount++;
          }
        }
        System.Console.WriteLine("Сумма: " + sum);
        System.Console.WriteLine("Произведение: " + product.ToString("E2"));
        System.Console.WriteLine("Чётных чисел: " + evenCount);
        Console.WriteLine($"Больше среднего ({average}): " + aboveAverageCount);
      }
    }
      
  }
}