// See https://aka.ms/new-console-template for more information
int Pow (int A, int B)
{
    int result = 1;
    for (int i=0; i<B; i++)
    {
        result = result* A;
    }
    return result;
}

Console.WriteLine(Pow(2,10));