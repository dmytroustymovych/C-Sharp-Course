public class Computer
{
    // When creating classes, id is a must 90% of the time(sourse: me)  
    public int IdComputer { get; set; }

    private int ComputerID { get; set; } = 1;

    public string Motherboard { get; set; } = "";

    public int CPUCores { get; set; }

    public bool HasWifi { get; set; }

    public bool HasLTE { get; set; }

    // Could also use DateTime, but it is better if want to have precise time
    public DateOnly ReleaseDate { get; set; }

    public Decimal Price { get; set; }

    public string VideoCard { get; set; } = "";

    public Computer()
    {
        // Nice Autoincrementor(just like in most SQL languages)
        IdComputer = ComputerID++;
    }

    // I mean, if u want to make a computer example, you can just create a method for imputing data
    // Though never do it like I did. It's just an example; Also I didn't do null checkers
    public static Computer CreateComputer()
    {
        string Motherboard;
        int CPUCores;
        bool HasWifi;
        bool HasLTE;
        DateOnly ReleaseDate;
        Decimal Price;
        string VideoCard;

        Console.WriteLine("Creating a Computer...");
        
        Console.WriteLine("Input Motherboard");
        Motherboard = Console.ReadLine();

        Console.WriteLine("Input CPUCores");
        CPUCores = int.Parse(Console.ReadLine());

        Console.WriteLine("Input if it has WiFi");
        HasWifi = bool.Parse(Console.ReadLine());

        Console.WriteLine("Input if it has LTE");
        HasLTE = bool.Parse(Console.ReadLine());

        Console.WriteLine("Input ReleaseDate");
        ReleaseDate = DateOnly.Parse(Console.ReadLine());

        // What I wasn't prepared for, this functin wanted "," as separator, not "." (like 12,14)
        Console.WriteLine("Input Price");
        Price = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Input VideoCard");
        VideoCard = Console.ReadLine();

        var computer = new Computer()
        {
            Motherboard = Motherboard,
            CPUCores = CPUCores,
            HasWifi = HasWifi,
            HasLTE = HasLTE,
            ReleaseDate = ReleaseDate,
            Price = Price,
            VideoCard = VideoCard
        };

        return computer;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var computer1 = Computer.CreateComputer();
        Console.WriteLine(computer1);
        // No, I don't want to make a second method just to output data, too lazy
        Console.WriteLine($"IdComputer: {computer1.IdComputer}");
        Console.WriteLine($"Motherboard: {computer1.Motherboard}");
        Console.WriteLine($"CPUCores: {computer1.CPUCores}");
        Console.WriteLine($"HasWifi: {computer1.HasWifi}");
        Console.WriteLine($"HasLTE: {computer1.HasLTE}");
        Console.WriteLine($"ReleaseDate: {computer1.ReleaseDate}");
        Console.WriteLine($"Price: {computer1.Price}");
        Console.WriteLine($"VideoCard: {computer1.VideoCard}");


    }
}
