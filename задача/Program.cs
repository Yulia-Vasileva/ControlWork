// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] massive = new string[] {"hello", "789", "21", "world"};
string[] newArray = new string[massive.Length];
void SecondArray(string[] massive, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
    if(massive[i].Length <= 3)
        {
        newArray[count] = massive[i];
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
SecondArray(massive, newArray);
PrintArray(newArray);
