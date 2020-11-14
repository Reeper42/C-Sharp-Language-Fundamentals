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
            Exercise31();
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
            PrintProductInformation(products);
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
            var OutOfStockProduct = from p in DataLoader.LoadProducts()
                                    where p.UnitsInStock == 0
                                    select p;
            PrintProductInformation(OutOfStockProduct);
                                    
        }

        /// <summary>
        /// Print all products that are in stock and cost more than 3.00 per unit.
        /// </summary>
        static void Exercise2()
        {
            var Product = from p in DataLoader.LoadProducts()
                          where p.UnitPrice > 3.00M && p.UnitsInStock > 0
                          select p;

            PrintProductInformation(Product);
        }

        /// <summary>
        /// Print all customer and their order information for the Washington (WA) region.
        /// </summary>
        static void Exercise3()
        {
            var WashingtonCustomer = from c in DataLoader.LoadCustomers()
                                     where c.Region == "WA"
                                     select c;

            PrintCustomerInformation(WashingtonCustomer);
        }

        /// <summary>
        /// Create and print an anonymous type with just the ProductName
        /// </summary>
        static void Exercise4()
        {
            var AnonProducts = from pName in DataLoader.LoadProducts()
                               select new
                               {
                                   ProductName = pName.ProductName
                               };

            foreach (var p in AnonProducts)
            {
                Console.WriteLine(p);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all product information but increase the unit price by 25%
        /// </summary>
        static void Exercise5()
        {
            var IncreaseProduct = from p in DataLoader.LoadProducts()
                                  select new
                                  {
                                      PId = p.ProductID,
                                      PName = p.ProductName,
                                      PCategory = p.Category,
                                      IncreasedPrice = p.UnitPrice * 1.25M,
                                      PUnits = p.UnitsInStock
                                  };

            foreach (var p in IncreaseProduct)
            {
                Console.WriteLine(p);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
        /// </summary>
        static void Exercise6()
        {
            var AnonProduct = from p in DataLoader.LoadProducts()
                              select new
                              {
                                  ProductName = p.ProductName,
                                  Category = p.Category
                              };

            foreach (var p in AnonProduct)
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
            var AnonProductInfo = from p in DataLoader.LoadProducts()
                                  select new
                                  {
                                      ProductId = p.ProductID,
                                      PName = p.ProductName,
                                      Category = p.Category,
                                      UPrice = p.UnitPrice,
                                      UInStock = p.UnitsInStock,
                                      ReOrder = p.UnitsInStock < 3 ? true : false
                                  };

            foreach (var p in AnonProductInfo)
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
            var StockValue = from p in DataLoader.LoadProducts()
                             select new
                             {
                                 ProductId = p.ProductID,
                                 PName = p.ProductName,
                                 Category = p.Category,
                                 UPrice = p.UnitPrice,
                                 UInStock = p.UnitsInStock,
                                 StockValue = p.UnitPrice * p.UnitsInStock
                             };

            foreach (var p in StockValue)
            {
                Console.WriteLine(p);
            }
        }

        /// <summary>
        /// Print only the even numbers in NumbersA
        /// </summary>
        static void Exercise9()
        {
            var EvenNums = from n in DataLoader.NumbersA
                           where n % 2 == 0
                           select n;

            foreach (var n in EvenNums)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Print only customers that have an order whos total is less than $500
        /// </summary>
        static void Exercise10()
        {
            var Customers = (from c in DataLoader.LoadCustomers()
                             from o in c.Orders
                             where o.Total < 500M
                             select c);

            foreach (var c in Customers)
            {
                Console.WriteLine(c);
            };

        }

        /// <summary>
        /// Print only the first 3 odd numbers from NumbersC
        /// </summary>
        static void Exercise11()
        {
            var oddNumbers = DataLoader.NumbersC.Where(n => n%2 == 1).Take(3);

            foreach (var odd in oddNumbers)
            {
                Console.WriteLine(odd);
            }
        }

        /// <summary>
        /// Print the numbers from NumbersB except the first 3
        /// </summary>
        static void Exercise12()
        {
            var numbers = DataLoader.NumbersB.Skip(3);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Print the Company Name and most recent order for each customer in Washington
        /// </summary>
        static void Exercise13()
        {
            var WACustomers = from c in DataLoader.LoadCustomers()
                              where c.Region == "WA"
                              select c;

            foreach (var c in WACustomers)
            {
                Console.WriteLine(c.CompanyName);

                var mostRecentOrder = (from o in WACustomers
                                       from dates in o.Orders
                                       orderby dates.OrderDate descending
                                       select dates).Take(1);

                foreach (var o in mostRecentOrder)
                {
                    Console.WriteLine("OrderId: {0} Order Date: {1} Order Total: {2:c}\n", o.OrderID, o.OrderDate, o.Total );
                }
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC until a number is >= 6
        /// </summary>
        static void Exercise14()
        {
            var numbers = DataLoader.NumbersC;
            var filteredNums = numbers.TakeWhile(n => n <= 6); //why did we do n <=6 before?

            foreach (var n in filteredNums)
            {
                Console.WriteLine(n);
            }

        }

        /// <summary>
        /// Print all the numbers in NumbersC that come after the first number divisible by 3
        /// </summary>
        static void Exercise15()
        {
            var numbers = DataLoader.NumbersC;

            var result = numbers.SkipWhile(n => n % 3 > 0).Skip(1);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        /// <summary>
        /// Print the products alphabetically by name
        /// </summary>
        static void Exercise16()
        {
            var products = DataLoader.LoadProducts().OrderBy(p => p.ProductName);
            foreach (var p in products)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        /// <summary>
        /// Print the products in descending order by units in stock
        /// </summary>
        static void Exercise17()
        {
            var products = DataLoader.LoadProducts();
            var result = products.OrderByDescending(p => p.UnitsInStock);
            PrintProductInformation(result);
        }

        /// <summary>
        /// Print the list of products ordered first by category, then by unit price, from highest to lowest.
        /// </summary>
        static void Exercise18()
        {
            var product = DataLoader.LoadProducts().OrderBy(p => p.Category).ThenByDescending(u => u.UnitPrice); 
            PrintProductInformation(product);
        }

        /// <summary>
        /// Print NumbersB in reverse order
        /// </summary>
        static void Exercise19()
        {
            var numbers = DataLoader.NumbersB;
            var reverseNumbers = numbers.Reverse(); 
            foreach (var n in reverseNumbers)
            {
                Console.WriteLine(n);
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
            var groupedProducts = products.GroupBy(p => p.Category);
            foreach (var c in groupedProducts)
            {
                Console.WriteLine("\n{0}: \n",c.Key);
                Console.WriteLine("---------------------");
                foreach (var p in c)
                {
                    Console.WriteLine(p.ProductName);
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

            foreach (var c in customers)
            {
                Console.WriteLine(c.CompanyName);
                Console.WriteLine("--------------------------------------------");

                var groupedOrdersYear = c.Orders.GroupBy(y => y.OrderDate.Year);
                foreach (var y in groupedOrdersYear)
                {
                    Console.WriteLine(y.Key);

                    var groupedOrdersMonth = y.GroupBy(m => m.OrderDate.Month);
                    foreach (var m in groupedOrdersMonth)
                    {
                        var orderSum = m.Sum(s => s.Total);
                        Console.WriteLine("\t {0} - {1:C}",m.Key, orderSum );
                        Console.WriteLine(); //I would be interested in discussing alternatives to this solution
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
            var productCategories = products.GroupBy(c => c.Category);
            foreach (var c in productCategories)
            {
                Console.WriteLine(c.Key); //Was that all I needed to do?
            }
        }

        /// <summary>
        /// Write code to check to see if Product 789 exists
        /// </summary>
        static void Exercise23()
        {
            var products = DataLoader.LoadProducts();
            var doesExist = (from p in products
                             select p.ProductID).Contains(789);

            if (doesExist == true)
            {
                Console.WriteLine("Product 789 exist!");
            }
            else Console.WriteLine("Product 789 does not exist!");
            Console.WriteLine();

        }

        /// <summary>
        /// Print a list of categories that have at least one product out of stock
        /// </summary>
        static void Exercise24()
        {
            var products = DataLoader.LoadProducts();
            var productList = from p in products
                              where p.UnitsInStock == 0
                              group p by p.Category;

            foreach (var c in productList)
            {
                Console.WriteLine(c.Key); //The last time I did this I used method syntax and got multiples in my list. I want to discuss how I did not get the same result.
            }// nevermind I didn't group them last time.
                              
                              
        }

        /// <summary>
        /// Print a list of categories that have no products out of stock
        /// </summary>
        static void Exercise25()//Should exclude condiments, diary products, meat/poultry
        {
            var products = DataLoader.LoadProducts();
            var categoryList = products.GroupBy(c => c.Category);
            foreach (var c in categoryList)
            {
                if(c.All(u => u.UnitsInStock != 0))
                {
                    Console.WriteLine(c.Key);
                }
                    
            }
        }

        /// <summary>
        /// Count the number of odd numbers in NumbersA
        /// </summary>
        static void Exercise26()
        {
            var numbers = DataLoader.NumbersA;
            var oddCount = numbers.Where(o => o % 2 == 1);
            Console.WriteLine("There are {0} odd numbers ", oddCount.Count());
        }

        /// <summary>
        /// Create and print an anonymous type containing CustomerId and the count of their orders
        /// </summary>
        static void Exercise27()
        {
            var anonCustomer = from c in DataLoader.LoadCustomers()
                               select new
                               {
                                   CustomerId = c.CustomerID,
                                   OrderCount = c.Orders.Count()
                               };

            foreach (var c in anonCustomer)
            {
                Console.WriteLine("CustomerId: {0} \n Total Orders: {1} ", c.CustomerId,c.OrderCount);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the count of the products they contain
        /// </summary>
        static void Exercise28()
        {
            var product = DataLoader.LoadProducts();
            var distinctList = product.GroupBy(p => p.Category, p => p.ProductName, (Category, ProductName) => new
            {
                Category,
                ProductCount = ProductName.Count()
            });

            Console.WriteLine("{0,-20}{1,-15}", "Category", "Product Count");
            foreach (var c in distinctList)
            {
                Console.WriteLine("{0,-20}{1,-15}", c.Category,c.ProductCount);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print a distinct list of product categories and the total units in stock
        /// </summary>
        static void Exercise29()
        {
            var product = DataLoader.LoadProducts();
            var distinctList = product.GroupBy(c => c.Category, c => c.UnitsInStock, (Category, Units) => new
            {
                Category,
                Units = Units.Sum()
            });

            Console.WriteLine("{0,-20}{1,-15}", "Category", "Units in Stock");
            Console.WriteLine("------------------------------------------------");
            foreach (var c in distinctList)
            {
                Console.WriteLine("{0,-20}{1,-15}", c.Category, c.Units);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print a distinct list of product categories and the lowest priced product in that category
        /// </summary>
        static void Exercise30()
        {
            var product = DataLoader.LoadProducts();
            var distinctList = product.GroupBy(c => c.Category, p => p, (Category, CheapProduct) => new
            {
                Category,
                CheapProduct = CheapProduct.OrderBy(p => p.UnitPrice).Take(1)
            });

            Console.WriteLine("{0,-20}{1,-30}{2,-50}", "Category", "Lowest Priced Item", "Price");
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var c in distinctList)
            {
                foreach (var p in c.CheapProduct)
                {
                    Console.WriteLine("{0,-20}{1,-30}{2,-15:c}", c.Category, p.ProductName, p.UnitPrice );
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print the top 3 categories by the average unit price of their products
        /// </summary>
        static void Exercise31()
        {
            var product = DataLoader.LoadProducts();
            var topThree = product.GroupBy(c => c.Category, p => p, (Category, Product) => new
            {
                Category,
                AveragePrice = Product.Average(p => p.UnitPrice)
            }).OrderByDescending(p => p.AveragePrice).Take(3);
            Console.WriteLine("{0,-20}{1,-20}","Product","Average");
            Console.WriteLine("--------------------------------------");
            foreach (var c in topThree)
            {
                Console.WriteLine("{0,-20}{1,-20:c}", c.Category, c.AveragePrice);
            }
        }
    }
}
