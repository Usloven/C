// See https://aka.ms/new-console-template for more information
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void NewArr(int m, int n){
double [,] Arr = new double [m,n];

for (int i =0; i< Arr.GetLength(0); i++)
    {
        for (int j = 0; j<Arr.GetLength(1); j++)
        {
            Arr[i,j] = (Convert.ToDouble(new Random().Next(-1000,1000)))/10;
            Console.Write($" {Arr[i,j]}");
        }
        Console.WriteLine();
    }

}
NewArr (3,4);