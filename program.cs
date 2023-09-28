// Задача №1 
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int str = number * number;

Console.Write("Квадрат числа: ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(str);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



// Задача №2

Console.Write("Введите  первое число ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите  второе число ");
int b = int.Parse(Console.ReadLine());
if (a > b)
 { 
    Console.Write("Наибольшее число " + a + " " + "Наименьшее число " + b); 
 }
else if (a < b) 
 {
    Console.Write("Наибольшее число " + b + " " + "Наименьшее число " + a);
 }
 else if (a == b) 
 {
    Console.Write("Числа равны");
 }
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Задача №3

Console.Write("Введите  первое число ");
int numa = int.Parse(Console.ReadLine());
Console.Write("Введите  второе число ");
int numb = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int numf = int.Parse(Console.ReadLine());
int maxNum = 0;
if (numa > maxNum) maxNum = numa;
if (numb > maxNum) maxNum = numb;
if (numf > maxNum) maxNum = numf;
Console.Write("Максимальное число "+ maxNum);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Задача №4

Console.Write("Введите число ");
int number1 = int.Parse(Console.ReadLine());
int odd = number1 % 2;
if (odd == 0)
 { 
    Console.Write("Число " + number1 + " является четным"); 
 }
else
 { Console.Write("Число " + number1 + " является нечетным"); 
 }
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Задача №5

Console.Write("Введите число от 1 до 100 ");
int num = int.Parse(Console.ReadLine());
int even = 2;

while (num >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Задача 1 ДЗ #2 (Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.)

Console.Write("Введите трехзначное число ");
int a1 = int.Parse(Console.ReadLine());
int a2 = (a1 / 10) % 10;
if (a1 > 100)
{
Console.WriteLine("Вторая цифра числа: " + a2);
}
else 
{
Console.WriteLine("Ввод некоректен");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Задача 2 ДЗ #2 (Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.)

Console.Write("Введите трехзначное число ");
int b1 = int.Parse(Console.ReadLine());
int b2 = (b1 % 100) % 10;
if (b1 >= 100 && b1 < 1000)
{
Console.WriteLine("Третья цифра заданного числа : " + b2);
}
else
{
Console.WriteLine("Третья цифра заданного числа отсутвует");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Задача 2 ДЗ #3 (Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.)

Console.Write("Введите число от 1 до 7: ");
int c1 = int.Parse(Console.ReadLine());
if (c1 >= 6 && c1 < 8)
{
Console.WriteLine("Ура, входной");
}
if (c1 >= 1 && c1 <= 6)
{
Console.WriteLine("Увы, рабочий");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();






