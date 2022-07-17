// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// Число автоматически генерируется из диапазона от 10 до 999.

int x = new Random().Next(10, 1000);

if (x > 99)
{
    int y = x % 10;
    Console.WriteLine(x);
    Console.WriteLine(y);
}
else
{
    Console.WriteLine(x);
    Console.WriteLine("третьей цифры нет");
}