// задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементом массива.


int Gen()
{
    int a = new Random().Next(3, 15);
    Console.Write(a + " раз сгенерировать число\n");
    return a;
}
int size = Gen();
double [] RandomMassiv(int size)
{
    double[] arr = new double [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round((Convert.ToDouble(new Random().Next(-100, 200)) + new Random().NextDouble()), 2);        
    }
    return arr;
}
double[]array = RandomMassiv(size);

double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if(min>array[i]) min = array[i];
    else if (max<array[i]) max = array[i];    
}


Console.WriteLine("["+string.Join(", ", array)+"]");

Console.WriteLine($" max = {max}; min = {min}; \n разница : {Math.Round((max-min),2)}");

// я не понял ка решать эту задачу , мне помогал студент Дмитрий. с его помощью решил. теперь понимаю больше.
