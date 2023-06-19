// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int endNum = 1;

// string PrintNumbers (int number, int number1)
// {
//     if (number==number1)
//     {
//         return number.ToString();
//     }
//     return (number+" "+PrintNumbers(number-1,number1));
// }
// Console.WriteLine(PrintNumbers(num,endNum));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число m");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число n");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int m,int n)
// {
//     if(m==0)
//     {
//         return (n * (n + 1)) / 2;
//     }
//     else if(n==0)
//     {
//         return (m * (m + 1)) / 2;  
//     }
//     else if(m>n)
//     {
//         return n + SumNumbers(m, n + 1);
//     }
//     else if(n>m)
//     {
//         return n + SumNumbers(m, n - 1);
//     }
//     else
//     {
//         return m;
//     }
// }
// Console.WriteLine($"Сумма чисел из промежутка чисел = {SumNumbers(num, num1)}");

// }
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*Console.WriteLine("Введите число m");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n");
int num1 = Convert.ToInt32(Console.ReadLine());

int result (int m,int n)
{
    if ((m==0)&&(n>0))
    {
        return n+1;
    }
    if ((n==0)&&(m>0))
    {
        return result(m-1,1);
    }
    else
    {
        return result (m-1, result(m,n-1));
    }
}
Console.WriteLine($"A({num}, {num1}) = {result(num,num1)}");

// последняя задача работает не со всеми числами, 
// Если будет видеоразбор, было бы хорошо
*/
