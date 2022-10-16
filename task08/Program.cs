// программа, которая на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа построит ряд четных чисел от 1 до N. ");
Console.Write("Введите значение N: ");

int N = Convert.ToInt32(Console.ReadLine());

if(N > 0)
{

    int count = 1;

        while (count < N)
        {
            if ((N % 2) == 0)
            {
                Console.Write($"{count} ");
            }
                count++;
        }

}
else Console.WriteLine("Введите положительное число. ");