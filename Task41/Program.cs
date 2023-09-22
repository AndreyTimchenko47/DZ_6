// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArrayRndInt(int size)
{
int[] arr = new int[size];
int number = 0;
for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число");
        number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    return arr;
}

int FindPositiveNumbers(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0) sum++;
        }
    return sum;
}



void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(Size);
PrintArray(array);
Console.WriteLine();

int search = FindPositiveNumbers(array);
Console.WriteLine($"Количество значений больше 0 в массиве составляет {search}");