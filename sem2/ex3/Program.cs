

//12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

//!!!!!!Parse преобразует строку в int16. Convert преобразует в int значение любого типа, к примеру boolean, double, float .
// string? inputString = Console.ReadLine();  //-если проставить ? перед типом переменной то это позволит положить 0 и избавиться от NULL.

/* If (String.IsNullorEmpty(inputString))
a = Convert.ToInt32(inputString());
или 
c int A = Convert.ToInt32(Console.ReadLine()); такой проблемы нет */
//ИЛИ
/* int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int a2 = int.Parse(Console.ReadLine())
 */

Console.Clear();
Console.WriteLine("давай введем два числа и проверим кратность второго числа, первому:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine()); 

int num = a % b;

if ( num == 0 )
{
   Console.WriteLine("Кратно");
}
else
{
Console.Write($"не кратно, оcтаток {num}");
}


/////////////////////////////////////////////////////////////////////
// Еще один вариант с рандомными числами, без ввода

/* Console.Clear();
int Number1 = new Random().Next(1, 10);
int Number2 = new Random().Next(1, 10);

Console.WriteLine($"Число: {Number1}");
Console.WriteLine($"Число: {Number2}");


int result = 0;
if (result == Number1 % Number2)
{

  System.Console.WriteLine($"Число {Number1} кратен числу {Number2}");
}
else
{
  System.Console.WriteLine($"остатот от деления равен {Number1 % Number2}");
};
 */