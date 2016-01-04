using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.TUTS_TaskParallelLibrary
{
    public static class TaskParallelLibrary
    {
        public static void TaskParallelLibraryCaller()
        {
            //Rozw. 1 = Rozw. 2
            //Pierwsze rozwiazanie
            //var t1 = new Task(() => DoSomethingImportantThing(1,2000));
            //t1.Start();
            //var t2 = new Task(() => DoSomethingImportantThing(2, 3000));
            //t2.Start();
            //var t3 = new Task(() => DoSomethingImportantThing(3, 1000));
            //t3.Start();

            //Drugie rozwiazanie
            //var t1 = Task.Factory.StartNew(() => DoSomethingImportantThing(1, 2000));
            //var t2 = Task.Factory.StartNew(() => DoSomethingImportantThing(2, 3000));
            //var t3 = Task.Factory.StartNew(() => DoSomethingImportantThing(3, 1000));

            //Continue
            //var t1 = Task.Factory.StartNew(() => DoSomethingImportantThing(1, 2000)).ContinueWith((prevTask) => DoSomethingotherVeryImportantWork(1, 1000)); //Natychmiast uruchom, po zakoñczeniu uruchom "MoreWork"
            //var t2 = Task.Factory.StartNew(() => DoSomethingImportantThing(2, 3000));
            //var t3 = Task.Factory.StartNew(() => DoSomethingImportantThing(3, 1000));

            //Nie pozwalamy na zakonczenie dzialania aplikacji, zanim nie zakoncza sie wszystkie Taski
            //var t1 = Task.Factory.StartNew(() => DoSomethingImportantThing(1, 2000));
            //var t2 = Task.Factory.StartNew(() => DoSomethingImportantThing(2, 3000));
            //var t3 = Task.Factory.StartNew(() => DoSomethingImportantThing(3, 1000));

            //var taskList = new List<Task> { t1, t2, t3 };
            //Task.WaitAll(taskList.ToArray()); //Dopiero po zakonczeniu wszystkich Taskow, reszta bedzie realizowane

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Doing some other work");
            //    Thread.Sleep(250);
            //    Console.WriteLine("i={0}",i);
            //}

            //Parallel.ForEach
            //Blokuje wszystko inne
            var intList = new List<int> { 1, 2, 32, 434, 2, 46, 456, 75, 45, 66, 32, 64, 24, 5, 3, 3, 27 };
            Parallel.ForEach(intList,(i)=>{Console.WriteLine(i);});

            Parallel.For(0,100, (i) => { Console.WriteLine(i); });

            //Anulowanie jesli cos wydarzy, poinformwac wszystkich dookolo

            var source = new CancellationTokenSource();

            try
	        {
                var t1 = Task.Factory.StartNew(() => DoSomethingImportantThing(1, 1200, source.Token)).ContinueWith((prevTask) => DoSomethingotherVeryImportantWork(1, 1000, source.Token));
                source.Cancel(); //Wszystkie watki
	        }
	        catch (Exception ex)
	        {
		        Console.WriteLine(ex.GetType());
	        }

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        public static void DoSomethingImportantThing(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("CancellationRequested");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("Task {0} is beginning.", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed.", id);
        }

        public static void DoSomethingotherVeryImportantWork(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("CancellationRequested");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("Task {0} is beginning more work.", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed more work.", id);
        }
    }
}