/* Задача 27: Напишите программу, 
которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11, 82 -> 10, 9012 -> 12 */

Console.WriteLine("введите число");
int N = InputInt();
int InputInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if(!isParsed)
        {
            Console.WriteLine("Incorrect number");
            return -1;
        }
    else
        {
            return number;
        }
}
int result = GetSumOfDigits(N);
int GetSumOfDigits(int N)
{
    int sum = 0;
    while (N > 0)
    {
        int num = N % 10;
        N = N / 10;
        sum = sum + num;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе равна: {result}");