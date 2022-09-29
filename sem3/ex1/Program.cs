/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
 */

Console.Clear();
Console.WriteLine("");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);



///Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает число исключая вторую цифру.

/* 
while (true)
{

Console.Clear();
Console.WriteLine("********************************");
Console.Write("Введите трехзначное число: ");

ulong number = ulong.Parse(Console.ReadLine());
int r = (int)Math.Log10((double)number) + 1;
int num1 = Convert.ToInt32(number);
int a2 = num1 % 10;
int a1 = num1 /10 /10 *10 +a2;

if (r < 3 || r >3) 
{ 
  Console.WriteLine("");
  Console.WriteLine($"||Знаете, тут такое дело, введенное Вами число {num1} не является трехзначным!");
       }
else 
{
    Console.WriteLine("");
    Console.WriteLine($"|| Уберем вторую цифру из числа {num1} и получается число {a1} ||");
    Console.WriteLine("Задача решена!");

}
Console.WriteLine("");
Console.WriteLine("Если хотите повторить нажмите Enter, для выхода введите любой символ.");


string answ = Console.ReadLine();
if (!String.IsNullOrEmpty(answ))
    break;
} */