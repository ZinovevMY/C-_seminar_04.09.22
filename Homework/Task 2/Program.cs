//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите число: ");

System.Console.WriteLine($"Таблицы кубов для числа {number}: ");
for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine(i*i*i);
}
