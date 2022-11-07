using System;
public class Mainclass
{
    public static void Main()
    {
        int left, right;
        left = 0;
        right = 0;  
        Console.WriteLine("Сколько домов на улице?");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(" "); 
        int[] houses = new int[num];
        Random rand = new Random();
        for (int people = 0; people < houses.Length; people++)
        {
            houses[people] = rand.Next(1, 10);
            Console.WriteLine($"Дом номер {people+1} - {houses[people]}");
            if ((people+1)%2 == 1)
            {
                left += houses[people];
            }
            else if ((people + 1) % 2 == 0)
            {
                right += houses[people];
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine($"С левой стороны: {left} человек; с правой стороны: {right} человек");
        int more = Math.Max(left, right);
        if (more == left)
        {
            Console.WriteLine($"Больше человек c левой стороны");
        }
        else if (more == right)
        {
            Console.WriteLine($"Больше человек c правой стороны");
        }
        
    }
}
