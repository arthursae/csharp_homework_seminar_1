/*

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.Clear();

Console.Write("Введите первое целое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int thirdNumber = int.Parse(Console.ReadLine());

int maxNumber = firstNumber;

int[] numbers = {firstNumber, secondNumber, thirdNumber};

int i = 0;

while (i < numbers.Length) {

    if (maxNumber < numbers[i]) {
        maxNumber = numbers[i];
    }

    i++;
}

Console.WriteLine("Максимальное из чисел: " + maxNumber);
