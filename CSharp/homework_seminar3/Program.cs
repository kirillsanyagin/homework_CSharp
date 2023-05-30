/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*Console.WriteLine("Введите 5ти значное число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num/10000;
int num2 = (num%10000)/1000;
int num3 = (num%1000)/100;
int num4 = (num%100)/10;
int num5 = (num%10);

if ((num>10000 && num<100000) && (num1==num5)&&(num2==num4))
{
Console.Write("Число - палиндром");
}
else
{
    Console.WriteLine("Ошибка.Вы ввели не 5тизначное число");
}
*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


/*Console.WriteLine("Введите число x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число z");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число z1");
int z1 = Convert.ToInt32(Console.ReadLine());

// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2) Формула для нахождения расстояния в 3D пространстве


double num = Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2)+Math.Pow((z1-z),2));

Console.WriteLine(num);
*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

if(num<count)
{
    Console.WriteLine("Введите еще раз");
}

while(num>=count)
{
    Console.WriteLine(Math.Pow(count,3));
//  Math.Pow - возводит указанное число в заданную степень. Число "count" , степень "3". 
    count = count +1;  
}