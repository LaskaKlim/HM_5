Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrnumb = new int[size];
Console.WriteLine("Введите число начала диапазона: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число окончания диапазона: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first< second)
{
    FillArrayRandom(arrnumb);
    int numMax = arrnumb[0];
    int numMin = arrnumb[0];

    for (int i = 0; i < arrnumb.Length; i++)
    {
        if (arrnumb[i] > numMax)
            {
                numMax = arrnumb[i];
            }
        else if (arrnumb[i] < numMin)
            {
                numMin = arrnumb[i];
            }

    }
    PrintArray(arrnumb);  

    Console.WriteLine($"Минимальное число: {numMin}");
    Console.WriteLine($"Максимальное число:  {numMax}");
    Console.WriteLine($"Разница между максимальным и минимальным числами: {numMax - numMin}");

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
}
else Console.WriteLine ("incorrect");