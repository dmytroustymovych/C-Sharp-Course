using ConsoleApp1.Models;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections;
//using Dapper;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //// Way #1 (using SQL Server directly)
            //// Connection string
            //string MSSqlconnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Practice; Integrated Security = True; Trust Server Certificate = True";
            //// Made a connection
            //SqlConnection MSSqlconnection = new SqlConnection(MSSqlconnectionString);
            //// Opening a connection with a database
            //MSSqlconnection.Open();

            ////string sqlCommand = "INSERT INTO Project.Computer(CPUcores) VALUES(2);";
            ////SqlCommand command = new SqlCommand(sqlCommand, MSSqlconnection);
            ////var query = command.;

            //string sqlCommand1 = "SELECT * FROM Project.Computer Where CPUcores = 3";
            //SqlCommand nextcommand = new SqlCommand(sqlCommand1, MSSqlconnection);

            //// Я також змінив функцію CreateComputer для створення нового об'єкта в БД
            //var computer1 = Computer.CreateComputer();

            ////SqlDataReader query1 = nextcommand.ExecuteReader();
            //var reader = nextcommand.ExecuteReader();

            //while(reader.Read())
            //{
            //    Console.Write($"IDComputer: {reader["id_computer"]}");
            //    Console.Write($" Motherboard: {reader["Motherboard"]}");
            //    Console.Write($" CPUCores: {reader["CPUCores"]}");
            //    Console.Write($" HasWiFi: {reader["HasWiFi"]}");
            //    Console.Write($" HasLTE: {reader["HasLTE"]}");
            //    Console.Write($" ReleaseDate: {reader["Release_Date"]}");
            //    Console.Write($" Price: {reader["Price"]}");
            //    Console.Write($" VideoCard: {reader["VideoCard"]}\n");
            //}


            //while (reader.Read())
            //{
            //    Console.WriteLine($"CPU Cores: {reader["CPUcores"]}");
            //}
            ////Console.WriteLine($"Data Inserted: {reader}\n");

            //// Way #2 (using MySQL directly)
            //// Connection string
            //string MySQLconnectionString = "Server=localhost;Database=Practice;User ID=root;Password=hgh$&^489hbjkpio*;";
            //// Made a connection
            //MySqlConnection MySqlconnection = new MySqlConnection(MySQLconnectionString);
            //// Opening a connection with a database
            //MySqlconnection.Open();
            //// Made a Command
            //MySqlCommand command1 = new MySqlCommand("SELECT NOW();", MySqlconnection);
            //var result = command1.ExecuteScalar();
            //Console.WriteLine($"Current MySQL server time: {result}");

            // I don't want to use Dapper right now, so I will just use the native SQL Server and MySQL packages
            // Maybe I will implement Dapper later

            //var computer1 = Computer.CreateComputer();
            //Console.WriteLine(computer1);
            //// No, I don't want to make a second method just to output data, too lazy
            //Console.WriteLine($"IdComputer: {computer1.IdComputer}");
            //Console.WriteLine($"Motherboard: {computer1.Motherboard}");
            //Console.WriteLine($"CPUCores: {computer1.CPUCores}");
            //Console.WriteLine($"HasWifi: {computer1.HasWifi}");
            //Console.WriteLine($"HasLTE: {computer1.HasLTE}");
            //Console.WriteLine($"ReleaseDate: {computer1.ReleaseDate}");
            //Console.WriteLine($"Price: {computer1.Price}");
            //Console.WriteLine($"VideoCard: {computer1.VideoCard}");


            string[] colors = { "green", "brown", "blue", "red" };
            Console.WriteLine(colors.OrderBy(c => c.Length).First());

        }
    }
}
