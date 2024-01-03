// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.Write("Введите размерность m массива: "); 
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите размерность n массива: "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// double[,] randomArray = new double[m, n]; 
// Console.Write("Введите позицию строки: "); 
// int m2 = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите позицию столбца: "); 
// int n2 = Convert.ToInt32(Console.ReadLine()); 
// void mas(int m, int n) 
//     { 
//     int i, j; 
//     Random rand = new Random(); 
//     for (i = 0; i < m; i++) 
//         { 
//         Console.WriteLine(); 
//         for (j = 0; j < n; j++) 
//             { 
//             randomArray[i, j] = rand.NextDouble(); 
//             Console.Write($"{ randomArray[i, j]:F2} "); 
//             } 
//         Console.WriteLine(); 
//         } 
//     } 
// mas(m, n); 
// if (m2 < 1 || n2 < 1) 
//     Console.Write("Позиции строк не могут быть отрицательными"); 
// else if (m2 <= m + 1 && n2 <= n + 1) 
//     Console.Write($"Значение элемента равно { randomArray[m2 - 1, n2 - 1]:F2} "); 
// else Console.Write("Такого элемента нет в массиве");
// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и
// последнюю строку массива.
// namespace ConsoleApp4
// {
// class Programm
//     }
//     static void Main(string[] args)
//     {
// int[,] array = CreateArray(5, 5, 10, 1);
// Console.WriteLine(&quot;До вызова функции ReplaceFirstRowWithLastRow:&quot;);
// PrintArray(array);
// ReplaceFirstRowWithLastRow(array);
// Console.WriteLine(&quot;После вызова функции ReplaceFirstRowWithLastRow:&quot;);
// PrintArray(array);
// }
// /// &lt;summary&gt;
// /// Создает случайный двумерный массив
// /// &lt;/summary&gt;
// /// &lt;param name=&quot;Rows&quot;&gt;число строк&lt;/param&gt;
// /// &lt;param name=&quot;Columns&quot;&gt; число столбцов&lt;/param&gt;
// /// &lt;param name=&quot;MaxValue&quot;&gt;максимальное значение&lt;/param&gt;
// /// &lt;param name=&quot;MinValue&quot;&gt;минимальное значение&lt;/param&gt;
// /// &lt;returns&gt;&lt;/returns&gt;
// public static int[,] CreateArray(int Rows, int Columns, int MaxValue, int MinValue)
// {
// //Возвращаемый массив
// int[,] Result = new int[Rows, Columns];
// Random random = new Random();
// for (int i = 0; i &lt; Rows; i++)
//     {
//     for (int j = 0; j &lt; Columns; j++)
//         {
//         Result[i, j]=random.Next(MinValue, MaxValue);
//         }
//     }
//     return Result;
// }
// public static void ReplaceFirstRowWithLastRow(int[,] Array)
//     {
//     int tmp;
//     int Rows = Array.GetUpperBound(0)+1;
//     for (int i = 0; i &lt; Array.Length/Rows; i++)
//     }
// tmp = Array[0, i];
// Array[0, i]=Array[Rows-1, i];
// Array[Rows-1, i]=tmp;
// {
//     {
//     public static void PrintArray(int[,] Array)
//         {
//         int Rows = Array.GetUpperBound(0)+1;
//         for (int i = 0; i &lt; Rows; i++)
//             {
//         for (int j = 0; j &lt;Array.Length/Rows; j++)
//             {
//             Console.Write($&quot;{Array[i, j]}\t&quot;);
//             }
//             Console.WriteLine();
//             }
//         }
//     }
// }
// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// using System;

// namespace MinSumRow
// {
//     class Programm
//     {
//         static void Main(string[] args)
//         {
//         // Создание прямоугольного двумерного массива
//         int[,] array = { {1 , 2, 3 }, {4, 5, 6 }, {7, 8, 9 }, {10, 11, 12 } };

//         // Нахождение строки с наименьшией суммой элементов
//         int MinSumRow = 0;
//         int intSum - int.MaxValue;
//         for (int i = 0; i < array.getlength(0); i ++)
//             {
//             int sum = 0;
//             for (int j = 0; j < array.getlength(1); j ++)
//             {
//                 sum += array[i, j];
//             } 
//             if (sum < minSum)
//             {
//                 MinSumRow = sum;
//                 MinSumRow = i;
//             }
//             }
//             // Вывод строки с наименьшей суммой элементов
//             Console.WriteLine ("Страка с наименьшей суммой элементов: ");
//             for (int j = 0; j < array.getlength(1); j ++)
//             {
//             Console.WriteLine(array[MinSumRow, j] + " ");
//             }

//         }
//     }
// }
