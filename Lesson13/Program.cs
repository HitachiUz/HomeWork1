/*13. Напишите программу которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите чило");
int number = int.Parse(Console.ReadLine());

if(number < 1000 && number > 99)
{
    Console.WriteLine(number%10);
}
else
{
    Console.WriteLine(number);
    Console.WriteLine("Третьей цифры нет");
}
