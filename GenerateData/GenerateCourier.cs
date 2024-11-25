/*using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEER
{
    using Bogus;
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



        public class GenerateCourier
        {
            public static void Main(string[] args)
            {
                
                 var faker = new Faker<Courier>("ru") // Устанавливаем локализацию "ru" 
                     .RuleFor(c => c.Id, f => f.IndexFaker + 1)  // Генерация уникального ID
                     .RuleFor(c => c.LastName, f => f.Name.LastName())  // Генерация фамилии 
                     .RuleFor(c => c.FirstName, f => f.Name.FirstName())  // Генерация имени
                     .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("+7 (###) ###-##-##"));  // Генерация телефона в российском формате

                 var couriers = faker.Generate(1000);
                 var filePath = "couriers.csv";
                 using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
                 {
                     // Записываем заголовки
                     writer.WriteLine("Id,Last_name,First_name,Phone");

                     // Записываем сгенерированные данные
                     foreach (var courier in couriers)
                     {
                         writer.WriteLine($"{courier.Id},{courier.LastName},{courier.FirstName},{courier.Phone}");
                     }
                 }
                 Console.WriteLine($"Данные успешно сохранены в {filePath}"); 

                

            }
        }
    }
}*/