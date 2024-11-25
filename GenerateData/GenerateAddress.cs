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



    public class GenerateAddress
    {
        public static void Main(string[] args)
        {
            var addressFaker = new Faker<Address>("ru")
                .RuleFor(a => a.Id, f => f.IndexFaker + 1)  // Генерация уникальных Id
                .RuleFor(a => a.City, f => f.Address.City())  // Генерация города
                .RuleFor(a => a.Street, f => f.Address.StreetName())  // Генерация улицы
                .RuleFor(a => a.House, f => f.Address.BuildingNumber())  // Генерация дома
                .RuleFor(a => a.Floor, f => f.Random.Int(1, 100).ToString())  // Генерация этажа 
                .RuleFor(a => a.Apartment, f => f.Random.Int(1, 200).ToString());  // Генерация квартиры 
                                                                                   // Генерация данных
            var addresses = addressFaker.Generate(110000);

            // Путь к файлу для записи CSV
            var filePath = "addresses.csv";

            // Создаем или очищаем CSV файл
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Записываем заголовки
                writer.WriteLine("Id,City,Street,House,Floor,Apartment");

                // Записываем сгенерированные данные
                foreach (var address in addresses)
                {
                    writer.WriteLine($"{address.Id},{address.City},{address.Street},{address.House},{address.Floor},{address.Apartment}");
                }
            }

            Console.WriteLine($"Данные успешно сохранены в {filePath}");

        }
    }
}
*/