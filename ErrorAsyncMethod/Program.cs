namespace ErrorAsyncMethod
{
    internal class Program
    {
        async static Task PrintAsync(string message)
        {
            if (message.Length < 3)
                throw new ArgumentException($"Invalid string length: {message.Length}");
            await Task.Delay(100);
            Console.WriteLine(message);
        }
        async static Task Main(string[] args)
        {

            //try
            //{
            //    await PrintAsync("******"); 
            //    await PrintAsync("__");
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}




            //Task task = PrintAsync("++");
            //try
            //{
            //    await task;
            //}
            //catch
            //{
            //    Console.WriteLine(task.Exception?.InnerException?.Message);
            //    Console.WriteLine($"IsFaulted: {task.IsFaulted}");
            //    Console.WriteLine($"Status: {task.Status}");
            //}





            //Task task1 = PrintAsync("*");
            //Task task2 = PrintAsync("--");
            //Task allTasks = Task.WhenAll(task1, task2);

            //try
            //{
            //    await allTasks;
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine($"Exception: {ex.Message}");
            //    Console.WriteLine($"IsFaulted: {allTasks.IsFaulted}");

            //    if(allTasks.Exception is not null)
            //    {
            //        foreach(var exception in allTasks.Exception.InnerExceptions)
            //        {
            //            Console.WriteLine($"InnerException: {exception.Message}");
            //        }
            //    }
            //}


            
            



        }
    }
}
