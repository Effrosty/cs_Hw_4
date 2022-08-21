// Задача 27

using static System.Console;

Clear();

WriteLine("введите число");
int i = Convert.ToInt32(ReadLine()); 

int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
WriteLine("сумма всех цифр в числе равна: " + sum);