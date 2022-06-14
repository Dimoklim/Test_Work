// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] array = { "hello", "2", "world", ":-)" };
string[] newarr = new string[array.Length];

string[] ThreeСharArray(string[] array) 
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[j] = array[i]; ;
            j++;
        }
    }
    return newarr;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

ThreeСharArray(array);
PrintArray(newarr);