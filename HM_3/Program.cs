Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

Console.WriteLine("Введите число начала диапазона: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число окончания диапазона: ");
int second = Convert.ToInt32(Console.ReadLine());
int maxnum = 0;
int minnum =0;

if ( first < second)   
{
    int[] numb = new int[size];

    int maxnum = numb[0];
    int minnum = numb[0];
    for (int i = 0; i < numb.Length; i++)
    {
        if (numbers[i] > maxnum)
        {
            maxnum = numb[i];
        }
        else if (numb[i] < minnum)
        {
            minnum = numb[i];
        }
    }
}
else 
{
    Console.WriteLine("введенные данные некорректны"); 
     break;
}

FillArrayRandom(numb);
PrintArray(numb);

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


   



Console.WriteLine("Минимальное число: "+ minnum);
Console.WriteLine("Минимальное число: " + maxnum);
Console.WriteLine("Разница между максимальным и минимальным числами: "+ (maxnum + minnum));



