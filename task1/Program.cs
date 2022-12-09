/*Задача 25: Напишите программу, 
которая принимает на вход два числа (A и B) 
и метод который возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль. 
Не использовать Math.Pow()*/

Console.WriteLine("введите число A");
int A = InputInt();
Console.WriteLine("введите число B");
int B = InputInt();
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

int result = GetExponentiation(A, B);
int GetExponentiation(int A, int B)
{
    int degree = A;
    for (int i = 1; i < B; i++)
    {
        
        degree = degree * A;
    }
    return degree;
}
Console.WriteLine($"A в степени B равно: {result}");