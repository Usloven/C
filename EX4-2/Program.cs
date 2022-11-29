
// int NumberSum(string Num) 
// {
//     int Result = 0;
//     for (int i =0; i<Num.Length; i++)
//     {
       
//         Result = Result + (Num[i]);
        
//         }
    

//     return Result;
// }

//  Console.Write(NumberSum(Console.ReadLine()));

// почему то такой вариант не работет. Пример 234 число выдает  153. Ошибка вроде в 8 строке (на этом моменте что-то идет неправильно, но не понял что)


int NumberSum(int Num) 
{
    int Result = 0;

    while (Num>0)
    {
        Result = Result + Num%10;
        Num = Num/10;
    }
    

    return Result;
}

 Console.Write(NumberSum(122));


