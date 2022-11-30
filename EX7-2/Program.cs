// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



int [,] Arr1 = new int [3,3];

void FillNewArr(int[,] arr ){


for (int i =0; i< arr.GetLength(0); i++)
    {
        for (int j = 0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = (new Random().Next(-1000,1000))/10;
            Console.Write($"  {arr[i,j]}");
        }
        Console.WriteLine();
            }

}

FillNewArr(Arr1);

void FindPosArr (int [,] Arr)
{
    Console.WriteLine("Введите число строки");
    int k =  Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число cтолбца");
    int l =  Convert.ToInt32(Console.ReadLine());
    if (k>Arr.GetLength(0) || l> Arr.GetLength(1) )
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {Console.Write($"  {Arr[k,l]}");}
}

FindPosArr(Arr1);