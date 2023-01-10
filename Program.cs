void PrintArray(string[] array)
{
    Console.Write("Введенный массив ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.WriteLine("]");
}

void PrintArrayElements(string[] array)
{
    Console.Write("Элементы массива, у которых 3 и меньше символов: ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            Console.Write($" \"{array[i]}\" ");
        //else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


Console.Clear();
Console.WriteLine("Введите размер одномерного строчного массива");
int length = Convert.ToInt32(Console.ReadLine());
if (length > 0)
{
    string[] arr = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr[i] = Console.ReadLine();
    }
    PrintArray(arr);
    PrintArrayElements(arr);
}

else Console.WriteLine("Введено недопустимое значение размерности массива");





