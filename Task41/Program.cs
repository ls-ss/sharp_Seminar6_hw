// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

// Объявление нового массива array типа int. Заполняется массив путем вызова ф-ции ReadNumberString.
int [] array = ReadNumberString();
// Объявление переменной qty. Содержит значение кол-ва чисел из массива array, которые больше 0.
int qty = QtyNum(array);
// Вывод значения на консоль.
PrintNum(qty);

// Ф-ция заполнения массива числами с клавиатуры.
int [] ReadNumberString()
{
    string values = "";
    Console.WriteLine("Введите целые числа через пробел, по окончанию введите Enter:");
    values = Console.ReadLine();

    string[] arrayVal = values.Split(" "); //Разделение строки values по разделителю: " " (пробел).

    //Объявляем массив numValues куда будем записывать переменные из arrayVal преобразованные в int.
    int [] numValues = new int[arrayVal.Length];
    
    // Преобразование строковых переменных в массиве arrayVal в тип int.
    for(int i = 0; i < arrayVal.Length; i++){
        numValues[i] = int.Parse(arrayVal[i]);
    }

    return numValues;
}

// Ф-ция подсчета в переданном массиве кол-ва чисел, которые больше 0.
int QtyNum(int [] array){
    int qty = 0;

    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0){
            qty++;
        }
    }

    return qty;
}

// Ф-ция вывода на консоль.
void PrintNum(int qty)
{
    Console.Write("Кол-во чисел больше нуля: ");
    Console.WriteLine(qty); 
}