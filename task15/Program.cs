// программa, принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


bool Day(int num)
{
    if (num == 6 || num == 7) return true; return false;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    bool result = Day(number);

    if (result) Console.WriteLine("ДА");
    else Console.WriteLine("НЕТ");

}

else
    Console.Write("Введите число от 1 до 7 ");