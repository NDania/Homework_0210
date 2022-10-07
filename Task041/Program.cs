// Пользователь вводит с клавиатуры М чисел. Посчитайте,
// сколько чисел больше 0 ввел пользователь.

Console.Clear();

void InputArray(int[]array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int ReleaseArray(int[]array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if (array[i] > 0)
        count ++;
    }   
    return count;
}

Console.WriteLine("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int []array = new int [n];
InputArray(array);
Console.WriteLine($"{string.Join(", ", array)}");
ReleaseArray(array);
Console.WriteLine($"Пользователь ввел количество чисел больше 0 = {ReleaseArray(array)}");












