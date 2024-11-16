namespace _Task.WhenAll_Task.WhenAny
{
    internal class Program
    {
        async static Task PrintAsync(string message)
        {
            await Task.Delay(new Random().Next(1000, 2000));
            Console.WriteLine(message);
        }
        async static Task<int> SquareAsync(int n)
        {
            await Task.Delay(new Random().Next(500, 1000));
            return n * n;
        }
        async static Task Main(string[] args)
        {

            //Task task1 = PrintAsync("C#");
            //Task task2 = PrintAsync("WQAfsafsfr");
            //Task task3 = PrintAsync(":LKIPOI{OJK{OJKK{J");

            //await Task.WhenAll(task1, task2, task3);




            //Task task1 = PrintAsync("C#");
            //Task task2 = PrintAsync("WQAfsafsfr");
            //Task task3 = PrintAsync(":LKIPOI{OJK{OJKK{J");

            //await Task.WhenAny(task1, task2, task3);




            //Task<int> task1 = SquareAsync(2);
            //Task<int> task2 = SquareAsync(4);
            //Task<int> task3 = SquareAsync(6);

            //int[] res = await Task.WhenAll(task1, task2, task3);

            //foreach (int item in res)
            //{
            //    Console.WriteLine(item); 
            //}





            Task<int> task1 = SquareAsync(2);
            Task<int> task2 = SquareAsync(4);
            Task<int> task3 = SquareAsync(6);

            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine(task1.Result + " " + task3.Result);












        }
    }
}
