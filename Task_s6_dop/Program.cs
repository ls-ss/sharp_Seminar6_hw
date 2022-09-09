// Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.
// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();

int[] array = InputArray(); // Задаем массив
PrintArray(array);  //Выводим оригинальный массив
Console.Write(" <- ");
PrintArray(LeftArray(array));  //Выводим массив смещённый влево
Console.WriteLine(" - сдвиг влево");

PrintArray(array);  //Выводим оригинальный массив
Console.Write(" -> ");
PrintArray(RightArray(array));  //Выводим массив смещённый вправо
Console.WriteLine(" - сдвиг вправо");

// Ф-ция генерации массива случайными значениями из n элементов.
int[] InputArray(){
    int NumElem = new Random().Next(2, 7); // Задаем случайным образом длину массива (2...6)
    int [] array = new int[NumElem]; // Объявляем о создании массива на 'NumElem' элементов типа int
    // Заполняем массив целыми числами
    for (int i = 0; i < NumElem; i++){
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

// Ф-ция вывода массива на консоль
void PrintArray(int[] array){
    Console.Write("[");
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}");
        if(i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

// Ф-ция сдвига массива влево
int[] LeftArray(int[] array){
    int[] tempArray = new int[array.Length];
    tempArray[array.Length - 1] = array[0];

    for (int i = 0; i < array.Length - 1; i++){
        tempArray[i] = array[i + 1];
    }

    return tempArray;
}

// Ф-ция сдвига массива вправо
int[] RightArray(int[] array){
    int[] tempArray = new int[array.Length];
    tempArray[0] = array[array.Length - 1];

    for (int i = array.Length - 1; i > 0; i--){
        tempArray[i] = array[i - 1];
    }

    return tempArray;
}
