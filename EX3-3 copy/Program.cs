// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more informations
string Cube(string Num) 
{
    string Result = "";
    int Amount = Convert.ToInt32(Num);
    for (int i =0; i<Amount; i++)
    {
        Result = Result+" "+Convert.ToString(Math.Pow((i+1),3));
    }
    
    
    return Result;
}

Console.WriteLine(Cube(Console.ReadLine()));