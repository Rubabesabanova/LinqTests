using System;
using System.Collections.Generic;
using System.Linq;

namespace LingTests
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            Console.WriteLine("Task 1");
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            Func<int, bool> EvenMoreThanThirty = delegate (int i) { return i % 2 == 0 && i > 30; };
            var result1 = numbers.Where(EvenMoreThanThirty);
            foreach (var number in result1)
            {
                Console.Write($"{number} ");
            }

            #endregion

            #region task 2
            Console.WriteLine("\n");
            Console.WriteLine("Task 2");
            List<User> users = new List<User>();
            users.Add(new User { Name = "Asim", Age = 20 });
            users.Add(new User { Name = "Aygun", Age = 25 });

            var result2 = users.Select(x => x.Name);
            foreach (var name in result2)
            {
                Console.Write($"{name} ");
            }
            #endregion

            #region task 3
            Console.WriteLine("\n");
            Console.WriteLine("Task 3");
            List<User> users1 = new List<User>();
            users1.Add(new User { Name = "Asim", Age = 20 });
            users1.Add(new User { Name = "Aygun", Age = 25 });

            var result3 = users.Select(x => new { Name = x.Name, Date = DateTime.Now.Year - x.Age });
            foreach (var x in result3)
            {
                Console.Write($"{x.Name} - {x.Date} ");
            }
            #endregion

            #region task 4
            Console.WriteLine("\n");
            Console.WriteLine("Task 4");
            int[] numbers1 = { 3, 12, 4, 10, 34, 20, 55, -66, 77, 88, 4 };

            var result4 = numbers1.OrderBy(x => x);
            foreach (var x in result4)
            {
                Console.Write($"{x}  ");
            }
            #endregion

            #region task 5
            Console.WriteLine("\n");
            Console.WriteLine("Task 5");
            string[] languages = { "C#", "PLSQL", "MySQL" };
            string[] companies = { "Microsoft", "Oracle", "PHP" };

            var result5 = languages.Union(companies);
            foreach (var x in result5)
            {
                Console.WriteLine($"{x}\n");
            }
            #endregion

            #region task 6
            Console.WriteLine("\n");
            Console.WriteLine("Task 6");
            List<Category> categories = new List<Category>()
            {
                new Category{ Name = "Milk", Country ="Belorussia" },
                new Category{ Name = "Juice", Country ="Poland" }
            };
            List<Product> products = new List<Product>()
            {
                new Product{Name="Yoghurt", Category ="Milk"},
                new Product{Name="Cheese", Category ="Milk"},
                new Product{Name="Fruktoviy sad", Category ="Juice"}
            };

            var result6 = from p in products
                          join c in categories
                          on p.Category equals c.Name
                          select new { p.Name, p.Category, c.Country};
            foreach (var x in result6)
            {
                Console.WriteLine($"{x.Name} - {x.Category} ({x.Country})\n");
            }
            #endregion
        }
    }
}
