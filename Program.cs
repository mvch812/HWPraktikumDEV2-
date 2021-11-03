// Задача
// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// •	возрастания
// •	элементы, больше 8
// •	знакочередования


void FillArrayA(int minValue, int maxValue, int[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от 10 до 100
{
    int length = A.Length;
    int index = 0;
    int summ = 0;
    int average = 0;

    while (index < length)
    {
        A[index] = new Random().Next(minValue, maxValue);
        Console.Write(A[index] + " ");
        summ = summ + A[index];
        index++;

    }
    average = summ / length;

}
int[] A = new int[30];
Console.WriteLine("Случайный массив:");
FillArrayA(-100, 100, A);

//int[] A = { 12, 11, 17, 25, 27, 21, 39, 55, 32, 45, 88, 99, 23, 29, 66 };

int averageArray(int[] A) //Метод, определяющий ср. арифметическое элементов массива
{
    int length = A.Length;
    int index = 0;
    int summ = 0;
    int average = 0;

    while (index < length)
    {
        summ = summ + A[index];
        index++;

    }
    average = summ / length;
    return average;
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое массива A: " + averageArray(A));

//Определяем длину массива B:
int index = 0;
int countLengthB = 0;
int max = 0;
while (index < A.Length)
{
    if (A[index] % 2 != 0)
    {
        if (A[index] > max)
        {
            max = A[index];
            if (A[index] <= averageArray(A))
            {
                countLengthB++;
                // Console.Write(A[index] + " ");
            }
        }
    }

    index++;
}
// Console.WriteLine();
// Console.WriteLine(countLengthB);

if (countLengthB == 0)
{
    Console.WriteLine("Из массива А невозможно создать массив B, выполняя все условия задачи!");
}
else
{
    int[] B = new int[countLengthB]; //Заполняем массив B
    max = 0;
    int indexB = 0;
    index = 0;

    while (index < A.Length)
    {
        if (A[index] % 2 != 0)
        {
            if (A[index] > max)
            {
                max = A[index];
                if (A[index] <= averageArray(A))
                {
                    B[indexB] = A[index];
                    indexB++;
                }
            }
        }

        index++;
    }
    Console.WriteLine("Массив B:"); // Печатаем массив B
    index = 0;
    while (index < B.Length)
    {
        Console.Write(B[index] + " ");
        index++;
    }
}

