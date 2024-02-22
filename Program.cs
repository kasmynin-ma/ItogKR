// Задача: 
//Написать программу:
// 1. которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// 2. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// 3. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i += 1)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
string[] ArrayResult (string[] array) //ResultArray
{
    int a = 0; // c
    int b = 0; // j
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) a += 1;
    }
    string[] arrRes = new string[a]; //arrayRes
    for (int i = 0; i < array.Length; i += 1)
     {
        if (array[i].Length <= 3)
        {
            arrRes[b] = array[i];
            b += 1;
        }
    }
    return arrRes;
}
string[] arrFaсt = CreateArray(); //arrayFaсt
Console.WriteLine();
Console.WriteLine("Указанный массив:");
ShowArray(arrFaсt);
Console.WriteLine();
string[] arrRes = ArrayResult(arrFaсt);
Console.WriteLine("Полученный массив из строк, длина которых меньше, либо равна 3 символам:");
ShowArray(arrRes);