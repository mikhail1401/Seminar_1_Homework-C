Console.WriteLine("Task 2.");
// 2. Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.
// a=5, b=7 -> max=7;  a=2, b=10 -> max = 10;  a=-9, b=-3 -> max=-3

Console.WriteLine("Enter the 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max;

if(a>b)
{
    max = a;
    Console.WriteLine("max=" + max);
}
else if (b>a)
{
    max = b;
    Console.WriteLine("max=" + max);
}
else
{
    Console.WriteLine("The numbers are equal");
}


Console.WriteLine("\nTask 4.");
// 4. Напишите программу, которая принимает на вход три числа и выдает
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Enter the 1st number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 2nd number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the 3d number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int maxN;

if(n1>n2 && n1>n3)
{
    maxN = n1;
    Console.WriteLine("The maximum number is " + maxN);
}
else if(n2>n1 && n2>n3)
{
    maxN = n2;
    Console.WriteLine("The maximum number is " + maxN);
}
else if(n3>n1 && n3>n2)
{
    maxN = n3;
    Console.WriteLine("The maximum number is " + maxN);
}


Console.WriteLine("\nTask 6.");
// 6. Напишите программу, которая на вход принимает число и выдает, является ли число
// четным (делится ли оно на два без остатка)
// 4 -> yes;   -3 -> no;   7 -> no

Console.WriteLine("Enter a nubmer: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n%2==0)
{
    Console.WriteLine("Yes, the number is even");
}
else
{
    Console.WriteLine("No, the number is odd");
}


Console.WriteLine("\nTask 8.");
// 8. Напишите программу, которрая на вход принимает чило (N),
// а на выходе показывает все четные числа от 1 до N.
// 5 -> 2, 4;      8 -> 2, 4, 6, 8

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number<0)
{
    number = -number;
}

if(number>=2)
{
    int count = 2;
    while(count<=number)
    {
        Console.WriteLine(count);
        count+=2;
    }
}