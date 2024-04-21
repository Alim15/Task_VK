
// using System;
// using System.Diagnostics;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Список запущенных процессов:");
//             foreach (Process process in Process.GetProcesses())
//             {
//                 Console.WriteLine($"ID: {process.Id} \t Имя: {process.ProcessName}");
//             }

//             Console.Write("\nВведите ID процесса для действия (0 - выход): ");
//             int processId = int.Parse(Console.ReadLine());

//             if (processId != 0)
//             {
//                 Process process = Process.GetProcessById(processId);
//                 Console.WriteLine($"Выбранный процесс: ID - {process.Id}, Имя - {process.ProcessName}");

//                 Console.Write("Выберите действие (1 - Начать, 2 - Завершить, 3 - Продолжить): ");
//                 int action = int.Parse(Console.ReadLine());

//                 switch (action)
//                 {
//                     case 1:
//                         if (process.HasExited)
//                         {
//                             Console.WriteLine("Процесс уже завершен, нельзя начать.");
//                         }
//                         else
//                         {
//                             process.Start();
//                             Console.WriteLine("Процесс успешно начат.");
//                         }
//                         break;
//                     case 2:
//                         process.Kill();
//                         Console.WriteLine("Процесс успешно завершен.");
//                         break;
//                     case 3:
//                         process.WaitForInputIdle();
//                         Console.WriteLine("Процесс успешно продолжен.");
//                         break;
//                     default:
//                         Console.WriteLine("Неверное действие.");
//                         break;
//                 }
//             }
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Ошибка в формате введенных данных.");
//         }
//         catch (ArgumentException)
//         {
//             Console.WriteLine("Процесс с указанным ID не найден.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Произошла ошибка: {ex.Message}");
//         }
//     }
// }




using System;
using System.Diagnostics;


class Main
{
    public static void Main()
    {
        ProcessManager processManager = new ProcessManager();

        processManager.DisplayAllProcesses();

        Console.Write("\n Введите ID процесса для действия (0 - выход): ");
        int processId = int.Parse(Console.ReadLine());

        if (processId != 0)
        {
            Console.Write("Выберите действие (1 - Начать, 2 - Завершить, 3 - Продолжить): ");
            int action = int.Parse(Console.ReadLine());

            processManager.ExecuteProcessAction(processId, action);
        }
    }
}

