using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example Changes
            ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            Thread.Sleep(100);
        }

        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, " +
                $"Thread Pool:{thread.IsThreadPoolThread}, " +
                $"Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
