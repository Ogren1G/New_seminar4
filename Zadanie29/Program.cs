void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"Введите элемент массива под индексом {index}:");
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}
int[] array = new int[8];
FillArray(array);
foreach(int el in array)
{
    Console.Write(el + " ");
}