// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да 

Console.Write("ВВедите целое пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 99999)
{
    int numnew = 0;
    int num1 = num;
 
    while (num1 > 0)
    {
        int ost = num1 % 10;
        numnew = (numnew * 10) + ost;
        num1 = num1 / 10;
    }
    // Console.WriteLine($"Новое число: {numnew}");

    if (numnew == num)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }

}
else
{
    Console.WriteLine("Ошибка ввода");
}


