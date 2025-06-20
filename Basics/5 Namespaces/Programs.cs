using ConsoleApp2.Models;

namespace ConsoleApp2
{
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
}
