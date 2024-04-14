// Задаем размер массива
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine()!);

// Создаем массив строк указанного размера
string[] array = new string[size];

// Заполняем массив
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите элемент массива {i}:");
    array[i] = Console.ReadLine()!;
}

// Выводим массив на экран
Console.Write("Вы ввели следующие элементы: ");
for (int i = 0; i < size; i++)
{
    Console.Write(array[i]);
    if (i < size - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

// Подсчитываем количество строк, длина которых меньше или равна 3 символам
int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}