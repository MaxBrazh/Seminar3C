// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
using static System.Console;
Clear();

WriteLine("Введите любое число: ");
int number = int.Parse(ReadLine());
WriteLine("Таблица кубов чисел от 1 до заданного числа:");

int n = 1;
while (n <= number)
{
    WriteLine($"{n} в кубе = {n * n * n}");
    n++;
}