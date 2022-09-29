/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5.
78 -> третьей цифры нет
32679 -> 6 */

while (true)
{

Console.Clear();
Console.WriteLine("*************************************************************************************");
Console.Write("Что бы вывести третью цифру числа, введите трехзначное число или больше: ");

int anyN = Convert.ToInt32(Console.ReadLine());
string anyNText = Convert.ToString(anyN);
if (anyNText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNText[2]);
}
else {
  Console.WriteLine($"У введенного числа {anyN} третьей цифры нет");
}

Console.WriteLine("");
Console.WriteLine("Если хотите повторить нажмите Enter, для выхода введите любой символ.");
string answ = Console.ReadLine();
if (!String.IsNullOrEmpty(answ))
    break;
} 
