/* Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int DegreeNumbers(int numberA, int numberB)
{
if (numberB == 0) return 1;
return numberA * DegreeNumbers(numberA, numberB - 1);
}


Console.Write("Введите первое натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int numB  = Convert.ToInt32(Console.ReadLine());

if (numB > 0)
{

int degreeNumbers = DegreeNumbers(numA, numB);
Console.Write($"{numA} в степени {numB} = {degreeNumbers}");

}
else Console.Write("Некорректный ввод ");