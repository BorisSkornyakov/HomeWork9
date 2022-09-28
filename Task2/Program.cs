// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int DataEntry(string message)                           //Метод ввода данных
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}
int SumIntervalNumbers(int n, int m)
{
	int trend = 1;
	if (n<m)
		trend = -1;
	if (n == m)
		return m;
	return m + SumIntervalNumbers(n, m + trend);
}
int num1 = DataEntry("Введите первое число -> ");
int num2 = DataEntry("Введите второе число -> ");
System.Console.WriteLine(SumIntervalNumbers(num1, num2));