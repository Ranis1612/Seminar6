//Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

//int[] copyArray = CopyArray(array);                  // можно и так копирнуть по простому
Console.WriteLine(String.Join(" ", CopyArray(array)));

int[] GetArray(int size, int minValue, int maxValue)  // функция создания массива
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] inArray)      // функция копирования массива
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++) // перебираем массив
    {
        result[i] = inArray[i];            // элементы перебора закидываем в другой массив

    }
    return result;
}
