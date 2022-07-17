// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// Число автоматически генерируется из диапазона от 0 до 10.

int x = new Random().Next(0, 11);
if(0 < x )
{
    if(x < 8)
    {
        if(x > 5)
        {
             Console.Write(x);
             Console.Write(" - да");
        }
        else
        {
            Console.Write(x);
            Console.Write(" - нет");
        }
    }
    else
    {
        Console.Write(x);
        Console.Write(" - такого дня недели нет");
    }
}