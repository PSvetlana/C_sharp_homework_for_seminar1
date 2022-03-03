// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int number1 = new int();
int number2 = new int();
int number3 = new int();
int max = new int();

Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
number3 = Convert.ToInt32(Console.ReadLine());

max = number1;

if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.Write("max = " + max);
