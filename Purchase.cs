internal class Purchase
{
    private string itemName;
    private double itemPrice;
    private int quantity;
    private readonly DateTime paymentDate;
    private const double TaxRate = 0.25;

    public Purchase()
    {
        paymentDate = DateTime.Now;
    }
    public void Start()
    {
        ReadAndSavePurchaseData();
        DisplayPurchaseInfo();
    }
    private void ReadAndSavePurchaseData()
    {
        Console.Write("Enter item name: ");
        itemName = Console.ReadLine();

        Console.Write("Enter item price: ");
        itemPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter quantity: ");
        quantity = int.Parse(Console.ReadLine());
    }

    private void DisplayPurchaseInfo()
    {
        double subtotal = itemPrice * quantity;
        double tax = subtotal * TaxRate;
        double total = subtotal + tax;

        Console.WriteLine("                   ");
        Console.WriteLine("-------------------");
        Console.WriteLine("                   ");

        Console.WriteLine($"Item: {itemName} ");
        Console.WriteLine($"Quantity: {quantity }");
        Console.WriteLine($"Price per item: ${itemPrice} ");
        Console.WriteLine($"Subtotal: ${subtotal}");
        Console.WriteLine($"Tax ({TaxRate * 100}%): ${tax} ");
        Console.WriteLine($"Total Amount: ${total} ");
        Console.WriteLine($"Payment Date: {paymentDate} ");

        Console.WriteLine("                   ");
        Console.WriteLine("-------------------");
        Console.WriteLine("                   ");
    }
}