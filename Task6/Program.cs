// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number = new int();

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}
