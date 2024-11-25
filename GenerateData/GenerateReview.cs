/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PLEER.GenerateData
{

    class Program
    {
        static void Main()
        {
            int totalCustomers = 100000;
            int totalProducts = 519;

            // 80% клиентов оставляют отзывы
            var customersWithReviews = GenerateRandomIds(totalCustomers, (int)(totalCustomers * 0.8));

            // 95% товаров имеют отзывы
            var productsWithReviews = GenerateRandomIds(totalProducts, (int)(totalProducts * 0.95));

            Random random = new Random();
            List<Review> reviews = new List<Review>();

            foreach (var customerId in customersWithReviews)
            {
                // Каждый клиент оставляет 1-3 отзыва
                int reviewCount = random.Next(1, 4);

                for (int i = 0; i < reviewCount; i++)
                {
                    int productId = productsWithReviews[random.Next(productsWithReviews.Count)];
                    int rating = GenerateRating(random);
                    DateTime reviewDate = GenerateRandomDate(random, DateTime.Now.AddYears(-1), DateTime.Now);

                    reviews.Add(new Review
                    {
                        Id = reviews.Count + 1,
                        CustomerId = customerId,
                        ProductId = productId,
                        Rating = rating,
                        ReviewDate = reviewDate
                    });
                }
            }

            Console.WriteLine($"Generated {reviews.Count} reviews.");

            // Сохранение в CSV
            SaveReviewsToCsv(reviews, "reviews.csv");
        }

        static List<int> GenerateRandomIds(int maxId, int count)
        {
            Random random = new Random();
            return Enumerable.Range(1, maxId).OrderBy(x => random.Next()).Take(count).ToList();
        }

        static int GenerateRating(Random random)
        {
            // 80% 4-5, 20% 1-3
            return random.NextDouble() <= 0.8 ? random.Next(4, 6) : random.Next(1, 4);
        }

        static DateTime GenerateRandomDate(Random random, DateTime startDate, DateTime endDate)
        {
            int rangeDays = (endDate - startDate).Days;
            DateTime randomDate = startDate.AddDays(random.Next(rangeDays));

            // Добавляем случайные часы, минуты и секунды
            int hours = random.Next(0, 24); // Часы от 0 до 23
            int minutes = random.Next(0, 60); // Минуты от 0 до 59
            int seconds = random.Next(0, 60); // Секунды от 0 до 59

            return randomDate.AddHours(hours).AddMinutes(minutes).AddSeconds(seconds);
        }


        static void SaveReviewsToCsv(List<Review> reviews, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // Записываем заголовки
                writer.WriteLine("Id,CustomerId,ProductId,Rating,ReviewDate");

                // Записываем данные
                foreach (var review in reviews)
                {
                    writer.WriteLine($"{review.Id},{review.CustomerId},{review.ProductId},{review.Rating},{review.ReviewDate:yyyy-MM-dd HH:mm:ss}");
                }
            }

            Console.WriteLine($"Reviews saved to {filePath}");
        }

    }
}

*/