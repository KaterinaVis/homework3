/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int number = ReadInt("Введите пятизначное число: ");
int num2 = number/1000;
int num4 = number/10;

if (number>9999 && number<100000)

{if (number/10000 == Mod(number) && Mod(num2) == Mod(num4))
{
    Console.WriteLine(number + "-> да");
}
else
{
    Console.WriteLine(number + "-> нет");
}
}

else
{
    Console.WriteLine("Введено не пятизначное число");
}

int ReadInt(string message)
{
     Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Mod(int num)
{
    return num%10;
}

