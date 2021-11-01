void FillArray(int[] A) // Метод, заполняющий массив случайными двузначными целыми числами от 10 до 100
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(10, 100);
        Console.WriteLine(A[index]);
        index++;

    }
}
int[] A = new int[20];
FillArray(A);
int index = 0;
while (index < a.Length)
{

    if (A[index] % 2 == 0 )

}