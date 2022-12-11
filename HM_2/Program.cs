
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Console.WriteLine("Введите число начала диапазона: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число окончания диапазона: ");
int  second = Convert.ToInt32(Console.ReadLine());
void FillArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(first, second);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
        Console.WriteLine();
}

if ( first < second) 
{
    FillArrayRandom(numbers); 
    PrintArray(numbers);
        
    int sumNumb = 0;
   
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sumNumb += numbers[i];
    }
    Console.Write ($"сумма чисел на нечетных позициях -> {sumNumb}");
} 

else Console.WriteLine("Данные числа некорректны");









