// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int DataEntry(string message)                           //Метод ввода данных
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}
string OutputStringNumbers(int n)						
{
	if(n == 1)
		return n.ToString();
	return n.ToString() + ", " + OutputStringNumbers(n - 1);
}
int number = DataEntry("Введите число -> ");
System.Console.WriteLine(OutputStringNumbers(number));