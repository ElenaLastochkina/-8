void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    { 
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = random.Next(1, 11);
    }
    }
}
void PrintArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
    for (int j = 0; j < columns; j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
    }
}

void Zadacha54()
{
// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 2 4 1
//9 5 3 2
//8 4 4 2
Random random = new Random();
int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns]; 
FillArray (array);
PrintArray(array);

for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
      for (int k = 0; k < columns - 1 - j; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k];
          array[i, k] = array[i, k + 1];
          array[i, k + 1] = temp;
        }
      }
      }
    }
    Console.WriteLine();
    PrintArray(array);
    
}   
Zadacha54();

void Zadacha56()
{
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка
Random random = new Random();
int rows = 4;
int columns = 3;
int[,] array = new int[rows, columns]; 
Console.WriteLine();
FillArray (array);
PrintArray(array);
int sumMin = 0;
int sumMinIndex = 0;
for (int j = 0; j < columns; j++)
{
  sumMin += array[0, j];
}
Console.WriteLine($"Сумма 1-й строки равна: {sumMin}");

for (int i = 0; i < rows; i++)
{
  int sum = 0;
  for (int j = 0; j < columns; j++)
  {
    sum += array[i, j];
  }
  Console.WriteLine($"Сумма {i+1}-й строки равна: {sum}");

  if (sum < sumMin)
  {
    sumMin = sum;
    sumMinIndex = i;
  }
}
Console.WriteLine($"Минимальная сумма находится в строке {sumMinIndex + 1} и равн {sumMin}");
}   
Zadacha56();

