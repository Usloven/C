// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void FillArr (double K1, double B1, double K2, double B2)
{
 double x = 0;
 double y = 0;
 x=(B1-B2)/(K2-K1);
 y= K1*x+B1;
 
Console.WriteLine($"{x},{y}");
} 
Console.Write("Введите K1 числа через enter: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите B1 числа через enter: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите K2  числа через enter: ");
double K2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите B2 числа через enter: ");
double B2 = Convert.ToDouble(Console.ReadLine());

FillArr(K1,B1,K2,B2);

