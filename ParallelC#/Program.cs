using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

// task 1 - numb 5
//namespace ParallelC_
//{
//    class My_Class
//    {
//        public double Func(double x)
//        {
//            int N = Math.Max(20, (int)Math.Floor(20 * Math.Abs(x)));
//            double S = 0;
//            double x2 = x * x;
//            for (int k = 1; k <= N; k++)
//                for (int j = 1; j <= N; j++)
//                    S += x2 * j * Math.Sin((k + 2 * j) * x) / (x2 + k * k + j * j * j);
//            return S;
//        }
//    };
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            const int N = 100;
//            My_Class Obj = new My_Class();
//            double[] V = new double[N];
//            Int64 Tms = (DateTime.Now).Ticks;
//            for (int k = 0; k < N; k++)
//            { V[k] = Obj.Func(k); }
//            Tms = (DateTime.Now).Ticks - Tms;
//            TimeSpan Tmss = new TimeSpan(Tms);
//            Console.WriteLine("Время выполнения послед. цикла " +
//            +Tmss.TotalSeconds + " c");
//            Tms = (DateTime.Now).Ticks;
//            System.Threading.Tasks.Parallel.For(0, N, k =>
//            {
//                V[k] =
//           Obj.Func(k);
//            });
//            Tms = (DateTime.Now).Ticks - Tms;
//            Tmss = new TimeSpan(Tms);
//            Console.WriteLine("Время выполнения парал. цикла "
//            + (Tmss.TotalSeconds).ToString() + " с");

//        }
//    }
//}


// task 2 - numb 5
namespace ParallelC_
{
    class My_Class
    {
        public double Func(double x)
        {
            int N = Math.Max(20, (int)Math.Floor(20 * Math.Abs(x)));
            double S = 0;
            double x2 = x * x;
            for (int k = 1; k <= N; k++)
                for (int j = 1; j <= N; j++)
                    S += x2 * j * Math.Sin((k + 2 * j) * x) / (x2 + k * k + j * j * j);
            return S;
        }
    };
    class Program
    {
        //task 2
        //static void Main(string[] args)
        //{
        //    const int N = 200;
        //    My_Class fobj = new My_Class();
        //    double[] X = new double[N + 1];
        //    for (int k = 0; k <= N; k++)
        //    {
        //        X[k] = 100 * Math.Cos(1.0 * k);
        //    }
        //    double S = 0;
        //    Int64 Tms = (DateTime.Now).Ticks;
        //    foreach (double x in X)
        //        S += fobj.Func(x);
        //    Tms = (DateTime.Now).Ticks - Tms;
        //    TimeSpan Tmss = new TimeSpan(Tms);
        //    Console.WriteLine("S=" + S.ToString());
        //    Console.WriteLine("Время выполнения последовательной операции foreach " + (Tmss.TotalSeconds).ToString() + " c");

        //    Object obj = new Object();
        //    S = 0;
        //    Tms = (DateTime.Now).Ticks;
        //    Parallel.ForEach(X,
        //    x =>
        //    {
        //        double Tmp = fobj.Func(x);
        //        lock (obj) { S += Tmp; }
        //    }
        //    );
        //    Tms = (DateTime.Now).Ticks - Tms;
        //    Tmss = new TimeSpan(Tms);
        //    Console.WriteLine("S=" + S.ToString());
        //    Console.WriteLine("Время выполнения параллельного метода ForEach " + (Tmss.TotalSeconds).ToString() + " c");

        //    Console.ReadKey();
        //}

        // task 3

        //static void Main(string[] args)
        //{
        //    const int N = 200;
        //    My_Class fobj = new My_Class();

        //    List<double> XList = new List<double>();
        //    for (int k = 0; k <= N; k++)
        //    {
        //        XList.Add(100 * Math.Cos(1.0 * k));
        //    }

        //    Stack<double> XStack = new Stack<double>();
        //    for (int k = N; k >= 0; k--)
        //    {
        //        XStack.Push(100 * Math.Cos(1.0 * k));
        //    }

        //    Queue<double> XQueue = new Queue<double>();
        //    for (int k = 0; k <= N; k++)
        //    {
        //        XQueue.Enqueue(100 * Math.Cos(1.0 * k));
        //    }

        //    double S = 0;
        //    Int64 Tms = (DateTime.Now).Ticks;
        //    foreach (double x in XList)
        //        S += fobj.Func(x);
        //    Tms = (DateTime.Now).Ticks - Tms;
        //    TimeSpan Tmss = new TimeSpan(Tms);
        //    Console.WriteLine("S=" + S.ToString());
        //    Console.WriteLine("Время выполнения последовательной операции foreach для List: " + (Tmss.TotalSeconds).ToString() + " c");

        //    S = 0;
        //    Tms = (DateTime.Now).Ticks;
        //    foreach (double x in XStack)
        //        S += fobj.Func(x);
        //    Tms = (DateTime.Now).Ticks - Tms;
        //    Tmss = new TimeSpan(Tms);
        //    Console.WriteLine("S=" + S.ToString());
        //    Console.WriteLine("Время выполнения последовательной операции foreach для Stack: " + (Tmss.TotalSeconds).ToString() + " c");

        //    S = 0;
        //    Tms = (DateTime.Now).Ticks;
        //    foreach (double x in XQueue)
        //        S += fobj.Func(x);
        //    Tms = (DateTime.Now).Ticks - Tms;
        //    Tmss = new TimeSpan(Tms);
        //    Console.WriteLine("S=" + S.ToString());
        //    Console.WriteLine("Время выполнения последовательной операции foreach для Queue: " + (Tmss.TotalSeconds).ToString() + " c");

