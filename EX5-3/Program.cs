// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


void FillArr (int[] Array)
{
      for (int i=0;i<Array.Length;i++)
      {
        Array[i] = new Random().Next(1,10);
            
      }
      Console.WriteLine(String.Join(",",Array));
} 

void ArrdifMaxMin (int[] Array)
{
    int result =0;
    int max = 0;
    int min = Array[0];
    for (int i=0;i<Array.Length;i++)
      {
        if(Array[i]>max)
        {
          max=Array[i];
        }
      else if (Array[i]<min)
        {
          min = Array[i];
        }
      }
      result = max-min;
      Console.WriteLine(result);

}
int[] nums = new int[5];
FillArr(nums);
ArrdifMaxMin(nums);
