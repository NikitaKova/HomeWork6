// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputNum(int len)
{
    int [] numbers = new int [5];
Console.WriteLine("Введите первое число: ");
numbers[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
numbers[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
numbers[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвертое число: ");
numbers[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятое число: ");
numbers[4] = Convert.ToInt32(Console.ReadLine());
return numbers;
}

int SumNum(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] num = InputNum(5);
int result = SumNum(num);
System.Console.WriteLine($"Сколько чисел больше 0: {result}");
