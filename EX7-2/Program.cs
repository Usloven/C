// See https://aka.ms/new-console-template for more information
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



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

void FindPosArr (int [,] Arr, int k, int l)
{
    Console.Write($"  {Arr[k,l]}");
}

FindPosArr(Arr1,2,1);