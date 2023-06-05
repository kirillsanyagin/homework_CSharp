/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

    
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

double MathPow()
// Метод возвращает дробные числа (double); название метода(может быть любым)
{
    double Pow = 0; 
    // В ответе должна быть новое число, поэтому создаем новую переменную Pow
    Pow = Math.Pow(A,B);
    // Записываем условие, которое возводит число А в степень B
    return Pow;
    // Если стоит не void в начале метода - ставим return
}
double result = MathPow();
// В result записываем ответ из метода (возможно не так)
Console.WriteLine(result); */
// и консолью вызывает ответ в терминале

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumNumber(int arg)
{
    int result = 0;
    while(arg>0)
    {
        result = result + arg %10;
        arg = arg/10;
    }
    return result;
}
Console.Write($"Сумма всех цифр числа {num} равна {GetSumNumber(num)}");*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
/*void CreateArray()

{
    int [] arr = new int [8];
    int count = 0 ; 
    while (count< arr.Length)
    {
        arr[count]= new Random().Next(0,100);
        Console.Write($"{arr[count]}   ");
        count++;
    }
}
CreateArray();
*/