// See https://aka.ms/new-console-template for more information
void FillArr (int[] Array)
{
      for (int i=0;i<Array.Length;i++)
      {
        Array[i] = new Random().Next(100,999);
            
      }
      Console.WriteLine(String.Join(",",Array));
} 

void ArrDiv2 (int[] Array)
{
    int result =0;
    for (int i=0;i<Array.Length;i++)
      {
        if (Array[i]%2==0)
        {
         result = result + 1;
        }    
      }
      Console.WriteLine(result);

}
int[] nums = new int[5];
FillArr(nums);
ArrDiv2(nums);
