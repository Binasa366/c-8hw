//Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int size = RedInt("Задайте размер массива: ");
int[,] array = new int[size, size];
int value = 1;
int i = 0;
int j = 0;

while(value <= size * size)
{
    array[i, j] = value++;
    if(i <= j + 1 && i + j < size - 1) 
        j++;
    else if(i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
}

for(int k = 0; k < array.GetLength(0); k++)
{
    for(int l = 0; l < array.GetLength(1); l++)
    {
        Console.Write($"{array[k, l],3}\t ");
    }
    Console.WriteLine();
}

int RedInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}