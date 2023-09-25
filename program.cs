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











