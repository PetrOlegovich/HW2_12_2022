// Задать одномерный массив из 123 случайных чисел. 
// Найти количество элементов массива , значения которых лежат в отрезке от [10, 99].

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
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 9 && array[i] < 100)
    {
        count++;
    }
}
Console.WriteLine("количество чисел в отрезке [10, 99] : "+ count);
