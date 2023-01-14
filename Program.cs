//Задача 1.

System.Console.Write("Введите количество элементов массива:");
int elemCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elemCount];
for(int i=0; i<array.Length; i++)
{
    System.Console.Write($"Введите массив с индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for(int i=0; i<array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
    if(array[i]>0) count++;
}
System.Console.WriteLine();
System.Console.Write($"Количество элементов больше нуля: {count}");

//Задача 2.

System.Console.WriteLine("Введите значение b1:");
double b1 = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine("Введите значение k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;
System.Console.WriteLine($"({x},{y})");