/*15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Число от 1 до 7");
int a = int.Parse(Console.ReadLine());

if(a > 0 && a < 8)
{
    if (a == 7 || a == 6){
        Console.WriteLine($"Число 6 выходной");
        Console.WriteLine($"Число 7 выходной");
    }
}
else
{
    Console.WriteLine(a);
    Console.WriteLine("Не то число");
}
