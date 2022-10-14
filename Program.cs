// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string ReadDate(string line)                // Метод для чтения данных
{
    Console.Write(line);
    string date = Console.ReadLine() ?? "0";
    date = date.Replace(" ", "");
    return date;
}

string[] SplitMet(string date)              // Метод: разбиваем по запятой строку на элементы
{
    string[] array = date.Split(",");
    return array;
}
                                            //        и записываем в массив
string[] ChangeArray(string[] arr)          // Выбираем элементы с длинной <=3
{
    string res = string.Empty;
    for (byte i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            res = res + arr[i] + " ";
    }
    string[] array = res.Split(" ");
    return array;
}

void Print1DArray(string[] array)           // Метод: печать массива
{
    Console.Write("\r\nМассив, соответствующий условиям: ");
    foreach (string value in array)
        Console.Write($"{value} ");
}

Print1DArray(ChangeArray(SplitMet(ReadDate("Введите данные через запятую: "))));


