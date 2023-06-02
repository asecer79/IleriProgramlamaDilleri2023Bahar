
using System.Threading.Channels;

namespace Week14
{

    class Program
    {  //Button calculate = new Button();
            //calculate.ButtonClick += CalculatePower;
            //calculate.Click();
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
          

            //Thread printThreadA = new Thread(PrintA);
            //printThreadA.IsBackground = true;
            //printThreadA.Start();

            PrintA();

           var t1= new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"A-{i}");
                }

            });

            t1.Start();

           //new Thread(SendEmail).Start(); //main thread
            Thread printThreadB = new Thread(PrintB);
            printThreadB.IsBackground = false;
            printThreadB.Start();

            //printThreadA.Join();
            //printThreadB.Join();

            t1.Wait();
            Console.WriteLine("Main Thread Ended");
        }


        static async Task PrintA()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("PrintA Thread Started");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"A-{i}");
                }

                Console.WriteLine("PrintA Thread Ended");
            });
        }

        static void PrintB()
        {
            Console.WriteLine("PrintB Thread Started");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"B-{i}");
            }

            Console.WriteLine("PrintB Thread Ended");

        }

        static void SendEmail()
        {
            //Thread.Sleep(30000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Email sent");
        }

        //private static void CalculatePower(string message)
        //{
        //    Console.WriteLine("Calculated-" + message);
        //}
    }


    //class Button
    //{
    //    public delegate void ButtonClickEventHandler(string message);

    //    public event ButtonClickEventHandler ButtonClick;

    //    public void Click()
    //    {
    //        Console.WriteLine("Button clicked");

    //        if (ButtonClick!=null)
    //        {
    //            ButtonClick("Event Triggered");
    //        }
    //    }
    //}

}

