// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);
int exp = 1;
for (int i = 0; i < b; i ++)
{
    exp = a*exp;
}
System.Console.WriteLine($"Число {a} в степени {b} равно {exp}");