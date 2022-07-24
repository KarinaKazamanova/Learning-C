// По заданному с клавиатуры номеру дня недели вывести его название.
while (true)
{
    Console.WriteLine("Введите число от 1 до 7");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
         Console.WriteLine("Понедельник");
         break;
    }
    else if (a == 2)
    {
         Console.WriteLine("Вторник");
         break;
    }
    else if (a == 3)
    {
         Console.WriteLine("Среда");
         break;
    }
    else if (a == 4)
    {
         Console.WriteLine("Четверг");
         break;
    }
    else if (a == 5)
    {
         Console.WriteLine("Пятница");
         break;
    }
    else if (a == 6)
    {
         Console.WriteLine("Суббота");
         break;
    }
    else if (a == 7)
    {
         Console.WriteLine("Воскресенье");
         break;
    }
    else
    {
         Console.WriteLine("Введено неверное число.");
         continue;
    }
}

/*
switch(dayOfweek)
{
     case 1:
          System.Console.WriteLine("Пн");
          break;
     case 2:
          System.Console.WriteLine("Вт");
          break;
          ...

}
*/
