// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int number = Prompt("Введите количество элементов массива: ");
string[] str1 = new String[number];
FillArray(str1);


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