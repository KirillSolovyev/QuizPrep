using System;
using System.Threading;

namespace Example{
    class Program{
        static void Main(){
            while(true){
                DateTime time = DateTime.Now;
                TimeSpan diff = time.Subtract(new DateTime(2019, 3, 27, 13, 31, 0));
                Console.WriteLine(time.ToString("yyyy-MM-dd HH:mm:ss.fff") + " " + diff);
                Thread.Sleep(1000);
            }
        }
    }
}