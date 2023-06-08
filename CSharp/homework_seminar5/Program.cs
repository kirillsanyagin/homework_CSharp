// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [7];
// int num = 0;
// for ( int i = 0; i < array.Length; i++)
// {
//     array[i]= new Random().Next(99,999); 
//     Console.Write(array[i]+"  ");
// }
// Console.WriteLine();

// for ( int i = 0; i < array.Length; i++)
// {
//     if (array[i]%2==0)
//     {
//         num = num +1;
//     }
// }
// int pos = num; 
// Console.WriteLine($"Количество чётных чисел в массиве = {pos}");
//----------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] array = new int [4];
// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = new Random().Next(-10,20);
//     Console.Write(array[i]+" ");
// }
// int sum = 0;
// for (int i = 1; i < array.Length; i=i+2)
    
//     sum = sum + array[i];
// Console.WriteLine();
// int pos = sum; 
// Console.WriteLine(pos);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int [] array = new int [6];

for (int i = 0 ; i<array.Length;i ++)
    {
    array[i] = new Random().Next(5,20);
    Console.Write(array[i]+" ");
    }

Console.WriteLine();
for (int i = 0 ; i<array.Length;i ++)

{
    int min = array.Min();
    int max = array.Max();
    Console.WriteLine($"Разница между max и min={max-min}");
}
//  подскажите почему кол-во ответов прямопропорционально кол-ву символов в массиве