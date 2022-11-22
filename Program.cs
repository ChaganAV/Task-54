// Создадим массив через random
Random rnd = new Random();
int minR = 2; int maxR = 10;
int rows = rnd.Next(minR,maxR); int columns = rnd.Next(minR,maxR); // строки и колонки массива 
int[,] numbers = new int[rows,columns]; // массив
int minRnd = 1; int maxRnd = 10; // для random
int[] test = {1,4,3,6};
//
FillRandomArray(numbers);
Print2DArray(numbers);
Sort2DArray(numbers);
Console.WriteLine();
Print2DArray(numbers);
//SortArrayTest(test);
//PrintArray(test);

// Функции
void SortArrayTest(int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = i+1; j < array.Length; j++)
        {
            Console.WriteLine($"array[i] < array[j] {array[i]} < {array[j]}");
            if(array[i] < array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        Console.WriteLine($"Проход {i}");
    }
}
void SortArray(int row, int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = i+1; j < array.GetLength(1); j++)
        {
            if(array[row,i] < array[row,j])
            {
                temp = array[row,i];
                array[row,i] = array[row,j];
                array[row,j] = temp;
            }
            
        }
    }
}
void Sort2DArray(int[,] array2D)
{
    int temp = 0;
    for(int row = 0; row < array2D.GetLength(0); row++)
    {
        SortArray(row, array2D);
    }
}
void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = rnd.Next(minRnd,maxRnd);
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}