//программа принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точек: ");

Console.Write("ax: ");
int ax = Convert.ToInt32(Console.ReadLine());

Console.Write("ay: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.Write("az: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("bx: ");
int bx = Convert.ToInt32(Console.ReadLine());

Console.Write("by: ");
int by = Convert.ToInt32(Console.ReadLine());


Console.Write("bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

int k1 = ax - bx;
int k2 = ay - by;
int k3 = az - bz;

double distance = Math.Sqrt(k1 * k1 + k2 * k2 + k3 * k3);

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));
