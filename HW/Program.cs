// задать массив заполненый случайными положительными трехзначными числами 
// написать программу которая покажет количество всех четных чисел в массиве.

int [] RandomMassiv(int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}


Console.WriteLine("Введите длинну массива : ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = RandomMassiv(num);
Console.WriteLine("Ваш массив  : \n" + "["+string.Join(",", array)+"]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0 )
    {
        count++;
    }    
}
Console.WriteLine("количество четных элементов массива : \n: " + count);