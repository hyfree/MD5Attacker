using System;
using System.Text;
using System.Threading.Tasks;

namespace MD5Attacker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var paps="pass";
            //var key="key";
            //var a= paps.MDString3(key);
            //Console.WriteLine(a);

            //var data1=Encoding.ASCII.GetBytes(paps);
            //var data2=Encoding.ASCII.GetBytes(key);

            //var hash=data1.MDString3(data2);
            //Console.WriteLine(hash);
            //Console.ReadKey();

            var hash = "3b75187f5e19a034b5d0a8d35de5f9b2";
            var salt = "vBBfYYWkriJvpMtFBL3xhVs9oo5QvbRPxUgCKJqFMF6iZKkhk6eMNqSXDus3WJ";
            var a="null";
            Task task1 = new Task(() =>
            {
                for (long i = 45823062; i < 166_666_666_666; i++)
                {
                    var h2 = i.ToString().MDString3(salt);
                   
                    if (h2.Equals(hash))
                    {
                        a=i.ToString();
                    }
                }
            });
                 Task task2 = new Task(() =>
            {
                for (long i = 166_666_666_666; i < 366_666_666_666; i++)
                {
                    var h2 = i.ToString().MDString3(salt);
                  
                    if (h2.Equals(hash))
                    {
                       a=i.ToString();
                    }
                }
            });
                  Task task3 = new Task(() =>
            {
                for (long i = 366_666_666_666; i < 666_666_666_666; i++)
                {
                    var h2 = i.ToString().MDString3(salt);
                   
                    if (h2.Equals(hash))
                    {
                        a=i.ToString();
                    }
                }
            });
                 Task task4 = new Task(() =>
            {
                for (long i = 666_666_666_666; i < 966_666_666_666; i++)
                {
                    var h2 = i.ToString().MDString3(salt);
                   
                    if (h2.Equals(hash))
                    {
                         a=i.ToString();
                    }
                }
            });
                  Task task5 = new Task(() =>
            {
                for (long i = 966_666_666_666; i < 999_999_999_999; i++)
                {
                    var h2 = i.ToString().MDString3(salt);
                    
                    if (h2.Equals(hash))
                    {
                        a=i.ToString();
                    }
                }
            });
            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();
            Task.WaitAll(task1,task2,task3,task4,task5);
            Console.WriteLine("答案="+a);
            Console.ReadKey();
        }
    }
}