//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Console.WriteLine("Введите массив строк через пробел");
string text = Convert.ToString(Console.ReadLine()!);           
string[] array = text.Split(' ');
string[] newArray = ArrayOfThreeChar(array);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа:");
PrintArray(newArray);
//------Metods---------
string[] ArrayOfThreeChar(string[] arr1)
{
    int count = 0;
    string[] tempArray = new string[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        tempArray[count] = arr1[i];
        count++;
        }
    }
    string[] newArray = new string[count];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = tempArray[i];
        count++;
    }
    return newArray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}