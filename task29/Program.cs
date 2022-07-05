// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите числа массива");
int [] array = new int [8];
for (int i =0; i < 8; i ++)
{
    System.Console.WriteLine($"Введите число для элемента {i}:");
    array [i]= int.Parse(Console.ReadLine()!);
}
// for (int i =0; i < 8; i ++)
System.Console.Write("[");
foreach (int i in array)
{
System.Console.Write("{0} ",i);
}
System.Console.Write("\b \b");
System.Console.Write("]");