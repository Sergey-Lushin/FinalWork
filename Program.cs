//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Console.WriteLine("Введите массив строк через пробел");
string text = Convert.ToString(Console.ReadLine()!);           
string[] array = text.Split(' ');
string[] newArray = new string[array.Length];
ArrayOfThreeChar(array, newArray);
PrintArray(newArray);
//------Metods---------
void ArrayOfThreeChar(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}