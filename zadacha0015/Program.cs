/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Clear();

Console.Write("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)          
{
    Console.WriteLine("Понедельник - не является выходным днем");
} 

if (day == 2)     
{
    Console.WriteLine("Вторник - не является выходным днем");
}

if (day == 3)     
{
    Console.WriteLine("Среда - не является выходным днем");
}

if (day == 4)     
{
    Console.WriteLine("Четверг - не является выходным днем");
}

if (day == 5)     
{
    Console.WriteLine("Пятница - не является выходным днем");
}

if (day == 6)     
{
    Console.WriteLine("Суббота - выходной)");
}

if (day == 7)     
{
    Console.WriteLine("Воскресенье - выходной)");
}

if (day == 0 || day > 7)
{  
    Console.WriteLine("Неправильный ввод данных");
}