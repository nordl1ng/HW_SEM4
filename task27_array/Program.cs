// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
string s = (Console.ReadLine());
int dlina = s.Length;
int l = Int32.Parse(s);
int[] array = new int[dlina];
int summ = 0;
for (int i = 0; i < dlina; i = i + 1)
{
    array[i] = l % 10;
    summ = summ + array[i];
    l = l / 10;
}
System.Console.WriteLine(summ);