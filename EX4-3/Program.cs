void PrintArr (int[] Array)
{
      for (int i=0;i<Array.Length;i++)
      {
        Array[i] = new Random().Next(1,10);
            
      }
      Console.WriteLine(String.Join(",",Array));
} 

int[] nums = new int[8];
PrintArr(nums);

