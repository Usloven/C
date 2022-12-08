

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] a = new int [2,2]{{2,4},{3,2}};
int [,] b = new int [2,2]{{3,4},{3,3}};
int [,] c = new int [2,2];

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



int[,] MultMatr(int[,] a, int[,] b)
    {
        var Matrix = new int[2, 2];

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    Matrix[i, j] = Matrix[i, j] + a[i, k] * b[k, j];
                }
                Console.Write(Matrix[i, j]+ " " );
            }
            Console.WriteLine();
        }

        return Matrix;


    }
PrintArr(a);
PrintArr(b);
MultMatr(a,b);



