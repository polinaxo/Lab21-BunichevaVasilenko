using System.Collections.Generic;



bool InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        return false;
    }

    tasks.Insert(index, title);
    return true;
}


void PrintTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]}");
    }
}


bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }
    tasks.RemoveAt(index);
    return true;
}


// Console.Write("Сколько задач добавить сначала: ");
// int count = Convert.ToInt32(Console.ReadLine());

// List<string> tasks = new List<string>();

// for (int i = 0; i < count; i++)
// {
//     Console.Write($"Задача {i + 1}: ");
//     string title = Console.ReadLine() ?? "";
//     tasks.Add(title);
// }

// // 1. Исходный список
// PrintTasks(tasks);


// // 2. Добавление новой задачи
// Console.Write("Введите название новой задачи: ");
// string z = Console.ReadLine() ?? "";
// tasks.Add(z);
// Console.WriteLine("Задача добавлена");

// // 3. Вставка по индексу
// Console.Write("Введите название задачи для вставки: ");
// string za = Console.ReadLine() ?? "";
// Console.Write("Введите индекс для вставки: ");
// int index = Convert.ToInt32(Console.ReadLine());
// if (InsertTaskSafe(tasks, index, za)) {
//     Console.WriteLine("Задача вставлена");
// }
// else
// {
//     Console.WriteLine("Недопустимый индекс вставки");
// }

// //4. Удаление по значению
// Console.Write("Введите задачи для удаления: ");
// string res = Console.ReadLine() ?? "";
// if (tasks.Remove(res))
// {
//     Console.WriteLine("Первое совпадение удалено");
// }
// else
// {
//     Console.WriteLine("Задача не найдена");
// }

// // 5. Удаление по индексу
// Console.Write("Введите индекс задачи для удаления: ");
// int iindex = Convert.ToInt32(Console.ReadLine());
// if (RemoveTaskAtSafe(tasks, iindex)) {
//     Console.WriteLine("Задача по индексу удалена");
// }
// else
// {
//     Console.WriteLine("Недопустимый индекс удаления");
// }

// // 6. Поиск
// Console.Write("Введите название задачи для поиска: ");
// string search = Console.ReadLine() ?? "";
// int foundIndex = tasks.IndexOf(search);
// if (foundIndex >= 0)
// {
//     Console.WriteLine(foundIndex);
// }
// else
// {
//     Console.WriteLine("Задача не найдена");
// }

// // 7. Итог
// Console.WriteLine();
// Console.WriteLine(">>> Итоговый список дел <<<");
// Console.WriteLine();
// Console.WriteLine($"Количество задач: {tasks.Count}");
// PrintTasks(tasks);

// Вариант 1. Количество совпадений


int CountTask(List<string> tasks, string title)
{
    int count = 0;
    for (int i = 0; i < tasks.Count; i++)
    {
        if (tasks[i] == title)
        {
            count++;
        }
    }
    return count;
}

//Вариант 2. Удаление всех совпадений
int RemoveAllTasks(List<string> tasks, string title)
{
    int coun = 0;
    for (int i = tasks.Count - 1; i >= 0; i--)
    {
        if (tasks[i] == title)
        {
            tasks.RemoveAt(i);
            coun++;
        }
    }
    return coun;
}

