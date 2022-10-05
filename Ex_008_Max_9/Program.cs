int Max(int Arg1, int Arg2, int Arg3)
{
    int result = Arg1;
    if(Arg2 > result) result = Arg2;
    if(Arg3 > result) result = Arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 333;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max + " - максимальное число из ряда чисел: " + a1 + " " + b1 + " " + c1 + " " + a2 + " " + b2 + " " + c2 + " " + a3 + " " + b3 + " " + c3 );