//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int number1 = new int();
int number2 = new int();

Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("max = " + number1);
    Console.Write("min = " + number2);
}
else
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1);
}
