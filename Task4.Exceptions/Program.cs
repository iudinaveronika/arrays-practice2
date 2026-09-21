using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Введите элемент [{i}]: ");
                   
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                   break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }
        }

        Console.WriteLine();

        while (true)
        {
            try
            {
                Console.Write("Введите индекс для вывода (0-4): ");
                
                int index = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Элемент под индексом {index}: {numbers[index]}");
                
                break; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите целое число!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Число слишком большое!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: Индекс вне границ массива.");
            }
        }
    }
}