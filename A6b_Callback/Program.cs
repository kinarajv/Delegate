using System;

namespace CallbackExample
{
    public delegate void TaskCompletedDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            TaskCompletedDelegate callback = OnTaskCompleted;
            PerformTask(callback);
        }

        static void PerformTask(TaskCompletedDelegate callback)
        {
            Console.WriteLine("Menjalankan tugas...");
            callback();
        }

        static void OnTaskCompleted()
        {
            Console.WriteLine("Tugas selesai!");
        }
    }
}