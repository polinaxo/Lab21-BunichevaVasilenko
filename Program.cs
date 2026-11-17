using System.Collections.Generic;


// List<string> tasks = new List<string> { "Код", "Тест", "Код" };
// tasks.Add("Отчёт");
// tasks.Insert(1, "План");
// Console.WriteLine(tasks.Count);
// Console.WriteLine(tasks[0]);
// Console.WriteLine(tasks[tasks.Count - 1]);



// List<string> editableTasks = new List<string> { "Черновик" };
// editableTasks[0] = "Готово";
// Console.WriteLine(editableTasks[0]);
// Console.WriteLine(editableTasks.Count);


// List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };
// bool removed = removedTasks.Remove("Код");
// removedTasks.RemoveAt(1);
// PrintTasks(removedTasks);

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

List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" };



int index = searchableTasks.IndexOf("План");

if (index >= 0)
{
    Console.WriteLine($"Первый индекс: {index}");
}
else
{
    Console.WriteLine("Задача не найдена");
}