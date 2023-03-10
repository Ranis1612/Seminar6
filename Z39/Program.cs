/*Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.) */

Console.Clear();
int[]array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ,", array));

int[] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(", ", reversArray));

ReversArray1(array);            // в функцию подставляем массив и он его разворачивает
Console.WriteLine(String.Join(", ", array));

int [] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int [size];
  for(int i = 0; i < size; i ++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

// метод который разворачивает массив но не возвращает данные

void ReversArray1(int[]inArray)     // пишем метод для сортировки массива
{
  for(int i = 0; i < inArray.Length /2; i++)    // делим массив на 2 т.к. после того как перебор пройдёт середину массив развернётся обратно
  {
    int k = inArray[i];                                //  простой !!       int k - вспомогательная переменная
    inArray[i] = inArray[inArray.Length - i -1];      //   обмен !!!!
    inArray[inArray.Length - i - 1] = k;              //   переменных местами !!!!
  }
}    

// метод который разворачивает массив и возвращает в виде массива целых чисел - int[] 
int[] ReversArray2(int[] inArray)
{
  int[] result = new int [inArray.Length];
  for(int i = 0; i < inArray.Length; i++)
  {
    result[i] = inArray[inArray.Length -1 - i];
  }
  return result;
}





