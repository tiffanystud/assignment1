using System;

class TicketSeller
{
    private string name = "Unknown";
    private double price = 99;
    private int numOfAdults;
    private int numOfChildren;
    private double amountToPay;

    public void Start()
    {
        ReadAndSaveTickerData();
        CalculateTotal();
        DisplayTicketInfo();
    }

    private void ReadAndSaveTickerData()
    {
        Console.Write("Enter the ticket seller's name: ");
        name = Console.ReadLine();

        Console.Write("Enter the number of adult tickets sold: ");
        numOfAdults = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children tickets sold: ");
        numOfChildren = int.Parse(Console.ReadLine());
    }

    private void CalculateTotal()
    {
        amountToPay = (numOfAdults * price) + (numOfChildren * (price * 0.5));
    }

    private void DisplayTicketInfo()
    {
        Console.WriteLine("                   ");
        Console.WriteLine("-------------------");
        Console.WriteLine("                   ");

        Console.WriteLine($"Seller: {name} ");
        Console.WriteLine($"Adult Tickets Sold: {numOfAdults} ");
        Console.WriteLine($"Children Tickets Sold: {numOfChildren} ");
        Console.WriteLine($"Total Amount to Pay: ${amountToPay} ");

        Console.WriteLine("                   ");
        Console.WriteLine("-------------------");
        Console.WriteLine("                   ");
    }
}