int[] array = { 11, 23, 34, 104, 104, 1555, 17, 83, 99 };
int max = array[0];
for (int i = 0; i <=8; i++)
{
    if (array[i] > max) max = array[i];
}

Console.Write(max + " - максимальное число из ряда чисел: ");
for (int i = 0; i <=8; i++)
{
    Console.Write(array[i] + " ");
}