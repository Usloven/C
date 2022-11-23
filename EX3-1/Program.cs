// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more informations
string Palindrom (string Num1)
{
     string Answer = string.Empty;
for (int i=0;i<Num1.Length;i++)
{
   
    if (Num1[i]==Num1[Num1.Length-1-i])
    {;
    Answer = "да";
    }
    else {
        Answer = "нет";
        break;
    }
    
}
return Answer;
}

Console.WriteLine(Palindrom(Console.ReadLine()));