namespace ReturningAsynchronousMethod
{
    internal class Program
    {
        async static void PrintAsync(string message)
        {
            await Task.Delay(1000);
            Console.WriteLine(message);
        }
        async static Task PrintAsync2(string message)
        {
            await Task.Delay(3000);
            Console.WriteLine(message);
        }
        async static Task<int> SquareAsync(int n)
        {
            await Task.Delay(0);
            return n * n;
        }
        async static Task Main(string[] args)
        {


            //PrintAsync("Hi");
            //PrintAsync("Hello");
            //await Task.Delay(3000);




            //Task task =  PrintAsync2("Hello");
            //Console.WriteLine("Main Works");
            //await task; // ожидаем завершения задачи




            int n1 = await SquareAsync(4);
            int n2 = await SquareAsync(5);
            Console.WriteLine(n1 + " " + n2);










        }
    }
}
