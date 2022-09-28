// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

int DataEntry(string message)                           //Метод ввода данных
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int n, int m)
{
	if (n == 0) return m + 1;
	if (n != 0 && m == 0) return Ackermann(n - 1, 1);
	if (n > 0 && m > 0) return Ackermann(n - 1, Ackermann(n, m - 1));
	return Ackermann(n, m);
}

int num1 = DataEntry("Введите первое число -> ");
int num2 = DataEntry("Введите второе число -> ");
System.Console.WriteLine(Ackermann(num1, num2));