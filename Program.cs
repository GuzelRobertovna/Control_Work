// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int length = Prompt("Введите количество элементов массива: ");
string[] str1 = new String[length];
FillArray(str1);
Console.WriteLine("Сформированный массив:");
PrintArray(str1);
string[] str2 = GetNewArray(str1);
Console.WriteLine("Новый массив:");
PrintArray(str2);


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

void FillArray(string[] Str)
{
    for (int i = 0; i < Str.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        Str[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] Str)
{
    Console.Write("[");
    for (int i = 0; i < Str.Length; i++)
    {
        Console.Write($" {Str[i]} ");
    }
    Console.WriteLine("]");
}

string[] GetNewArray(string[] Str)
{
    int j = 0;
    string[] NewStr = new String[Str.Length];
    foreach (string el in Str)
    {
        if (el.Length <= 3)
        {
            NewStr[j] = el;
            j++;
        }
    }
    return NewStr;
}