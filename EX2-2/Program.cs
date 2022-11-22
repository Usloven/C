// See https://aka.ms/new-console-template for more information
string A = Console.ReadLine();
char[] arr; 
arr = A.ToCharArray();
if (A.Length>=3){
   Console.WriteLine(arr[2]);
    }
else{Console.WriteLine("третьей цифры нет");}
