// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] Array2d(int rows, int cols, int min, int max)
// {
//     double [,] arr = new double [rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)       
//         {
//             arr[i, j] = Convert.ToDouble(new Random().Next(min, max));
//         }
//     }
//     return arr;
// }

// void PrintArray2d(double [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)       
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минмальное число a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// PrintArray2d(Array2d(m, n, a, b));




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void Array(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)       
//         {
//             arr[i, j] = Convert.ToInt32(new Random().Next(10, 100));
//         }
//     }
// }

// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)       
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchElement(int [,] array, int row, int col)
// {
//     if (row > array.GetLength(0) - 1)
//     {
//         Console.WriteLine();
//         Console.WriteLine("Искомый элемент не найден, превышен предел строки");
//     }
//     else if (col > array.GetLength(1) - 1)
//     {
//         Console.WriteLine();
//         Console.WriteLine("Искомый элемент не найден, превышен предел столбца");
//     }
//     else
//         Console.WriteLine();
//         Console.WriteLine($"Искомый элемент {array[row, col]}");
// }

// Console.Write("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int col = Convert.ToInt32(Console.ReadLine());
// int [,] arr = new int [5, 10];
// Console.WriteLine();
// Array(arr);
// PrintArray(arr);
// SearchElement(arr, row, col);




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Array(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)       
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(0, 10));
        }
    }
}

// void PrintArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)       
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ArithmeticMean(int [,] arr)
// {
//     string avs = string.Empty;
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         double sum = 0;
//         // double avs = 0;
//         for (int j = 0; j < arr.GetLength(0); j++)       
//         {
//             sum = (sum + arr[j, i]);  
//         }
//         avs = avs + Math.Round(sum / arr.GetLength(0), 1) + "; ";
//     }
//     Console.WriteLine("Среднее арифметическое каждого столбца: " + avs);
// }
// int [,] arr = new int [3, 5];
// Array(arr);
// PrintArray(arr);
// Console.WriteLine();
// ArithmeticMean(arr);
