// программа принимает два числа и 
// проверяет, является ли одно число квадратом второго


Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}