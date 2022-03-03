// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int number = new int();
int count = new int();

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

count = 1;
while(count <= number)
{
    Console.Write(count + " ");
    count++;
}
if (number < 1)
{
    Console.Write("Введите число, начиная с 1! ");
}