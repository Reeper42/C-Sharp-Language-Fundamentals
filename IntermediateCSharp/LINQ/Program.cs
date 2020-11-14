using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            
            //PrintAllProducts();
            //PrintAllCustomers();
            //Exercise25();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        #region "Sample Code"
        /// <summary>
        /// Sample, load and print all the product objects
        /// </summary>
        static void PrintAllProducts()
        {
            List<Product> products = DataLoader.LoadProducts();
            PrintProductInformation(products.OrderBy(c => c.Category).ThenBy(u => u.UnitsInStock));
        }

        /// <summary>
        /// This will print a nicely formatted list of products
        /// </summary>
        /// <param name="products">The collection of products to print</param>
        static void PrintProductInformation(IEnumerable<Product> products)
        {
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }

        }

        /// <summary>
        /// Sample, load and print all the customer objects and their orders
        /// </summary>
        static void PrintAllCustomers()
        {
            var customers = DataLoader.LoadCustomers();
            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// This will print a nicely formated list of customers
        /// </summary>
        /// <param name="customers">The collection of customer objects to print</param>
        static void PrintCustomerInformation(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine(customer.Address);
                Console.WriteLine("{0}, {1} {2} {3}", customer.City, customer.Region, customer.PostalCode, customer.Country);
                Console.WriteLine("p:{0} f:{1}", customer.Phone, customer.Fax);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }
        #endregion

        /// <summary>
        /// Print all products that are out of stock.
        /// </summary>
        static void Exercise1()
        {
            //List<Product> products = new List<Product>();

            var outOfStockproduct = from stock in DataLoader.LoadProducts() where stock.UnitsInStock.Equals(0) select stock;
            PrintProductInformation(outOfStockproduct); 
        }

        /// <summary>
        /// Print all products that are in stock and cost more than 3.00 per unit.
        /// </summary>
        static void Exercise2()
        {
            var stockLessThanThreeUnits = from stock in DataLoader.LoadProducts()
                                          where stock.UnitsInStock > 0 && stock.UnitPrice >= 3.00M
                                          select stock;
            PrintProductInformation(stockLessThanThreeUnits);
        }

        /// <summary>
        /// Print all customer and their order information for the Washington (WA) region.
        /// </summary>
        static void Exercise3()
        {
            var washingtonCustomers = from customer in DataLoader.LoadCustomers()
                                      where customer.Region == "WA"
                                      select customer;
            PrintCustomerInformation(washingtonCustomers);
                                    
        }

        /// <summary>
        /// Create and print an anonymous type with just the ProductName
        /// </summary>
        static void Exercise4()
        {
            var productName = from product in DataLoader.LoadProducts()
                              select new
                              {
                                  productName = product.ProductName
                              };

            foreach(var product in productName)
            {
                Console.WriteLine(product); //How should this look in the console? It printed the info but I'm unsure how to format.
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all product information but increase the unit price by 25%
        /// </summary>
        static void Exercise5()
        {
            var productInfo = from p in DataLoader.LoadProducts()
                              select new { productInfo = p.ProductID, p.ProductID, p.Category, UnitPrice = p.UnitPrice * 1.25M, p.UnitsInStock };

            foreach(var p in productInfo)
            {
                Console.WriteLine(p);   //I'm unsure how to increase the unit price.
            }
        }

        /// <summary>
        /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
        /// </summary>
        static void Exercise6()
        {
            var productName = from p in DataLoader.LoadProducts()
                              select new { p.ProductName, p.Category };

            foreach(var p in productName)
            {
                Console.WriteLine(p.ToString().ToUpper());
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra bool property ReOrder which should 
        /// be set to true if the Units in Stock is less than 3
        /// 
        /// Hint: use a ternary expression
        /// </summary>
        static void Exercise7()
        {
            var productReOrder = from p in DataLoader.LoadProducts()
                                     //where p.UnitsInStock < 3 ? true : false 
                                 select new
                                 {
                                     p.ProductID,
                                     p.ProductName,
                                     p.Category,
                                     p.UnitPrice,
                                     p.UnitsInStock,
                                     ReOrder = p.UnitsInStock < 3 ? true : false
                                 };

            foreach(var p in productReOrder)
            {
                Console.WriteLine(p);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra decimal called 
        /// StockValue which should be the product of unit price and units in stock
        /// </summary>
        static void Exercise8()
        {
            var stockValue = from p in DataLoader.LoadProducts()
                             select new
                             {
                                 p.ProductID,
                                 p.ProductName,
                                 p.Category,
                                 p.UnitPrice,
                                 p.UnitsInStock,
                                 StockValue = p.UnitPrice * p.UnitsInStock
                             };

            foreach (var p in stockValue)
            {
                Console.WriteLine(p);
            }
        }

        /// <summary>
        /// Print only the even numbers in NumbersA
        /// </summary>
        static void Exercise9()
        {
            var onlyEvens = from n in DataLoader.NumbersA
                            where n % 2 == 0
                            select n;

            foreach(var even in onlyEvens)
            {
                Console.WriteLine(even);
            }
        }

        /// <summary>
        /// Print only customers that have an order whos total is less than $500
        /// </summary>
        static void Exercise10()
        {
            var customer = DataLoader.LoadCustomers();
            var foundCutomers = (from c in DataLoader.LoadCustomers()
                                from o in c.Orders
                                where o.Total < 500M
                                select c).AsEnumerable();
            PrintCustomerInformation(foundCutomers); //prints multiples of customer info. 
                           

            //How do I access the orders? https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations

        }

        /// <summary>
        /// Print only the first 3 odd numbers from NumbersC
        /// </summary>
        static void Exercise11()
        {
            var oddNumbers = (from number in DataLoader.NumbersC
                              where number % 2 == 1
                              select number).Take(3);

            foreach(var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Print the numbers from NumbersB except the first 3
        /// </summary>
        static void Exercise12()
        {
            var number = (from n in DataLoader.NumbersB
                          select n).Skip(3);
            foreach(var n in number)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Print the Company Name and most recent order for each customer in Washington
        /// </summary>
        static void Exercise13()
        {
            var customersInWA = DataLoader.LoadCustomers().Where(c => c.Region == "WA");

            foreach (var customer in customersInWA)
            {
                Console.WriteLine(customer.CompanyName);

                var mostRecentOrder = customer.Orders.OrderByDescending(r => r.OrderDate).Take(1);

                foreach (var order in mostRecentOrder)
                {
                    Console.WriteLine("OrderID: {0} Order Date: {1} Order Total {2:c}", order.OrderID, order.OrderDate, order.Total);
                }
            }                   
        }

        /// <summary>
        /// Print all the numbers in NumbersC until a number is >= 6
        /// </summary>
        static void Exercise14()
        {
            var numbers = DataLoader.NumbersC;

            var filteredNumbers = numbers.TakeWhile(n => n <= 6);

            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC that come after the first number divisible by 3
        /// </summary>
        static void Exercise15()
        {
            var numbers = DataLoader.NumbersC;

            var filterdNumbers = numbers.SkipWhile(n => n % 3 > 0).Skip(1);

            foreach (var number in filterdNumbers)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Print the products alphabetically by name
        /// </summary>
        static void Exercise16()
        {
            var product = from p in DataLoader.LoadProducts()
                          orderby p.ProductName
                          select p;

            foreach (var p in product)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        /// <summary>
        /// Print the products in descending order by units in stock
        /// </summary>
        static void Exercise17()
        {
            var unitsInStock = from p in DataLoader.LoadProducts()
                               orderby p.UnitsInStock descending
                               select p;
            PrintProductInformation(unitsInStock);
            //foreach (var p in unitsInStock)
            //{
            //    Console.WriteLine(p);
            //}
        }

        /// <summary>
        /// Print the list of products ordered first by category, then by unit price, from highest to lowest.
        /// </summary>
        static void Exercise18()
        {
            var products = DataLoader.LoadProducts();

            var organizedList = products.OrderBy(p => p.Category).ThenBy(p => p.UnitPrice);

            PrintProductInformation(organizedList);
            //foreach (var product in organizedList)
            //{
            //    Console.WriteLine("Product Category: {0} Product Name: {1} Unit Price: {2}", product.Category, product.ProductName, product.UnitPrice);
            //}      
                               
            //foreach (var product in productCategory)
            //{                
            //    var productUnitPrice = 0;
            //}

            //var productCategory = products.OrderBy(p => p.Category);

            //foreach (var product in productCategory)
            //{               
            //    var productUnitPrice = products.OrderBy(p => p.UnitPrice);
            //    foreach (var productPrice in productUnitPrice)
            //    {
            //        Console.WriteLine();
            //    }
            //}
        }

        /// <summary>
        /// Print NumbersB in reverse order
        /// </summary>
        static void Exercise19()
        {
            var numbersReversed = DataLoader.NumbersB.Reverse();

            foreach (var number in numbersReversed)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Group products by category, then print each category name and its products
        /// ex:
        /// 
        /// Beverages
        /// Tea
        /// Coffee
        /// 
        /// Sandwiches
        /// Turkey
        /// Ham
        /// </summary>
        static void Exercise20()
        {
            var products = DataLoader.LoadProducts();

            var groupedProducts = from p in products
                                  group p by p.Category;

            foreach (var group in groupedProducts)
            {
                Console.WriteLine(group.Key);

                foreach (var product in group)
                {
                    Console.WriteLine("\t{0}", product.ProductName);
                }
            }                                  
        }

        /// <summary>
        /// Print all Customers with their orders by Year then Month
        /// ex:
        /// 
        /// Joe's Diner
        /// 2015
        ///     1 -  $500.00
        ///     3 -  $750.00
        /// 2016
        ///     2 - $1000.00
        /// </summary>
        static void Exercise21()
        {
            var customers = DataLoader.LoadCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine("---------------------------------------");

                var ordersByYear = from order in customer.Orders
                                   group order by order.OrderDate.Year;

                foreach (var order in ordersByYear)
                {
                    Console.WriteLine(order.Key);

                    var ordersByMonth = from order1 in order
                                        group order1 by order1.OrderDate.Month;

                    foreach (var o in ordersByMonth)
                    {
                        var monthsum = o.Sum(x => x.Total);

                        Console.WriteLine("{0}" + "-" + "{1:c}", o.Key, monthsum);

                        Console.WriteLine();
                    }
                }
            }
        
        }

        /// <summary>
        /// Print the unique list of product categories
        /// </summary>
        static void Exercise22()
        {
            var products = DataLoader.LoadProducts();

            var productCategories = from p in products
                                    orderby p.Category
                                    group p by p.Category;

            foreach (var product in productCategories)
            {
                Console.WriteLine(product.Key);
            }
        }

        /// <summary>
        /// Write code to check to see if Product 789 exists
        /// </summary>
        static void Exercise23()
        {
            var productExist = DataLoader.LoadProducts().Select(p => p.ProductID).Contains(789);

            if(productExist == true)
            {
                Console.WriteLine("Product 789 exist");
            }
            else
            {
                Console.WriteLine("Product 789 does not exist");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print a list of categories that have at least one product out of stock
        /// </summary>
        static void Exercise24()
        {
            var categories = DataLoader.LoadProducts();

            var categoriesOutofStock = categories.Where(c => c.UnitsInStock < 1);

            foreach (var c in categoriesOutofStock)
            {
                Console.WriteLine(c.Category); //do I use distinct to get rid of multiples?
            }
        }

        /// <summary>
        /// Print a list of categories that have no products out of stock
        /// </summary>
        static void Exercise25()
        {
            var productCategories = DataLoader.LoadProducts();

            var noProductsOutOfStock = productCategories.Where(p => p.UnitsInStock > 0);            

            foreach (var c in noProductsOutOfStock)
            {
                Console.WriteLine(c.Category);                  
            }
        }

        /// <summary>
        /// Count the number of odd numbers in NumbersA
        /// </summary>
        static void Exercise26()
        {
            var oddNumbers = DataLoader.NumbersA.Where(n => n % 2 == 1).Count();
            Console.WriteLine("There are {0} odd numbers ", oddNumbers);            
        }

        /// <summary>
        /// Create and print an anonymous type containing CustomerId and the count of their orders
        /// </summary>
        static void Exercise27()
        {
            var customer = DataLoader.LoadCustomers();
            var custIdAndOrderTotal = from c in customer
                                      orderby c.CustomerID
                                      select new
                                      {
                                          CustomerID = c.CustomerID,
                                          HowManyOrders = c.Orders.Count()
                                      };

            foreach (var c in custIdAndOrderTotal)
            {
                Console.WriteLine("Customer: {0} has {1} orders. ", c.CustomerID, c.HowManyOrders);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the count of the products they contain
        /// </summary>
        static void Exercise28()
        {
            var products = DataLoader.LoadProducts();

            var productCategoryCount = products.GroupBy(p => p.Category, p => p.ProductName, (Category, ProductName) => new
            {
                Category,
                ProductCount = ProductName.Count()
            });

            Console.WriteLine("{0, -20}{1, -15}", "Category", "ProductCount");

            foreach (var c in productCategoryCount)
            {
                Console.WriteLine("{0, -20}{1, -15}", c.Category, c.ProductCount);
            }
            Console.WriteLine();
                                      
        }

        /// <summary>
        /// Print a distinct list of product categories and the total units in stock
        /// </summary>
        static void Exercise29()
        {
            var products = DataLoader.LoadProducts();
            var unitsInStock = products.GroupBy(p => p.Category, p => p.UnitsInStock, (Category, StockAmount) => new
            {
                Category,
                StockAmount = StockAmount.Sum()
            });

            Console.WriteLine("{0,-20}{1,-15}","Category", "StockAmount" );

            foreach (var c in unitsInStock)
            {
                Console.WriteLine("{0, -20}{1,-15}", c.Category, c.StockAmount);
            }
            Console.WriteLine();
                               
                               
                               
        }

        /// <summary>
        /// Print a distinct list of product categories and the lowest priced product in that category
        /// </summary>
        static void Exercise30()
        {
            var products = DataLoader.LoadProducts();

            var lowestPricedProduct = products.GroupBy(p => p.Category, p => p, (Category, Products) => new
            {
                Category,
                LowestPrice = Products.OrderBy(p => p.UnitPrice).Take(1)
            });

            foreach (var c in lowestPricedProduct)
            {
                foreach (var p in c.LowestPrice)
                {
                    Console.WriteLine("{0}: {1}: {2:C}", c.Category, p.ProductName, p.UnitPrice);
                }                
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print the top 3 categories by the average unit price of their products
        /// </summary>
        static void Exercise31()
        {
            var products = DataLoader.LoadProducts();

            var top3CategoriesByPrice = products.GroupBy(p => p.Category, p => p, (Category, Products) => new
            {
                Category,
                AveragePrice = Products.Average(p => p.UnitPrice)
            }).OrderByDescending(p => p.AveragePrice).Take(3);

            foreach (var c in top3CategoriesByPrice)
            {
                Console.WriteLine("{0}{1:C}", c.Category, c.AveragePrice);
            }
        }
    }
}
