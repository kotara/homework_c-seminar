// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Please enter your first number: ");

int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
   max = num2;
   min = num1;
}
Console.WriteLine("Max number is: " + max + "and minimum is " + min );
Console.WriteLine($"Max number is: {max} and minimum is {min}" );
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Please enter your first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine($"Max number is: {max}" );
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Please enter your  number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Your number {num} is an even" );
}
else
{
    Console.WriteLine($"Your number {num} is not an even" );
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Please enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current_i = 1;


if (num > 0) {
while (current_i <= num)
{
    if(current_i % 2 == 0)
    {
    Console.WriteLine(current_i );
    }
    current_i ++;
}
}
else {
while (current_i >= num)
{
    if(current_i % 2 == 0)
    {
    Console.WriteLine(current_i );
    }
    current_i --;
}

}


