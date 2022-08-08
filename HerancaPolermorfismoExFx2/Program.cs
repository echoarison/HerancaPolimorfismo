using System;
using System.Collections.Generic;
using HerancaPolermorfismoExFx2.Entities;
using System.Globalization;

namespace HerancaPolermorfismoExFx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazendo uma list de produtos
            List<Product> list = new List<Product>();

            /*Pegando os dados*/
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            //fazendo o loop para o numeros de products add
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product {i + 1} data:"); //usando interploração
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //fazendo um verificação e add list
                if (ch == 'c' || ch == 'C')
                {
                    //add common Product
                    list.Add(new Product(name, price));
                }
                else if (ch == 'i' || ch == 'I')
                {

                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    //add common ImortedProduct(usando Upcasting)
                    list.Add(new ImportedProduct(name, price, customFee));

                }
                else
                {
                 
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manuFactureDate = DateTime.Parse(Console.ReadLine());

                    //add common UsedProduct(usando Upcasting)
                    list.Add(new UsedProduct(name, price, manuFactureDate));

                }

                Console.WriteLine();
            }

            Console.WriteLine();

            //exibir os dados
            Console.WriteLine("PRICE TAGS: ");

            /*Acessando a lista produtos*/
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }

        }
    }
}
