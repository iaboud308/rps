using System;


namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                MainApp app = new MainApp();
                app.Start();
            } catch {
                Console.WriteLine("Oops, something went wrong...");
            }
        }
    }
}
