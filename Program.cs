//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write ("Input your number_1: ");
int number_1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input your number_2: ");
int number_2 = Convert.ToInt32 (Console.ReadLine());

if (number_1 > number_2)
{
    Console.WriteLine ($"Max number is {number_1}. Min number is {number_2} ");
}
else
{
    Console.WriteLine ($"Max number is {number_2}. Min number is {number_1} ");
} */



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write ("Input your number_1: ");
int number_1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input your number_2: ");
int number_2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input your number_3: ");
int number_3= Convert.ToInt32 (Console.ReadLine());

int max_number=0;

if (number_1>max_number)
{
    max_number=number_1;
}
if (number_2>max_number)
{
    max_number=number_2;
}
if (number_3>max_number)
{
    max_number=number_3;
}
Console.WriteLine ($"Max number is {max_number}"); */



//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write ("Input your number: ");
int number = Convert.ToInt32 (Console.ReadLine());
int remDiv = number % 2;
if (remDiv == 0)
{
    Console.WriteLine ("Your number is positive! ");
}
else
{
    Console.WriteLine ("Your number is negative! ");
} */


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write ("Input your number: ");
int number = Convert.ToInt32 (Console.ReadLine());

int evenNumber = 2;
if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
} */
 