using Microsoft.VisualBasic;

namespace AsyncAwait
{
    internal class Program
    {
        static void Print()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello");
        }
        async static Task PrintAsync()
        {
            Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
            await Task.Run(() => Print()); // выполняется асинхронно
            Console.WriteLine("Конец метода PrintAsync");
        }
        async static Task PrintAsync2()
        {
            await Task.Delay(2000);
            Console.WriteLine("Hello");
        }
        async static Task PrintNameAsync(string name)
        {
            await Task.Delay(2000);
            Console.WriteLine(name);
        }
        static Func<string, Task> printer = async (message) =>
        {
            await Task.Delay(1000);
            Console.WriteLine(message);
        };

        async static Task Main(string[] args)
        {

            //await PrintAsync();
            //Console.WriteLine("Некоторые действия в методе Main");





            //await PrintAsync2();
            //Console.WriteLine("Некоторые действия в методе Main");





            //Task genaTask = PrintNameAsync("Gena");
            //Task zinaTask = PrintNameAsync("Zina");
            //Task jackTAsk =  PrintNameAsync("Jack");

            //await genaTask;
            //await zinaTask;
            //await jackTAsk;



            await printer("HI");
            await printer("Hello");


        }
    }
}
