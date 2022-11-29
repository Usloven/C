// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void FillArr (int[] Array)
{
      for (int i=0;i<Array.Length;i++)
      {
        Array[i] = new Random().Next(1,10);
            
      }
      Console.WriteLine(String.Join(",",Array));
} 

void ArrSumNotDivPosision (int[] Array)
{
    int result =0;
    for (int i=0;i<Array.Length;i=i+2)
      {
        result = result + Array[i];
      }
      Console.WriteLine(result);

}
int[] nums = new int[5];
FillArr(nums);
ArrSumNotDivPosision(nums);
