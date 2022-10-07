/*10. Напишите программу, котороя на вход принимает 3-ёх значное число и на выходе показывает вторую цифру этого числа
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите чило");
int number = int.Parse(Console.ReadLine());

if(number < 1000 && number > 99)
{
    Console.WriteLine(number/10 %10);
}
else
    Console.WriteLine("Введенно не 3-ёх значное число");
