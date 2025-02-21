// See https://aka.ms/new-console-template for more information


namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepareConsolesLook();

            Pet myDog = new Pet();
            myDog.Start();
           

            Album alb1 = new Album();
            // alb1.Start();
            // alb1.Print();

            TicketSeller tick1 = new TicketSeller();
            // tick1.Start();
            // tick1.Print();

            Purchase purchase1 = new Purchase();
            // purchase1.Start();
            // purchase1.Print();
        }

        static void PrepareConsolesLook()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Title = "My first C# program!";
        }
    }

}
