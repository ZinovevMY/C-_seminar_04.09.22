//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите пятизначное число: ");
int[] numArray = new int[5];

int[] FillArray(int[] arr, int num)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        arr[i] = num%10;
        num = num/10;
    }
    return arr;
}

bool IsPolyndrom(int[] arr)
{
    int len = arr.Length - 1;
    if (arr[0] == arr[len] && arr[1] == arr[len - 1])
    {
        return true;
    }
    else
    {
        return false;
    }
}

numArray = FillArray(numArray, number);
if (IsPolyndrom(numArray))
{
    System.Console.WriteLine($"Введенное число {number} - полиндром.");
}
else
{
    System.Console.WriteLine($"Введенное число {number} - не полиндром.");
}
