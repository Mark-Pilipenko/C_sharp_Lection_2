int[] array = { 21, 2, 43, 4, 5, 66, 7, 43 };
int n = array.Length;
Console.Write("Введите число: ");
int find = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}