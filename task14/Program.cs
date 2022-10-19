// программa, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да


Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine("Да ");

else
    Console.WriteLine("Нет ");



/*    решенеие через метод

bool DivNum(int digit, int num1, int num2)
{
    int result1 = digit % num1;
    int result2 = digit % num2;
    if (result1 == 0 && result2 == 0) return true;
    return false;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

bool result = DivNum(num, number1, number2);
if (result)
{
    Console.WriteLine("Да ");
}
else
{
    Console.WriteLine("Нет ");
}
                                 */