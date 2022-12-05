/*

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.Clear();

Console.Write("Введите целое число: ");
int endNumber = int.Parse(Console.ReadLine());
int startNumber = 1;

int[] GetSequenceOfEvenNumbers(int number) {

    if (number > 0) {

        int i = 2;
        int j = 0;

        int lengthOfArray = number / 2;
        int[] evenNumbersArray = new int[lengthOfArray];

        while (i <= number) {

            evenNumbersArray[j] = i;
                i+=2;
                j++;

        }

        return evenNumbersArray;

    } 
    
    else {

        int i = 0;
        int j = 0;

        int lengthOfArray = (Math.Abs(number) + startNumber + 1) / 2; // +1 including zero

        int[] evenNumbersArray = new int[lengthOfArray];
        //Console.WriteLine($"Размер массива: {evenNumbersArray.Length}");

        while (i >= number) {

            evenNumbersArray[j] = i;
                i-=2;
                j++;

        }

        return evenNumbersArray;

    }

}

int[] evenNumbers = GetSequenceOfEvenNumbers(endNumber);

int index = 0;

//Console.WriteLine("Размер массива: " + evenNumbers.Length);
Console.Write("Чётные числа: ");

while (index < evenNumbers.Length) {
    
    Console.Write($"{evenNumbers[index]}, ");
    index++;
}
