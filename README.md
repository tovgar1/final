# Финальная аттестация geekbrains 07.04.2024
Описание:

Создание массивов list, output. Массив list - входной, output - выходной.

В цикле for устанавливается текущий элемент массива list, после чего происходит проверка длины данного элемента:
```csharp
for (int i = 0; i < list.Length; i++)
{
    string element = list[i];

    if (element.Length <= 3)
    {
        Array.Resize(ref output, output.Length + 1); # увеличение длины выходного массива на 1
        output[output.Length - 1] = element;
    }
}
```
Затем идет вывод массива output в консоль методом PrintArray:
```csharp
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write($"'{array[i]}',");
        
    }
}

Console.Write("["); # оформление
PrintArray(output);
Console.Write("]"); # оформление
```
