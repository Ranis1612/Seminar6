//Задача 42. Напишите программу которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

string res = DecToNum(number, 2);   //  2 в данном случае двоичная система счисления(2,8,16ричная)

Console.WriteLine($"{number} -> {res}");


// универсальная математическая функциядля перевода из 10ричной в двоичную и до шестнадцатиричной
string DecToNum(int decNumber, int otherSystem) // string - возвращаем строку, функция на вход принимает int decNumber(десятиричное число), и 
{                                              // (int otherSystem) систему счисления в которое нужно перевести число
  string res = "";                             // строка для результата
  string nums = "0123456789ABCDEF";            // строка с выражением системы счисления
    while (decNumber > 0)                       // пока (заданное число больше ноля)
      {                                         // 
      int ost = decNumber / otherSystem;         // (int ost) остаток
      res = nums[decNumber - otherSystem * ost] + res;  //[decNumber - otherSystem * ost] - число переворачивать не надо 
      decNumber /= otherSystem;                           // т.к оно сразу пишется в обратном порядке
      }
    return res;
}