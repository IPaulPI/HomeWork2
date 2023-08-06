// Task 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int pair = num / 10;
    int tens = pair % 10;

    int res = tens;
    return res;
}

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int newNumber = CutNumber(num);
Console.WriteLine($"New version of {num} is {newNumber}");
*/
// Task 13. Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number < 1000)
{
    int num = number % 10;
    Console.Write(num);
}
else if(number < 100)
{
    Console.Write("Третьей цифры нет.");
}
else if(number > 999)
{
    int num = number / 10;
    int num1 = num % 10;
    Console.Write(num1);
}
*/

// Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 && num <=5)
{
    Console.Write("Weekdays");
}
else if(num == 6 || num == 7)
{
    Console.Write("Weekend");
}
