/*using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace PLEER.GenerateData
{
    
    class Program
    {
        static void Main()
        {
            int totalOrders = 220000; // Общее количество заказов
            int totalCustomers = 100000; // Общее количество пользователей
            int totalAddresses = 110000; // Общее количество адресов
            int totalTransactions = 200000; // Общее количество транзакций
            int totalCouriers = 1000; // Общее количество курьеров

            var orders = GenerateCustomerOrders(totalOrders, totalCustomers, totalAddresses, totalTransactions, totalCouriers);

            // Указываем путь для файла
            string filePath = "customer_orders.csv";

            // Генерация и запись данных в CSV файл
            WriteOrdersToCsv(filePath, orders);
        }

        static List<Customerorder> GenerateCustomerOrders(int totalOrders, int totalCustomers, int totalAddresses, int totalTransactions, int totalCouriers)
        {
            var random = new Random();
            var usedTransactionIds = new HashSet<int>(); // Множество для отслеживания использованных транзакций
            var orders = new List<Customerorder>();

            // Генерация заказов с уникальными Id от 1 до 220000
            for (int i = 0; i < totalOrders; i++)
            {
                int customerId = random.Next(1, totalCustomers + 1);
                int addressId = random.Next(1, totalAddresses + 1);
                int statusId = random.Next(1, 12); // Статусы от 1 до 12
                int? transactionId = null;

                // Привязываем транзакцию только для статусов от 3 до 12
                if (statusId >= 3 && statusId <= 12)
                {
                    int tempTransactionId;
                    do
                    {
                        tempTransactionId = random.Next(1, totalTransactions + 1);
                    } while (usedTransactionIds.Contains(tempTransactionId)); // Проверка, была ли транзакция уже использована

                    usedTransactionIds.Add(tempTransactionId); // Добавляем транзакцию в множество
                    transactionId = tempTransactionId;
                }

                // Генерация курьера (от 1 до 1000)
                int? courierId = random.Next(1, totalCouriers + 1);

                // Генерация случайной даты
                var orderDate = GenerateRandomDate(random, new DateTime(2020, 1, 1), DateTime.Now);

                var order = new Customerorder
                {
                    Id = i + 1, // Генерация уникального Id от 1 до 220000
                    CustomerId = customerId,
                    AddressId = addressId,
                    TransactionId = transactionId,
                    StatusId = statusId,
                    CourierId = courierId,
                    OrderDate = orderDate
                };

                orders.Add(order);
            }

            return orders;
        }

        // Функция для генерации случайной даты в указанном диапазоне
        static DateTime GenerateRandomDate(Random random, DateTime start, DateTime end)
        {
            var range = end - start;
            var randomTimeSpan = new TimeSpan((long)(random.NextDouble() * range.Ticks));
            return start + randomTimeSpan;
        }

        // Метод для записи заказов в CSV файл с использованием CsvHelper
        static void WriteOrdersToCsv(string filePath, List<Customerorder> orders)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
            {
                // Запись заголовка
                csv.WriteRecords(orders); // CsvHelper автоматически записывает данные в CSV формат
                Console.WriteLine($"Данные успешно записаны в файл: {filePath}");
            }
        }
    }
}
*/