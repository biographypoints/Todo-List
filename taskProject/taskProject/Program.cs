using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("--- Advanced To-Do App ---\n");

        int task = GetTaskCount();
        string[] tasks = new string[task];

        for (int i = 0; i < tasks.Length; i++)
        {
            {
                tasks[i] = GetTask(i + 1);

            }

        }
        tasks = RemoveEmptyTasks(tasks);

        PrintTasks(tasks);


        CheckPriority(tasks);

    }

    static int GetTaskCount()
    {

        Console.Write("Please Enter Number You are Required : ");
        int number = Convert.ToInt32(Console.ReadLine());

        return number;

    }
    static string GetTask(int number)
    {

        Console.Write($"Please Enter the Task {number} :");
        string task = Console.ReadLine();

        return task;



    }

    static string[] RemoveEmptyTasks(string[] tasks)
    {
        string[] filtered = Array.FindAll(tasks, t => !string.IsNullOrWhiteSpace(t));
        return filtered;
    }

    static void PrintTasks(string[] tasks)
    {
        Console.WriteLine("\n--- Your To-Do List ---");
        foreach (string task in tasks)
        {
            Console.WriteLine("- " + task);
        }
    }

    static void CheckPriority(string[] tasks)
    {
        Console.WriteLine("\nHigh Priority Tasks:");
        foreach (string task in tasks)
        {
            if (task.ToLower().Contains("urgent") || task.ToLower().Contains("important"))
            {
                Console.WriteLine("- " + task);
            }
        }
    }
}