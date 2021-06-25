using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program2
    {
        static void Main2(string[] args)
        {

            //Thread方法每次的Thread Id都是不同的，而Task方法的Thread Id是重复出现的。线程的创建和销毁是一个开销比较大的操作，Task每次执行将不会立即创建一个新线程，而是到CLR线程池查看是 否有空闲的线程，有的话就取一个线程处理这个请求，处理完请求后再把线程放回线程池，这个线程也不会立即撤销，而是设置为空闲状态，可供线程池再次调度， 从而减少开销。
            Console.WriteLine("Task   With Thread  Start !");
            for (int i = 0; i <= 5; i++)
            {
                Thread t = new Thread(Dotaskfunction);
                t.Start();
            }
            Console.WriteLine("Task   With Thread End !");

            Console.WriteLine("Task   With Task   Start !");
            for (int i = 0; i <= 5; i++)
            {
                Task.Run(() => { Dotaskfunction(); });
            }
            Console.WriteLine("Task   With Task End !");
            Console.ReadLine();

            Console.WriteLine("Task Start !");
            DOTaskWithAsync();
            Console.WriteLine("Task End !");
            Console.ReadLine();
            //假如Dotaskfunction()每一个循环需要一秒钟，而主线程并没有进行等待，那么主线程运行到Console.ReadLine();按下了回车 ，那么后台线程是还没运行完成之后就结束的，所以应该将代码稍微修改一下
            //task.Wait();
        }

        public static void Dotaskfunction()
        {
            Console.WriteLine("task  has been done! ThreadID: {0},IsBackGround:{1} ", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.IsBackground);

        }
        //  Async/Await
        //其实也没有什么神秘的，个人觉得就是实现异步主要靠await ，假如一个声明为async的方法，没有使用await关键字，则这个方法在执行的时候就被当作同步方法，这时编译器也会抛出警告提示async修饰的方法中没有使用await，将被作为同步方法使用。
        
        public static async void DOTaskWithAsync()
        {

            Console.WriteLine("Await Taskfunction Start");
            await Task.Run(() =>
            {
                DotaskAsyncFunction();
            });


        }
        public static void DotaskAsyncFunction()
        {
            for (int i = 0; i <= 5; i++)
            {

                Console.WriteLine("task {0}  has been done!", i);
            }

        }
    }
}
