// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int l = Convert.ToString(a).Length;
int summ = 0;
for (int i = 0; i < l; i++)
{
    int b = a % 10;
    a = a / 10;
    summ = summ + b;
}
System.Console.WriteLine($"Сумма цифр в чиcле равна {summ}");