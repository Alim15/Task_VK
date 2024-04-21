using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class ProcessManager
    {
    public void DisplayAllProcesses()
    {
        Console.WriteLine("Список запущенных процессов:");
        foreach (Process process in Process.GetProcesses())
        {
            Console.WriteLine($"ID: {process.Id} \t Имя: {process.ProcessName}");
        }
    }

     public void ExecuteProcessAction(int processId, int action)
    {
        try
        {
            Process process = Process.GetProcessById(processId);

            switch (action)
            {
                case 1:
                    if (process.HasExited)
                    {
                        Console.WriteLine("Процесс уже завершен, нельзя начать.");
                    }
                    else
                    {
                        process.Start();
                        Console.WriteLine("Процесс успешно начат.");
                    }
                    break;
                case 2:
                    process.Kill();
                    Console.WriteLine("Процесс успешно завершен.");
                    break;
                case 3:
                    process.WaitForInputIdle();
                    Console.WriteLine("Процесс успешно продолжен.");
                    break;
                default:
                    Console.WriteLine("Неверное действие.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка в формате введенных данных.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Процесс с указанным ID не найден.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
    }
}