        //    Object obj = new Object();
        //    S = 0;
        //    Tms = (DateTime.Now).Ticks;
        //    System.Threading.Tasks.Parallel.ForEach(XList,
        //    x =>
        //    {
        //        double Tmp = fobj.Func(x);
        //        lock (obj) { S += Tmp; }
        //    }
        //    );
        //    Tms = (DateTime.Now).Ticks - Tms;
        //    Tmss = new TimeSpan(Tms);
        //    Console.WriteLine("S=" + S.ToString());
        //    Console.WriteLine("Время выполнения параллельного метода ForEach для List: " + (Tmss.TotalSeconds).ToString() + " c");

        //    S = 0;
        //    Tms = (DateTime.Now).Ticks;
        //    System.Threading.Tasks.Parallel.ForEach(XStack,
        //    x =>
        //    {
        //        double Tmp = fobj.Func(x);
        //        lock (obj) { S += Tmp; }
        //    }
        //    );
        //    Tms = (DateTime.Now).Ticks - Tms;
        //    Tmss = new TimeSpan(Tms);
        //    Console.WriteLine("S=" + S.ToString());
        //    Console.WriteLine("Время выполнения параллельного метода ForEach для Stack: " + (Tmss.TotalSeconds).ToString() + " c");

        //    S = 0;
        //    Tms = (DateTime.Now).Ticks;
        //    System.Threading.Tasks.Parallel.ForEach(XQueue,
        //    x =>
        //    {
        //        double Tmp = fobj.Func(x);
        //        lock (obj) { S += Tmp; }
        //    }
        //    );
        //    Tms = (DateTime.Now).Ticks - Tms;
        //    Tmss = new TimeSpan(Tms);
        //    Console.WriteLine("S=" + S.ToString());
        //    Console.WriteLine("Время выполнения параллельного метода ForEach для Queue: " + (Tmss.TotalSeconds).ToString() + " c");
        //    Console.ReadKey();
        //}

        // task 4
        static void Main(string[] args)
        {
            const int N = 200;
            My_Class fobj = new My_Class();

            List<double> XList = new List<double>();
            for (int k = 0; k <= N; k++)
            {
                XList.Add(100 * Math.Cos(1.0 * k));
            }

            Stack<double> XStack = new Stack<double>();
            for (int k = N; k >= 0; k--)
            {
                XStack.Push(100 * Math.Cos(1.0 * k));
            }

            Queue<double> XQueue = new Queue<double>();
            for (int k = 0; k <= N; k++)
            {
                XQueue.Enqueue(100 * Math.Cos(1.0 * k));
            }

            List<double> YList = new List<double>();
            Stack<double> YStack = new Stack<double>();
            Queue<double> YQueue = new Queue<double>();

            Stopwatch stopwatch = new Stopwatch();
            double S = 0;

            // последовательная операция foreach для List
            stopwatch.Start();
            foreach (double x in XList)
                YList.Add(fobj.Func(x));
            S = YList.Sum();
            stopwatch.Stop();
            Console.WriteLine("S=" + S.ToString());
            Console.WriteLine("Время выполнения последовательной операции foreach для List: " + stopwatch.Elapsed.TotalSeconds.ToString() + " c");

            // последовательная операция foreach для Stack
            stopwatch.Restart();
            foreach (double x in XStack)
                YStack.Push(fobj.Func(x));
            S = YStack.Sum();
            stopwatch.Stop();
            Console.WriteLine("S=" + S.ToString());
            Console.WriteLine("Время выполнения последовательной операции foreach для Stack: " + stopwatch.Elapsed.TotalSeconds.ToString() + " c");

            // последовательная операция foreach для Queue
            stopwatch.Restart();
            foreach (double x in XQueue)
                YQueue.Enqueue(fobj.Func(x));
            S = YQueue.Sum();
            stopwatch.Stop();
            Console.WriteLine("S=" + S.ToString());
            Console.WriteLine("Время выполнения последовательной операции foreach для Queue: " + stopwatch.Elapsed.TotalSeconds.ToString() + " c");

            Object obj = new Object();
            S = 0;

            // параллельный метод ForEach для List
            stopwatch.Restart();
            System.Threading.Tasks.Parallel.ForEach(XList, x =>
            {
                double Tmp = fobj.Func(x);
                lock (obj)
                {
                    YList.Add(Tmp);
                }
            });
            S = YList.Sum();
            stopwatch.Stop();
            Console.WriteLine("S=" + S.ToString());
            Console.WriteLine("Время выполнения параллельного метода ForEach для List: " + stopwatch.Elapsed.TotalSeconds.ToString() + " c");

            YStack.Clear(); // очищаем Stack и Queue для следующего использования
            YQueue.Clear();

            // параллельный метод ForEach для Stack
            stopwatch.Restart();
            System.Threading.Tasks.Parallel.ForEach(XStack, x =>
            {
                double Tmp = fobj.Func(x);
                lock (obj)
                {
                    YStack.Push(Tmp);
                }
            });
            S = YStack.Sum();
            stopwatch.Stop();
            Console.WriteLine("S=" + S.ToString());
            Console.WriteLine("Время выполнения параллельного метода ForEach для Stack: " + stopwatch.Elapsed.TotalSeconds.ToString() + " c");

            // параллельный метод ForEach для Queue
            stopwatch.Restart();
            System.Threading.Tasks.Parallel.ForEach(XQueue, x =>
            {
                double Tmp = fobj.Func(x);
                lock (obj)
                {
                    YQueue.Enqueue(Tmp);
                }
            });
            S = YQueue.Sum();
            stopwatch.Stop();
            Console.WriteLine("S=" + S.ToString());
            Console.WriteLine("Время выполнения параллельного метода ForEach для Queue: " + stopwatch.Elapsed.TotalSeconds.ToString() + " c");

            Console.ReadKey();
        }

    }
}


