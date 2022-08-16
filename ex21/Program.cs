/* Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int x1 = ReadInt("Введите Х точки А: ");
int y1 = ReadInt("Введите Y точки А: ");
int z1 = ReadInt("Введите Z точки А: ");

int x2 = ReadInt("Введите Х точки В: ");
int y2 = ReadInt("Введите Y точки В: ");
int z2 = ReadInt("Введите Z точки В: ");

int lengthХ = Length(x1, x2);
int lengthY = Length(y1, y2);
int lengthZ = Length(z1, z2);

double distanse = Math.Sqrt(Sqrt(lengthХ) + Sqrt(lengthY) + Sqrt(lengthZ));

Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {distanse}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Length(int num1, int num2)
{
    return num2-num1;
}

int Sqrt(int num)
{
 return num*num;
}