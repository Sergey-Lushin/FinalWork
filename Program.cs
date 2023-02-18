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
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        count++;
        }
    }
    int count2 = 0;
    string[] newArray = new string[count];
    for (int j = 0; j < arr1.Length; j++)
    {
    if (arr1[j].Length <= 3)
        {
        newArray[count2] = arr1[j];
        count2++;
        }    
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