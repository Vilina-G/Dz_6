// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//     
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых," +
                  " заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
var = = GetEnteredNumbers("Введите b1, k1, b2, k2 через пробел или запятую :");
var = = GetIntersectionPoints(enteredNumbers);
// if (points[0] != 0 && points[1] != 0)
// {
    Console.WriteLine($"b1 = {enteredNumbers[0]}, " +
                      $"k1 = {enteredNumbers[1]}, " +
                      $"b2 = {enteredNumbers[2]}, " +
                      $"k2 = {enteredNumbers[3]} -> ({points[0]}; {points[1]})");
// }

static double[] GetIntersectionPoints(int[] arrayPoints)
{
    double b1, k1, b2, k2;
    double x = 0, y = 0;
    if (arrayPoints.Length == 4)
    {
        b1 = arrayPoints[0];
        k1 = arrayPoints[1];
        b2 = arrayPoints[2];
        k2 = arrayPoints[3];
        if ((k1 == k2) && (b1 == b2))
            Console.WriteLine("Прямые совпадают");
        else if (k1==k2)
            Console.WriteLine("Прямые параллельны");
        else
        {
            x=(b2-b1)/(k1-k2);
            y=(k1*(b2-b1))/(k1-k2)+b1;
        }
    }
    return new double[]{x, y};
}

static int[] GetEnteredNumbers(string outputText = "")
{
    var arrayInts = Array.Empty<int>();
    Console.WriteLine(outputText);
    char[] separators = { ' ', ',' };
    var arrayOfEnteredText = Console.ReadLine()
        ?.Split(separators,
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    if (arrayOfEnteredText != null)
    {
        arrayInts = Array.ConvertAll(arrayOfEnteredText, s => int.Parse(s));
    }
    return arrayInts;
}