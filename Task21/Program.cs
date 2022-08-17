// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();

WriteLine("Введите координату х для точки A: ");
int x1 = int.Parse(ReadLine());
WriteLine("Введите координату y для точки A: ");
int y1 = int.Parse(ReadLine());
WriteLine("Введите координату z для точки A: ");
int z1 = int.Parse(ReadLine());
WriteLine("Введите координату x для  точки B: ");
int x2 = int.Parse(ReadLine());
WriteLine("Введите координату y для  точки B: ");
int y2 = int.Parse(ReadLine());
WriteLine("Введите координату z для  точки B: ");
int z2 = int.Parse(ReadLine());

double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));

WriteLine($"Расстояние между двумя точками в 3D пространстве: {dist:f2}");