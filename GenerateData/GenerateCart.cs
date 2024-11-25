/*using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace PLEER.GenerateData
{
    public class GenerateCart
    {
        public static void Main(string[] args)
        {

             var cartFaker = new Faker<Cart>()
             .RuleFor(c => c.Id, f => f.IndexFaker + 1) // ID автоинкремент
             .RuleFor(c => c.CustomerId, f => f.IndexFaker + 1); // Генерация случайных CustomerId, предположим, что у вас 100 клиентов

             var carts = cartFaker.Generate(100000);
             var filePath = "carts.csv";
             using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
             {
                 // Записываем заголовки
                 writer.WriteLine("Id,CustomerId");

                 // Записываем сгенерированные данные
                 foreach (var cart in carts)
                 {
                     writer.WriteLine($"{cart.Id},{cart.CustomerId}");
                 }
             }
             Console.WriteLine($"Данные успешно сохранены в {filePath}");



        }
    }
}


*/