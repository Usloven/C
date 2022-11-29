// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


void FillArr (int[] Array)
{
  int result = 0;
      for (int i=0;i<Array.Length;i++)
      {
        Array[i] = Convert.ToInt32(Console.ReadLine());
       if (Array[i]>0)
       {result=result + 1;}  
      }
      Console.WriteLine(String.Join(",",Array));
      Console.WriteLine(result);
} 


int[] nums = new int[5];
FillArr(nums);

