

/* 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98 */

Console.Clear();

int randomNum = new Random().Next(100,999); // генерируем случайное число

Console.WriteLine($"Случайное число: {randomNum}");

int a2 = randomNum % 10;
int a1 = randomNum /10 /10 *10 +a2;  

Console.WriteLine($" {randomNum} будет: {a1}");



// второй вариант программы
 
/* int index = 0;

while (true)

{

Console.Clear();

int randomNum  = new Random().Next(100,1000); // случайное число

 int a1 = randomNum % 10; // последняя цифра 
 int a2 = randomNum / 100 * 10 + a1 ; // 4

  index++;

Console.WriteLine($" числа= {a2} в числе {randomNum}");
Console.WriteLine($"итерация - {index}");
Console.WriteLine("Если хотите повторить нажмите Enter");
Console.WriteLine("если нет просто введите любой символ");

string answ = Console.ReadLine();

if (!String.IsNullOrEmpty(answ))

    break;

} */