// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more informations
double Distance(double[]P1, double[]P2)
{
    double dist = 0;
    dist = Math.Pow(((P2[0]-P1[0])*(P2[0]-P1[0])+(P2[1]-P1[1])*(P2[1]-P1[1])+(P2[2]-P1[2])*(P2[2]-P1[2])),0.5) ;
    return dist;
}

double[] numbers1 = { 3, 6, 8 };
double[] numbers2 = { 2, 1, -7};

Console.WriteLine(Distance(numbers1, numbers2));

double[] numbers3 = { 7,-5, 0 };
double[] numbers4 = {1,-1, 9};

Console.WriteLine(Distance(numbers3, numbers4));