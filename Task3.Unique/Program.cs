using System;

class Program
{
    static void Main()
    {
        int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };

        Console.WriteLine("Исходный:  " + string.Join(", ", source));

        int[] unique = GetUnique(source);

        Console.WriteLine("Уникальные: " + string.Join(", ", unique));
    }

    public static int[] GetUnique(int[] source)
    {
        int[] temp = new int[source.Length];
        
        int uniqueCount = 0;

        foreach (int item in source)
        {
            bool isAlreadyExist = false; 

            for (int i = 0; i < uniqueCount; i++)
            {
                if (temp[i] == item)
                {
                    isAlreadyExist = true; 
                    break;                 
                }
            }

            if (!isAlreadyExist)
            {
                temp[uniqueCount] = item;
                uniqueCount++; 
            }
        }

        int[] result = new int[uniqueCount];

        for (int i = 0; i < uniqueCount; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }
}