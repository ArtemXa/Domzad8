// Zadacha54();

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int colums = random.Next(4, 8);

    int[,] numbers = new int[rows, colums];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    OrderArrayLines(numbers);
    PrintArray(numbers);
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);



    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            numbers[i, j] = random.Next(-10, 11);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(numbers[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
void OrderArrayLines(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = temp;
                }
            }
        }
    }
}

//Zadacha56();
void Zadacha56()
{
    Random random = new Random();
    int rows = random.Next(4, 5);
    int colums = random.Next(6, 10);

    int[,] numbers = new int[rows, colums];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    int minSumLine = 0;
    int sumLine = SumLineElements(numbers, 0);
    for (int i = 1; i < numbers.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(numbers, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
    int SumLineElements(int[,] numbers, int i)
    {
        int sumLine = numbers[i, 0];
        for (int j = 1; j < numbers.GetLength(1); j++)
        {
            sumLine += numbers[i, j];
        }
        return sumLine;
    }
}

Zadacha58();
void Zadacha58()
{
    int n = 4;
    int[,] numbers = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= numbers.GetLength(0) * numbers.GetLength(1))
    {
        numbers[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < numbers.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= numbers.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > numbers.GetLength(1) - 1)
            j--;
        else
            i--;
    }

    WriteArray(numbers);

}
void WriteArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] / 10 <= 0)
                Console.Write($" {numbers[i, j]} ");

            else Console.Write($"{numbers[i, j]} ");
        }
        Console.WriteLine();
    }
}
