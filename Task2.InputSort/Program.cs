using System;

class Program
{
    static void Main()
    {
        int n = 0;
        while (true)
        {
            Console.Write("Введите количество элементов: ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                break; 
            }
            
            Console.WriteLine("Ошибка! Введите целое число больше 0.");
        }
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Элемент [{i}]: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Нужно ввести именно целое число.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка! Число слишком большое или слишком маленькое.");
                }
            }
        }

        Console.WriteLine(); 

        Console.WriteLine("Исходный массив:  " + string.Join(", ", array));

        Console.Write("Обратный порядок: ");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i > 0) Console.Write(", ");
        }
        Console.WriteLine();

        Array.Sort(array);
       
        Console.WriteLine("Отсортированный:  " + string.Join(", ", array));

        int max = array[0];
        int min = array[0];

        foreach (int num in array)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }

        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Минимум: " + min);
    }
}