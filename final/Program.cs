
string[] list = new string[] {"1234", "1567", "-2", "computer science"};

string[] output = new string[] { };


for (int i = 0; i < list.Length; i++)
{
    string element = list[i];

    if (element.Length <= 3)
    {
        Array.Resize(ref output, output.Length + 1);
        output[output.Length - 1] = element;
    }
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write($"'{array[i]}',");
        
    }
}
Console.Write("[");
PrintArray(output);
Console.Write("]");