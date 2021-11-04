// Задача
// Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1.1.	возрастания
// 1.2.	элементы, больше 8
// 1.3.	знакочередования


void FillArrayA(int minValue, int maxValue, int[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от minValue до maxValue
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
int[] A = new int[20];
Console.WriteLine("Случайный массив:");
FillArrayA(-100, 100, A);

//Определяем длину массива B для подзадачи 1.1:
int countLengthB = 1;
int max = A[0];
for (int index = 1; index < A.Length; index++)
{
    if (A[index] > max)
    {
        max = A[index];
        countLengthB++;
    }
}
int[] B = new int[countLengthB]; //Заполняем массив B для подзадачи 1.1.
Console.WriteLine();
Console.WriteLine("Массив B, созданный на основе массива A путем отбрасывания элементов, нарушающих порядок возрастания:");
int indexB = 1;
max = A[0];
B[0] = A[0];
for (int index = 1; index < A.Length; index++)
{
    if (A[index] > max)
    {
        max = A[index];
        B[indexB] = A[index];
        indexB++;
    }
}
for (indexB = 0; indexB < B.Length; indexB++) //Печатаем массив B, по условию подзадачи 1.2.
{
    Console.Write(B[indexB] + " ");
}

//Определяем длину массива B для подзадачи 1.2:
int countLengthC = 0;
for (int index = 0; index < A.Length; index++)
{
    if (A[index] <= 8)
    {
        countLengthC++;
    }
}
int[] С = new int[countLengthC]; //Заполняем массив B для подзадачи 1.2.
Console.WriteLine();
Console.WriteLine("Массив B, созданный на основе массива A путем отбрасывания элементов, больших восьми:");
int indexC = 0;
for (int index = 0; index < A.Length; index++)
{
    if (A[index] <= 8)
    {
        С[indexC] = A[index];
        indexC++;
    }
}
for (indexC = 0; indexC < С.Length; indexC++) //Печатаем массив B, по условию подзадачи 1.2.
{
    Console.Write(С[indexC] + " ");
}

bool Znak(int j)
{
    bool m = false;
    if (j >= 0)
    {
        m = true;
    }
    return m;
}
//Определяем длину массива B для подзадачи 1.3:
int countLengthD = 1;
Znak(A[0]);
for (int index = 1; index < A.Length; index++)
{
    if (Znak(A[index]) != Znak(A[index - 1]))
    {
        countLengthD++;
    }
}

int[] D = new int[countLengthD]; //Заполняем массив B для подзадачи 1.3.
Console.WriteLine();
Console.WriteLine("Массив B, созданный на основе массива A путем отбрасывания элементов, нарушающих знакочередование:");
int indexD = 1;
D[0] = A[0];
for (int index = 1; index < A.Length; index++)
{
    if (Znak(A[index]) != Znak(A[index - 1]))
    {
        D[indexD] = A[index];
        indexD++;
    }
}
for (indexD = 0; indexD < D.Length; indexD++) //Печатаем массив B, по условию подзадачи 1.3.
{
    Console.Write(D[indexD] + " ");
}