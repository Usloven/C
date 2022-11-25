// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more informations
int[] Cube(int Num) 
{
    int [] Result = new int[Num+1];
    for (int i =0; i<Num; i++)
    {
        Result[i] = Result[i+1]*Result[i+1]*Result[i+1];
    }
    
    
    return Result;
}

Console.WriteLine(Cube(2));
// Console.WriteLine(Cube(Convert.ToInt32(Console.ReadLine())));
