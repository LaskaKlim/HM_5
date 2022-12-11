Console.WriteLine("Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
int count = 0;

void FillArrayRandomNumbers(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
FillArrayRandomNumbers(numbers); 
PrintArray(numbers); 

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}

Console.WriteLine($"Количество чётных чисел в массиве -> {count} ");


