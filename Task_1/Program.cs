// Задача 25

using static System.Console;
Clear();


WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());

WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int up = a;

for (int i = 1; i < b; i++)
{
up = up * a;
}
Console.WriteLine("A в степени B равно: " + up);