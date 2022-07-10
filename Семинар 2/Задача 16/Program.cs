// Дано число. Проверить кратно ли оно 7 и 23

/*
bool b;
b = true; // 1 
b = false; // 0
b = 2*2 != 5; //<, >, <=, >=, ==, !=
int x = 14;
b = x%7==0;
System.Console.WriteLine(b);
*/

bool b,c,d;
int x = 16;
b = x%7 ==0; // простое (элементарное) условие
c = x%23 ==0;
d = b && c; // сложное условие
System.Console.WriteLine(x);
/*
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(d);

System.Console.WriteLine(x%7 ==0 && x %23 ==0); // && - Укороченное И, || - Укороченное ИЛИ, ^ - Исключающее ИЛИ, ! - НЕ
*/
if (d)
{
    System.Console.WriteLine($"{x} Кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"{x} Не кратно 7 и 23");
}