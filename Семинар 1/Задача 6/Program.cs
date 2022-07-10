// Написать программу вычисления значения функции y = sin(a). (Класс Math) (Считаю, что числом вводятся градусы, а не радианы)
Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
double angle = Math.PI * a / 180.0;
double b = Math.Sin(angle);
Console.WriteLine(b);


/*
тип возвращаемого значения          Имя_Функции    (аргумент с его типом)
double                              Sin           (double x)
{
    return Math.Sin(x);
}

double y = Sin(3.14)                Собственная подпрогорамма (функция
*/

/*
Функция, которая ничего не возвращает, то есть метод, поэтому Console.WriteLine(Pause); не сработает
void Pause() (если бы void не было, то return должен быть)
{
    return; (в данном случае return досрочно прекращает работу программы и нижняя строчка становится недостижимой)
    Console.WriteLine("Press any key");
}
*/