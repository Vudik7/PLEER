/*using System;
using System.Collections.Generic;
using System.IO;

namespace PLEER.GenerateData
{
    class GenerateTransaction
    {
        static void Main()
        {
            int transactionCount = 200000; // Количество транзакций для генерации
            decimal minAmount = 400;        // Минимальная сумма транзакции
            decimal maxAmount = 400000;      // Максимальная сумма транзакции
            DateTime startDate = new DateTime(2020, 1, 1); // Начало диапазона дат
            DateTime endDate = DateTime.Now;              // Конец диапазона дат

            var transactions = GenerateTransactions(transactionCount, minAmount, maxAmount, startDate, endDate);

            // Сохранение в CSV
            SaveTransactionsToCsv(transactions, "transactions.csv");
        }

        static List<Transaction> GenerateTransactions(int count, decimal minAmount, decimal maxAmount, DateTime startDate, DateTime endDate)
        {
            var transactions = new List<Transaction>();
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                var transaction = new Transaction
                {
                    Id = i + 1,
                    Amount = GenerateRandomAmount(random, minAmount, maxAmount),
                    TransactionDate = GenerateRandomDate(random, startDate, endDate)
                };

                transactions.Add(transaction);
            }

            return transactions;
        }

        static decimal GenerateRandomAmount(Random random, decimal min, decimal max)
        {
            return (decimal)Math.Round(random.NextDouble() * ((double)max - (double)min) + (double)min, 2);
        }


        static DateTime GenerateRandomDate(Random random, DateTime startDate, DateTime endDate)
        {
            int range = (endDate - startDate).Days;
            DateTime randomDate = startDate.AddDays(random.Next(range));

            // Добавляем случайное время (часы, минуты, секунды)
            int hours = random.Next(0, 24);
            int minutes = random.Next(0, 60);
            int seconds = random.Next(0, 60);

            return randomDate.AddHours(hours).AddMinutes(minutes).AddSeconds(seconds);
        }

        static void SaveTransactionsToCsv(List<Transaction> transactions, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // Записываем заголовки
                writer.WriteLine("Id,Amount,TransactionDate");

                // Записываем транзакции
                foreach (var transaction in transactions)
                {
                    writer.WriteLine($"{transaction.Id},{transaction.Amount.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)},{transaction.TransactionDate:yyyy-MM-dd HH:mm:ss}");

                }
            }

            Console.WriteLine($"Transactions saved to {filePath}");
        }
    }
}
*/