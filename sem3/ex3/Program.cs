/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет. */

while (true)
{

Console.Clear();
Console.WriteLine("**************************************************");
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNum) {
  if (dayNum == 6 || dayNum == 7) {
  Console.WriteLine("|| Этот день, конечно же выходной! ||");
  }
  else if (dayNum < 1 || dayNum > 7) {
    Console.WriteLine("|| Ну что же Вы, укажите число от 1 до 7! ||");
  }
  else Console.WriteLine("|| Введенный день недели не выходной! ||");
}

CheckingTheDayOfTheWeek(dayNum);

Console.WriteLine("");
Console.WriteLine("************************************************************************");
Console.WriteLine("Если хотите повторить нажмите Enter, для выхода введите любой символ.");


string answ = Console.ReadLine();
if (!String.IsNullOrEmpty(answ))
    break;
}