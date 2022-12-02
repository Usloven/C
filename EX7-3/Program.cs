
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int [,] Arr1 = new int [3,3];

void FillNewArr(int[,] arr ){


for (int i =0; i< arr.GetLength(0); i++)
    {
        for (int j = 0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = (new Random().Next(0,1000))/10;
            Console.Write($"  {arr[i,j]}");
        }
        Console.WriteLine();
            }

}

FillNewArr(Arr1);

void ArrAVGColumn (int [,] Arr)
{
    Console.Write("Средние значения: ");
    int result = 0;
   for (int j =0 ; j<Arr.GetLength(0); j++)
   {int sum = 0;

    
            for (int i=0; i<Arr.GetLength(1); i++)
            {
                
                sum = sum + Arr[i,j];
                result = (sum)/Arr.GetLength(1);
                

            }  
            
            Console.Write(result);
            Console.Write(" ");
    } 

}

ArrAVGColumn(Arr1);