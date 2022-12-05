﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int [,] a = new int [4,5];

void FillNewArr(int[,] arr ){


for (int i =0; i< arr.GetLength(0); i++)
    {
        for (int j = 0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = (new Random().Next(1,9));
            Console.Write($"  {arr[i,j]}");
        }
        Console.WriteLine();
            }

}

FillNewArr(a);

void Sort(int [,] a){

for (int i = 0; i<a.GetLength(0); i++)
        for (int j = 0; j<a.GetLength(1)-1;j++ )
        {
            int temp = 0;
            if (a[i,j]>a[i,j+1]){
                temp = a[i,j];
                a[i,j] = a[i,j+1];
                a[i,j+1] = temp;
                j=-1;
                }
            
        ;
        }

}

void PrintArr(int [,]Arr){


for (int i =0; i< Arr.GetLength(0); i++)
    {
        for (int j = 0; j<Arr.GetLength(1); j++)
        {
             Console.Write($" {Arr[i,j]}");
        }
        Console.WriteLine();
    }

}
Sort(a);
PrintArr(a);