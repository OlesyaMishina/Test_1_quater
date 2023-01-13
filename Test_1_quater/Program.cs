// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine($"Введите строку, разделяя группы символов ', ':");
string[] array = Console.ReadLine().Split(", ");
string[] resultarray = FindArray(array);
if (resultarray.Length == 0)
    Console.WriteLine("В массиве нет элементов длиной меньше или равной 3 символам.");
else
    Console.WriteLine($"Элементы массива с длиной не больше 3 символов: {string.Join(", ", resultarray)}");

// Функция формирует массив строк с длиной не больше 3.
string[] FindArray(string[] a)
{
    int count = 0;
    foreach (string el in a)
        if (el.Length <= 3)
            count++;
    string[] a2 = new string[count];
    for (int i = 0, j = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
        {
            a2[j] = a[i];
            j++;
        }
    }
    return a2;
}


