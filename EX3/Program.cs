// See https://aka.ms/new-console-template for more information
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
int[] Num = {A,B,C};

int max = Num[0];
for (int i =0 ;i < Num.Length-1;i++)
{
    
    if (max<Num[i+1])
        {
            max =  Num[i+1];
        }
    
}
Console.WriteLine(max);