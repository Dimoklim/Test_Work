// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] array = { "123", "23", "hello", "world", "res" };

void threeСharArray(string[] array)
{
    string[] newarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[i] = array[i]; ;
            Console.Write($"{newarr[i]} ");
        }
    }
}

threeСharArray(array);