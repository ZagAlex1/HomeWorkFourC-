// Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

ReadArray(FillArray());

int[] FillArray()
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 41);
    }
    return array;
}

void ReadArray(int[] array)
{
    string newArray = string.Join(" ", array);
    System.Console.WriteLine(newArray);
}