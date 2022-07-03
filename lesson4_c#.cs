/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

double summa(double a)
{
    string b = Convert.ToString(a);
    double e = 0;
    for (int i = 0; i < b.Length; i++)
    {
        e = e + Convert.ToDouble(b[i].ToString()); //конвертация char в string, а потом в double, чтобы бралось число, а не код числа
        //e = e + (Char.GetNumericValue(b, i)); //второй вариант, даёт сразу число
    }
    return (e);
}
Console.WriteLine("Введи число: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Сумма чисел: " + summa(num));





/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void massiv()
{
    Random rand = new Random();
    int a = rand.Next(1, 9);
    int[] nums = new int[a]; //создание массива рандомной длины 1-8

    for (int i = 0; i < a; i++) nums[i] = rand.Next(1, 100); //заполнение массива рандомными числами 1-99

    Console.Write("Массив длинной " + a + ": ");
    for (int j = 0; j < nums.Length; j++) //вывод по очереди в консоль
    {
        if (j == nums.Length - 1) Console.Write(nums[j] + "."); //чтобы последний элемент завершался точкой. для красоты
        else Console.Write(nums[j] + ", ");
    }
}
massiv();
