
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

string[] ShortStringArray (string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
        if ( array[i].Length < 4) size+=1;
    int index = 0;
    string[] newArray = new string[size]; 
    for (int i = 0; i < array.Length; i++)
        if ( array[i].Length < 4)
        {
            newArray[index] = array[i];
            index+=1;
        }
    return newArray;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = CreateStringArray(size);
showArray(myArray);
string[] newArray = ShortStringArray (myArray);
Console.WriteLine("Строки, длина которых <= 3 : ");
showArray(newArray);
