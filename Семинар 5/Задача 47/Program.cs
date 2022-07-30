/* Написать программу масштабирования фигуры
Вершины фигуры задаются списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задается отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
56
*/
string Replace (string text, char oldValue, char NewValue)
{
    string result = string.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text [i]== oldValue)
        {
            result += $"{NewValue}";
        }
        else
        {
            result += $"{text [i]}";
        }
    }
    return result;
}
string Delete (string text, char ValueForDelete)
{
    string result = string.Empty;
    int length = text.Length;
    int i = 0;
    while (i<length)
    {
        if (text [i] != ValueForDelete) 
        {
            result += $"{text [i]}"; 
            i++ ;
        }
        else i++;
    }
    return result;
}
double [] Zoom (double [] figure, double k)
{
    for (int i=0; i < figure.Length; i++)
    {
        figure [i] = figure [i]*k;

    }
    return figure;
}
System.Console.WriteLine("Введите координаты");
string? coordinates = Console.ReadLine();
string  coordinates1 = Replace (coordinates, ',' ,' ');
string  coordinates2 = Delete (coordinates1, ')');
string  coordinates3 = Delete (coordinates2, '(');  
string[] figure = coordinates3.Split(" ");
double [] massive = new double [figure.Length];
for (int i =0; i < massive.Length; i++)
        massive[i] = int.Parse (figure[i]);
System.Console.WriteLine("Введите кооффициент масштабирования");
double k = Convert.ToDouble(Console.ReadLine());
double [] ZFigure = Zoom (massive, k);
System.Console.WriteLine($"Координаты масштабированной в {k} раз-(а) фигуры:");
for (int i =0; i < massive.Length; i++)
{
    if (i%2==0)
    {
        System.Console.Write($"({ZFigure[i]},");
    }
    else
    {
        System.Console.Write($" {ZFigure[i]}) ");
    }
}
