// задать одномерный массив заполненый случайными числами.
// Найти сумму элементов , стоящих на нечётных позициях.

int [] RandomMassiv(int size)
{
    int[] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 200);        
    }
    return arr;
}
Console.Write("Введите длинну массива : ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int [] array = RandomMassiv(num);
Console.WriteLine($"Ваш массив : ["+string.Join(",", array)+"]");
int sum = 0;
for (int i = 1; i < array.Length; i=i+2)
{
    sum = sum + array[i];
}
Console.Write($"сумма элементов нечетных индексов : "+sum);