// Создадим массив через random
Random rnd = new Random();
int minR = 2; int maxR = 10;
int rows = rnd.Next(minR,maxR); int columns = rnd.Next(minR,maxR); // строки и колонки массива 
int[,] numbers = new int[rows,columns]; // массив
int minRnd = 1; int maxRnd = 10; // для random
//
FillRandomArray(numbers);
Print2DArray(numbers);

// Функции
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