/*

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/

Console.Clear();

Console.Write("Введите целое число: ");
int someNumber = int.Parse(Console.ReadLine());

if (someNumber % 2 == 0) {
    Console.WriteLine("Число " + someNumber + " является четным");
} 
else {
    Console.WriteLine("Число " + someNumber + " является нечетным");
}
