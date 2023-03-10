// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/* Ctrl + F5 запуск приложения без отладки
F5 запуск приложения с отладкой
Shift + F5 остановка отладки
F9 вставка / удаление точки останова
F10 шаг без захода в метод (во время отладки)
F11 шаг с заходом в метод (во время отладки)
Ctrl + Shift + F5 перезапуск отладки
Shift + F11 шаг с выходом из метода (во время отладки)
Ctrl + m + m свернуть код метода, когда курсор находится в каком-то месте этого кода; чтобы развернуть его, используйте ту же комбинацию клавиш */

string GetFormattedDate()
{
    DateTime theDate = DateTime.Now;
    return theDate.ToString("dd/MM/yyyy");
}
Console.WriteLine($" {GetFormattedDate()} ");

int z = 5;
Console.WriteLine(z);



