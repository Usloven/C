// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




int [,] a = new int [10,10];

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


void SumRow (int [,] a){
int [] result = new int [a.GetLength(0)];
for (int i = 0; i<a.GetLength(0); i++){
     int sum = 0;
        for (int j = 0; j<a.GetLength(1);j++ )
        {
           
            sum = sum + a[i,j];
            result[i] = sum;       
        }
 Console.Write(   $" {result[i]}"  );
}
int maxrow = 0;
int maxrownum = 0;
for (int k = 0; k<result.Length; k++)
{
        if (result[k]>maxrow)
    {
        maxrow = result[k];
        maxrownum = k;
        
    }
   

}
Console.WriteLine();
Console.WriteLine($"Номер максимальной строки {maxrownum+1}" );
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
FillNewArr(a);
PrintArr(a);
SumRow(a);