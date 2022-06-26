// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99,100); 
}

void PrintArray(int []collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void Find(int [] collection)
{
    int sum = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (i % 2 != 0) sum += collection[i];
    }
    Console.WriteLine(sum);
}

PrintArray(array);
Console.WriteLine();
Find(array);