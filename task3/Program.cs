/*Задача 29: Напишите программу, которая 
задаёт массив из 8 элементов и 
выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите количество элементов массива");
int elements = InputInt();
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
int[] result = FillingArray();
int[] FillingArray()
{
    int [] numbers = new int[elements];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = new Random().Next(0, 11);        
    }
    return numbers;
}
Console.Write("[{0}]", string.Join(", ", result));
