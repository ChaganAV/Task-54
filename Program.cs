// Создадим массив через random
Random rnd = new Random();
int minR = 2; int maxR = 10;
int rows = rnd.Next(minR,maxR); int columns = rnd.Next(minR,maxR); // строки и колонки массива 
int[,] numbers = new int[rows,columns]; // массив
int minRnd = 1; int maxRnd = 10; // для random
//
FillRandomArray(numbers);
Print2DArray(numbers);
Sort2DArray(numbers);
Console.WriteLine();
Print2DArray(numbers);

// Функции
void SortArray(int[] array)
{
    int max = array[0];
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = 1; j < array.Length; j++)
        {
            if(array[i] < array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            
        }
    }
}
void Sort2DArray(int[,] array)
{
    int temp = 0;
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            if(col < array.GetLength(1)-1)
            {
                temp = array[row,col];
                if(array[row,col] < array[row,col+1])
                {
                    array[row,col] = array[row,col+1];
                    array[row,col+1] = temp;
                }
                
            }
            
        }
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