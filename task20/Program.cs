// программa, принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// double d = 5.099997545;
// double res = Math.Round(d, 2, MidpointRounding.ToZero);
// Console.WriteLine(res);

// Math.Sqrt(45);


Console.WriteLine("Введите координаты точек: ");

Console.Write("ax: ");
int ax = Convert.ToInt32(Console.ReadLine());

Console.Write("ay: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.Write("bx: ");
int bx = Convert.ToInt32(Console.ReadLine());

Console.Write("by: ");
int by = Convert.ToInt32(Console.ReadLine());

int k1 = ax - bx;
int k2 = ay - by;

double distance = Math.Sqrt(k1 * k1 + k2 * k2);

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));
