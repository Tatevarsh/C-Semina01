// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.


Console.Write("Введите две цифры: ");
int max = 0;
int min = 0;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
