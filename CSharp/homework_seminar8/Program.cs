// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,columns];


void Array(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,100);
        }
    }
}

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"   ");
        }
        Console.WriteLine();
    }
}
void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1);j++)
                {
                for (int z = 0; z < array.GetLength(1)-1; z++)
                    {
                        if(array[i, z] < array[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                            {
                                int temp = array[i, z+ 1];
                                array[i, z +1 ] = array[i, z];
                                array[i, z ] = temp;
                            }
                    }
                }
        }
      
}

Array(array);
PrintArray(array);
SelectionSort(array);
Console.WriteLine();
PrintArray(array);
*/
// Решение задачи взял у однокурсников. Подскажите чем является Z в методе?
// И если можно расскажите на примере нескольких цифр, как будет осуществляться сортировка.



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*int [,] array = new int [3,3];

void Array()
{
    for (int i = 0 ; i < array.GetLength(0); i++)
        {
            for (int j = 0 ; j < array.GetLength(1); j ++)
                {
                    array[i,j] = new Random().Next(10,101);
                    Console.Write(array[i,j]+"  ");
                }
                Console.WriteLine();
        }
}
void SumRows()
{
    int sum = 0;
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==j)
            {
                sum += array[0,j];
                sum1 += array[1,j];
                sum2 += array [2,j];
            }
        }
    }
        Console.Write($"сумма 1ой строки = {sum}, сумма 2ой строки = {sum1}, сумма 3ей строки = {sum2}");
        Console.WriteLine();
            if((sum<sum1&&sum<sum2))
            {
            Console.WriteLine("Строка с наименьшей суммой элементов - строка 1");
            }
            if((sum1<sum)&&(sum1<sum2))
            {
                Console.WriteLine("Строка с наименьшей суммой элементов - строка 2");
            }
            if((sum2<sum)&&(sum2<sum1))
            {
                Console.WriteLine("Строка с наименьшей суммой элементов - строка 3");
    }
} 
Array();
SumRows();
*/




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*int [,] array =new int [2,2];
void Array()
{
    for (int i = 0 ; i < array.GetLength(0); i++)
        {
            for(int j = 0 ; j < array.GetLength(1); j++)
            {
                array[i,j]= new Random().Next (1,10);
                Console.Write(array[i,j]+"  ");
            }
            Console.WriteLine();
        }
}
int [,] array2 =new int [2,2];
void Array2()
{
    for (int i = 0 ; i< array2.GetLength(0); i++)
        {
            for(int j = 0 ; j < array2.GetLength(1); j++)
            {
                array2[i,j]= new Random().Next (1,10);
                Console.Write(array2[i,j]+"  ");
            }
            Console.WriteLine();
        }
}
int [,] array3 =new int [2,2];
void Array3()
{
for (int i = 0; i<array3.GetLength(0);i++)
{
    for (int j = 0; j<array3.GetLength(1);j++)
    {
        int result = 0;
        for (int k = 0 ; k<array3.GetLength(1);k++)
        // k - новая переменная , в которую будут записываться значения третьего массива
        {
            result += (array[i,k]*array2[k,j]);
        }
        Console.Write(result+"  ");
    }
    Console.WriteLine();
}
}

Array();
Console.WriteLine("_______");
Array2();
Console.WriteLine("______");
Array3();
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*int [,,] array = new int [2,2,2];

void Array()
{
    int count = 10;
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0 ; j<array.GetLength(1); j++)
        {
            for(int k = 0 ; k<array.GetLength(2); k++)
            {
                array[i,j,k] += count;
                count +=2;        
            }
        }
    }
}
// Array();
void ArrayIndex()
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0 ; j<array.GetLength(1); j++)
        {
            for(int k = 0 ; k<array.GetLength(2); k++)
            {
                Console.Write($"{array[i,k,j]}  ({i}, {k}, {j})");
            }          
              Console.WriteLine();     
        }
    }
}
Array();
ArrayIndex();
*/
        
    

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*int[,] matrix = new int[4, 4];
int num = 1;
void SpiralMatrix(int[,] array, int arg)
{
    int i = 0;
    int j = 0;
    while (arg <= 16)
    {
        array[i, j] = arg;
        if (i <= j + 1 && i + j < 3)
            ++j;
        else if (i < j && i + j >= 3)
            ++i;
        else if (i >= j && i + j > 3)
            --j;
        else
            --i;
        arg++;
    }
}

void PrintResultArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("D2")} ");
        }
        Console.WriteLine("");
    }
}

SpiralMatrix(matrix, num);
PrintResultArray(matrix);
*/

// 2ой вариант решения
/*int[,]array = new int [4,4];
int count = 0;
int i= 0; 
int j = 0;

for(j=0;j<array.GetLength(1);j++) //0ая строка
{
    array[i,j] =1+ count; 
    count++;
}
j=3;
for(i=1;i<array.GetLength(0);i++) //3ий столбец
{
    array[i,j] =1+count;
    count++;
}
i=3;
for(j=2;j>=0;j-=1) //3я строчка
{
    array[i,j] = 1+ count;
    count++;
}
j=0;
for(i=2;i>=1;i-=1) //0ой столбец
{
    array[i,j] = 1+ count;
    count++;
}
i=1;
for(j=1;j<=2;j++) //1ая строка
{
    array[i,j] = 1+ count;
    count++;
}
i=2;
for(j=2;j>=1;j -=1)
{
    array[i,j] = 1+ count;
    count++;
}





for(i=0;i<array.GetLength(0);i++)
{
    for(j=0 ; j<array.GetLength(1);j++)
    {
        Console.Write(array[i,j]+ "  ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");*/