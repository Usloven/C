// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void Printa(int [,]a){


for (int i =0; i< a.GetLength(0); i++)
    {
        for (int j = 0; j<a.GetLength(1); j++)
        {
             Console.Write($" {a[i,j]}");
        }
        Console.WriteLine();
    }

}



// рррррррррррррррррррррррррррррррррррррррр

// рррррррррррррррррррррррррррррррррррррррр
int [,] a = new int [4,4];
int i =1;
int size = a.GetLength(0)*a.GetLength(1)+1;
int l = 0;
int k=1;
void direction (int row, int col, int count=0 )
{   
    if (col==a.GetLength(1)-1&&row==a.GetLength(0)-1){
        k=-1;
        l=0;
    }
    else if (col==a.GetLength(1)-1&&row!=a.GetLength(0)-1){
        k=0;
        l=1;
    } 
    else if (col==0&&row==0){
        k=1;
        l=0;
    }
   
    else if (col==0&&row!=0){
        k=0;
        l=-1;
    }
   
}
// рррррррррррррррррррррррррррррррррррррррр

void ChangeDirect ()
{
    if (k==1&&l==0)
    {
        k=0;
        l=1;
        }
    else if (l==1&&k==0)
    {
        k=-1;
        l=0;
        }
    else if (l==0&&k==-1)
    {
        k=0;
        l=-1;
        }
    else if (l==-1&&k==0)
    {k=1;
    l=0;
    }
    
}

void fillrow (int row, int col)
{   
    
    if (i<size){
        a[row,col]=i;
                i++;
        direction(row,col);
  
        if (a[row+l,col+k]>0){
            ChangeDirect();
            
            fillrow(row+l,col+k);
        }
        else {
            fillrow(row+l,col+k);
        }
        
    }
}

fillrow(0,0);

Printa(a);

