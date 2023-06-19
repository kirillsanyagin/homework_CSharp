// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int rows  = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [ rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i ++)
// {
    
//     for (int j = 0; j < matrix.GetLength(0); j ++)
//     {
        
//         matrix [i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
//         Console.Write(matrix[i,j]+"    ");
//     }
//     Console.WriteLine();
// }

/*2ой способ через методы 

Console.WriteLine("Введите количество строк");
int rows  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [ rows, columns];

void Array()
{
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(0); j ++)
        {
             matrix [i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
}
void PrintArray()
{
      for (int i = 0; i<matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write(matrix[i,j]+"   ");
        }  
        Console.WriteLine();
    }
}
Array();
PrintArray();*/



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*Console.WriteLine("Введите количество строк");
int rows  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [ rows, columns];

void Array()
{
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(0); j ++)
        {
             matrix [i, j] = new Random().Next(10,17);
        }
    }
}
void PrintArray()
{
      for (int i = 0; i<matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write(matrix[i,j]+"   ");
        }  
        Console.WriteLine();
    }
}
void FindNumber()
{
    Console.WriteLine("Введите число для нахождения его в массиве");
    int num = Convert.ToInt32(Console.ReadLine());
     for (int i = 0; i<matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    
        if(num==matrix[i,j])
        {
        Console.WriteLine($"{num} -> Такое число есть в массиве");
        }

        else
        {
        Console.WriteLine($"{num} -> Такого числа в массиве нет");
        }
    }
}
Array();
PrintArray();
FindNumber(); */

// Подскажите почему в ответе так много лишней информации


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*Console.WriteLine("Введите кол-во строк");
int ruws = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во строк");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [ruws , columns];

void Array()
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(10,20);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"  ");
        }  
        Console.WriteLine();
    }
}

void Average()
{
    for (int j = 0; j <array.GetLength(1); j++)
    {   
        double Result = 0;       
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Result =Result + array[i,j];
        }
        Console.WriteLine($"{Result / array.GetLength(0)}");
    }
}
Array();
PrintArray();
Average();
*/

