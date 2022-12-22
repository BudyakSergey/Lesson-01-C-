void FillArray(int[] coll)
{
    int len = coll.Length;
    int index2 = 0;
    while (index2 < len)
    {
        coll[index2] = new Random().Next(1, 10);
        index2 = index2 + 1;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position = position + 1;
    }
}
int[] array = new int[10]; // в массиве 10 элементов
FillArray(array);
PrintArray(array);  