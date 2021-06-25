using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(DateTime.Now);


            //3个await是线性执行，第一个await会返回并阻止接下来的await后面的方法。这应该不是我们想要的效果，毕竟后面的方法并不依赖第一个方法的执行。
            //new Action(async () =>
            //{
            //    await Delay3000Async();
            //    await Delay2000Async();
            //    await Delay1000Async();
            //})();

            //非并发
            Await3DelayAsync();

            //3个await后面的方法是并行执行的
            //var task3 = Delay3000Async();
            //var task2 = Delay2000Async();
            //var task1 = Delay1000Async();
            //new Action(async () =>
            //{
            //    await task3;
            //    await task2;
            //    await task1;
            //})();

            //后面的方法是并行执行的
            //Delay3000Async();
            //Delay2000Async();
            //Delay1000Async();

            //方法没阻塞 也没延迟
            //Delay3000Sync();
            //Delay2000Sync();
            //Delay1000Sync();
            Console.ReadLine();
        }

        static async Task Await3DelayAsync()
        {
            Console.WriteLine("2000 task end! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            await Delay3000Async();
            Console.WriteLine("2000 task end! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            await Delay2000Async();
            Console.WriteLine("2000 task end! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            await Delay1000Async();
            Console.WriteLine("2000 task end! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
        }

        static async Task Delay3000Async()
        {
            //Console.WriteLine("3000 task start! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            await Task.Delay(3000);
            //Console.WriteLine("3000 task end! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            Console.WriteLine(3000);
            Console.WriteLine(DateTime.Now);
        }

        static async Task Delay2000Async()
        {
            //Console.WriteLine("2000 task start! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            await Task.Delay(2000);
            //Console.WriteLine("2000 task end! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);
            Console.WriteLine(2000);
            Console.WriteLine(DateTime.Now);
        }

        static async Task Delay1000Async()
        {
            await Task.Delay(1000);
            Console.WriteLine(1000);
            Console.WriteLine(DateTime.Now);
        }

        static async Task Delay3000Sync()
        {
            //Thread.Sleep(3000);
            Task.Delay(3000);
            Console.WriteLine(3000);
            Console.WriteLine(DateTime.Now);
        }

        static async Task Delay2000Sync()
        {
            Task.Delay(2000);
            Console.WriteLine(2000);
            Console.WriteLine(DateTime.Now);
        }

        static async Task Delay1000Sync()
        {
            Task.Delay(1000);
            Console.WriteLine(1000);
            Console.WriteLine(DateTime.Now);
        }


    
    }
}
