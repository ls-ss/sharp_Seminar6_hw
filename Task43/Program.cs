// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double[] y1 = InputLine(1); // Вводим коэф. для первого уравнения. y1[0] -> 'К1', y[1] -> 'B1'.
double[] y2 = InputLine(2); // Вводим коэф. для первого уравнения. y2[0] -> 'К2', y[1] -> 'B2'.

Console.WriteLine("----------");
if(y1[0] != y2[0]){
    double[] point = PointIntersection(y1, y2); // Массив с координатами точки пересечения двух прямых.
    PrintPoint(point); // Вывод на консоль
}
else{
    Console.WriteLine("Прямые не пересекаются.");
}

// Ф-ция ввода двух значений коэффициентов (К и В), уравнения y = K * x + B.
double[] InputLine(int n){
    double[] array = new double[2];
    Console.WriteLine($"Введите коээфициенты уравнения прямой y{n} = K{n} * x + B{n} :");
    // Ввод значения коэффициента К.
    Console.Write($"k{n} = ");
    array[0] = double.Parse(Console.ReadLine());
    // Ввод значения коэффициента В.
    Console.Write($"b{n} = ");
    array[1]  = double.Parse(Console.ReadLine());
    return array;
}

// Ф-ция вычисления т. пересечения двух прямых
double[] PointIntersection(double[] y1, double[] y2){
    double[] point = new double[2]; // Массив с координатами т. пересечения. point[0] -> x, point[1] -> y
    point[0] = (y2[1] - y1[1]) / (y1[0] - y2[0]);  // Находим т. по координате X.
    point[1] = y1[0] * point[0] + y1[1];           // Находим т. по координате Y.
    return point;
}

// Ф-ция вывода на консоль координат т. пересечения (point[0] -> x, point[1] -> y)
void PrintPoint(double[] point){
    Console.WriteLine($"Точка пересечения двух прямых: ({point[0]}, {point[1]}).");
}