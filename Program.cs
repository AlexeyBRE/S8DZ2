// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[n, m];
int sum=0;
 int[] sumLine=new int[n];
 int minLine=0;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {

        num[i, j] = new Random().Next(1, 100);
        Console.Write($"   {num[i, j]}");
    }
    Console.WriteLine();
}
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        sum+=num[i,j];
        
    }
        sumLine[i]=sum;
       
    sum=0;
    }
 foreach (var item in sumLine)
 {
    Console.Write($"   {item}");
 }
 
  for (int i = 0; i < sumLine.Length-1; i++)
  {
    if(sumLine[i]<sumLine[i+1])
    {
        minLine=i;
    }
  }
  Console.Write($"   номер строки с наименьшей суммой элементов:{minLine} строка");