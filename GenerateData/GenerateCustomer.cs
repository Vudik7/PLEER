/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Bogus;
using CsvHelper;
using CsvHelper.Configuration;

namespace PLEER.GenerateData
{
    public class GenerateCustomer
    {
        // Коллекция для хранения всех сгенерированных email
        private static HashSet<string> GeneratedEmails = new HashSet<string>();

        // Метод для генерации уникального email
        private static string GenerateUniqueEmail(Faker f, Customer c)
        {
            // Преобразуем имя и фамилию в латиницу
            var firstNameLatin = Transliterate(c.FirstName);
            var lastNameLatin = Transliterate(c.LastName);

            var emailPrefix = $"{firstNameLatin.ToLower()}_{lastNameLatin.ToLower()}";
            var domains = new[] { "@gmail.com", "@mail.ru", "@yahoo.com", "@yandex.com" };
            var domain = f.PickRandom(domains);

            string email;
            do
            {
                // Генерация email с добавлением случайного числа
                email = $"{emailPrefix}{f.Random.Int(1, 1000)}{domain}";
            }
            while (GeneratedEmails.Contains(email)); // Проверка на уникальность

            // Добавляем сгенерированный email в коллекцию
            GeneratedEmails.Add(email);

            return email;
        }

        // Метод для транслитерации кириллицы в латиницу
        public static string Transliterate(string input)
        {
            var translitDict = new Dictionary<char, string>
            {
                {'А', "A"}, {'Б', "B"}, {'В', "V"}, {'Г', "G"}, {'Д', "D"}, {'Е', "E"},
                {'Ё', "Yo"}, {'Ж', "Zh"}, {'З', "Z"}, {'И', "I"}, {'Й', "Y"}, {'К', "K"},
                {'Л', "L"}, {'М', "M"}, {'Н', "N"}, {'О', "O"}, {'П', "P"}, {'Р', "R"},
                {'С', "S"}, {'Т', "T"}, {'У', "U"}, {'Ф', "F"}, {'Х', "Kh"}, {'Ц', "Ts"},
                {'Ч', "Ch"}, {'Ш', "Sh"}, {'Щ', "Shch"}, {'Ъ', ""}, {'Ы', "Y"}, {'Ь', ""},
                {'Э', "E"}, {'Ю', "Yu"}, {'Я', "Ya"},
                {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "g"}, {'д', "d"}, {'е', "e"},
                {'ё', "yo"}, {'ж', "zh"}, {'з', "z"}, {'и', "i"}, {'й', "y"}, {'к', "k"},
                {'л', "l"}, {'м', "m"}, {'н', "n"}, {'о', "o"}, {'п', "p"}, {'р', "r"},
                {'с', "s"}, {'т', "t"}, {'у', "u"}, {'ф', "f"}, {'х', "kh"}, {'ц', "ts"},
                {'ч', "ch"}, {'ш', "sh"}, {'щ', "shch"}, {'ъ', ""}, {'ы', "y"}, {'ь', ""},
                {'э', "e"}, {'ю', "yu"}, {'я', "ya"}
            };

            var result = new StringBuilder();
            foreach (var c in input)
            {
                result.Append(translitDict.ContainsKey(c) ? translitDict[c] : c.ToString());
            }
            return result.ToString();
        }

        // Метод для генерации и записи данных в CSV файл
        public static void GenerateAndSaveCustomers()
        {
            var customerFaker = new Faker<Customer>("ru")
                .RuleFor(c => c.Id, f => f.IndexFaker + 1) // ID автоинкремент
                .RuleFor(c => c.LastName, f => f.Name.LastName()) // Фамилия
                .RuleFor(c => c.FirstName, f => f.Name.FirstName()) // Имя
                .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("+7 (###) ###-####")) // Телефон в российском формате
                .RuleFor(c => c.Email, (f, c) => GenerateUniqueEmail(f, c)); // Генерация email с уникальностью

            // Генерируем 100000 записей
            var customers = customerFaker.Generate(100000);

            // Путь для сохранения CSV файла
            var filePath = "customers.csv";

            // Записываем в файл
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Записываем заголовки
                writer.WriteLine("Id,LastName,FirstName,Phone,Email");

                // Записываем сгенерированные данные
                foreach (var customer in customers)
                {
                    writer.WriteLine($"{customer.Id},{customer.LastName},{customer.FirstName},{customer.Phone},{customer.Email}");
                }
            }

            Console.WriteLine($"Данные успешно сохранены в {filePath}");
        }
    }

}
*/