/*using System;
using System.Collections.Generic;
using System.IO;
using Bogus;
using CsvHelper;

namespace PLEER.GenerateData
{
    class Program
    {
        static void Main()
        {
            int totalCarts = 100000;  // Общее количество корзин
            int totalProducts = 519;  // Общее количество продуктов
            double emptyCartProbability = 0.6;  // 60% корзин будут пустыми

            var cartProducts = GenerateCartProducts(totalCarts, totalProducts, emptyCartProbability);

            // Указываем путь для файла
            string filePath = "cart_products.csv";

            // Генерация и запись данных в CSV файл
            WriteCartProductsToCsv(filePath, cartProducts);
        }

        // Генерация записей для таблицы CartProduct
        static List<CartProduct> GenerateCartProducts(int totalCarts, int totalProducts, double emptyCartProbability)
        {
            var random = new Random();
            var cartProducts = new List<CartProduct>();

            for (int cartId = 1; cartId <= totalCarts; cartId++)
            {
                // Решаем, будет ли корзина пустой (60% шанс пустой корзины)
                bool isCartEmpty = random.NextDouble() < emptyCartProbability;

                // Если корзина не пустая, добавляем товары
                if (!isCartEmpty)
                {
                    int numberOfProducts = random.Next(1, 6);  // Количество товаров в корзине от 1 до 5

                    for (int i = 0; i < numberOfProducts; i++)
                    {
                        var cartProduct = new CartProduct
                        {
                            Id = cartProducts.Count + 1,  // Уникальный идентификатор записи
                            CartId = cartId,              // Идентификатор корзины
                            ProductId = random.Next(1, totalProducts + 1) // Случайный ProductId от 1 до totalProducts
                        };

                        cartProducts.Add(cartProduct);
                    }
                }
            }

            return cartProducts;
        }

        // Метод для записи данных о товарах в корзинах в CSV файл
        static void WriteCartProductsToCsv(string filePath, List<CartProduct> cartProducts)
        {
            using (var writer = new StreamWriter(filePath))
            {
                // Запись заголовка
                writer.WriteLine("Id,CartId,ProductId");

                // Запись данных о каждом товаре в корзине
                foreach (var cartProduct in cartProducts)
                {
                    writer.WriteLine($"{cartProduct.Id},{cartProduct.CartId},{cartProduct.ProductId}");
                }

                Console.WriteLine($"Данные успешно записаны в файл: {filePath}");
            }
        }
    }

}
*/