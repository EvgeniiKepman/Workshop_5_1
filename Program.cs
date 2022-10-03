// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int count = 8;
int[] array = new int[count]; 
int n = 0;

AddArray(array);
PrintArray(array);

void AddArray(int[] array)
{
    Random rand = new Random();
    for(int i = 0; i < count; i++)
    {
        array[i] = rand.Next(100,999);
    if(array[i] % 2 == 0)
    n = n + 1;
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");

        if(i == count - 1)

            Console.WriteLine($"], колличество четных чисел - {n}");

        else Console.Write(", ");
    }
    Console.WriteLine();
}
