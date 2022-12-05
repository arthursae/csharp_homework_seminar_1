/*

Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/

Console.Clear();

Console.Write("Введите первое целое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = int.Parse(Console.ReadLine());

void OutputMinMax(int min, int max) {

    if (min < max) {
        Console.WriteLine("Минимальное число равно " + min);
        Console.WriteLine("Максимальное число равно " + max);
    }

    else if (min == max)
    {
        Console.WriteLine("Оба числа равны");
    }

    else
    {
        Console.WriteLine("Минимальное число равно " + max);
        Console.WriteLine("Максимальное число равно " + min);
    }

}

OutputMinMax(firstNumber, secondNumber);
