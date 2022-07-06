// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("ВВЕДИТЕ ЧИСЛА МАССИВА");
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    System.Console.WriteLine($"Введите число для элемента {i}:");
    array[i] = int.Parse(Console.ReadLine()!);
}
System.Console.Write("[");
foreach (int i in array)
{
    System.Console.Write("{0} ", i);
}
System.Console.Write("\b \b");
System.Console.Write("]");