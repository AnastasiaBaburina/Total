
string[] CreateStringArray (int size)
{
    string[] array = new string[size];
    Console.WriteLine("Введите " + size + " элементов массива");
    for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToString(Console.ReadLine());
        }   
    return array;
}

void showArray (string[] array)
{
    for (int i = 0; i<array.Length - 1; i++) Console.Write(array[i] + " , ");
    Console.Write(array[array.Length - 1]);
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateStringArray(size);
showArray(myArray);
