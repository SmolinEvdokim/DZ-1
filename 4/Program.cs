//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Vvedite pervoe 4islo a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite vtoroe 4islo b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite vtoroe 4islo c");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b > c)
{
    Console.WriteLine("Max=");
    Console.WriteLine(a);
}
else if(a > c > b)
{
    Console.WriteLine("Max=");
    Console.WriteLine(b);
}
else if(b > a > c)
{
    Console.WriteLine("Max=");
    Console.WriteLine(b);
}
else if(b > c > a)
{
    Console.WriteLine("Max=");
    Console.WriteLine(b);
}
else if(c > b > a)
{
    Console.WriteLine("Max=");
    Console.WriteLine(b);
}
else if(c > a > b)
{
    Console.WriteLine("Max=");
    Console.WriteLine(b);
}
else  
{
    Console.WriteLine("FEHLER!!");
}