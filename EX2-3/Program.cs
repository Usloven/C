// See https://aka.ms/new-console-template for more information
int Day = Convert.ToInt32(Console.ReadLine());
while (Day>7){Console.WriteLine("введите цифру от 1 до 7");
Day = Convert.ToInt32(Console.ReadLine());
}
if (Day<6){
    Console.WriteLine("нет");
}
else {Console.WriteLine("да");}