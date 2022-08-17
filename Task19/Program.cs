// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
using static System.Console;
Clear();

Write("Введите пятизначное число: ");
int number = Convert.ToInt32(ReadLine());

if (number > 9999 && number < 100000)
{
    int Digit1 = number / 10000;
    int Digit2 = number % 10000 / 1000;
    int Digit4 = number % 100 / 10;
    int Digit5 = number % 10;

    string answer; 
    if (Digit1 == Digit5 && Digit2 == Digit4)
    answer = "Да";
    else
    answer = "Нет";
    Write(answer);
}
    else
    Write($"Число введено неверно");