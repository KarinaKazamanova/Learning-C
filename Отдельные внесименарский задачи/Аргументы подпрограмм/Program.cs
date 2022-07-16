void Swap (ref int a, ref int b) // подпрограмма обмена переменами местами (из-за добавления ref при запуске swap в новые переменные а и b будет хранится не значения старых a и b, а ссылки на старые переменные, таким образом можно поменять переменные внутри)
{
    int t =a;
    a=b;
    b=t;
}
void Calc (int a, int b, out int sum, out int sub) // при out мы обязаны присвоить значения к переменным с out
{
    sum=a+b;
    sub=a-b;
}

int n=Convert.ToInt32(Console.Readline());
int n=int.Parse(Console.ReadLine());
string s;
int n;
bool f;
do
{
    s=Console.ReadLine();
    f=int.TryParse(s, out n);
    if (f==false) System/Console.WriteLine("Wrong input");

}
while (f==false);
System.Console.WriteLine(n);
if (f==false)
{
    System.Console.WriteLine("Wrong input");
}
int a,b, sum, sub;
a=1;
b=2;
System.Console.WriteLine($"{a} {b}");
Swap (ref a, ref b);
System.Console.WriteLine($"{a} {b}");

Calc (a,b, out sum, out sub);
/* 