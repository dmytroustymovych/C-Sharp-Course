using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
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
                DateTime RD_DateTime = ReleaseDate.ToDateTime(TimeOnly.MinValue);

                // What I wasn't prepared for, this functin wanted "," as separator, not "." (like 12,14)
                Console.WriteLine("Input Price");
                Price = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Input VideoCard");
                VideoCard = Console.ReadLine();

                // Saving data in console
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

                // Saving data in SQL Server
                string MSSqlconnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Practice; Integrated Security = True; Trust Server Certificate = True";
                SqlConnection MSSqlconnection = new SqlConnection(MSSqlconnectionString);
                MSSqlconnection.Open();

                // Don't know why, but it dosen't work, says There are fewer columns in the INSERT statement than values specified in the VALUES clause
                // Will try the other way
                //string SqlCommand = "INSERT INTO Project.Computer(Motherboard, CPUcores, HasWiFi, HasLTE, Release_Date, Price, VideoCard) VALUES " +
                //$"('{Motherboard}', {CPUCores}, {(HasWifi ? 1 : 0)}, {(HasLTE ? 1 : 0)}, '{RD_DateTime:yyyy-MM-dd}', {Price}, '{VideoCard}')";
                string SqlCommand = "INSERT INTO Project.Computer(Motherboard, CPUcores, HasWiFi, HasLTE, Release_Date, Price, VideoCard) VALUES " +
                "(@Motherboard, @CPUCores, @HasWiFi, @HasLTE, @ReleaseDate, @Price, @VideoCard)";
                SqlCommand command = new SqlCommand(SqlCommand, MSSqlconnection);

                command.Parameters.AddWithValue("@Motherboard", Motherboard);
                command.Parameters.AddWithValue("@CPUCores", CPUCores);
                command.Parameters.AddWithValue("@HasWifi", HasWifi);
                command.Parameters.AddWithValue("@HasLTE", HasLTE);
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@VideoCard", VideoCard);

                command.ExecuteNonQuery();
                Console.WriteLine("Computer created successfully!");

            return computer;
            }
        }

    

}
