using System;
using System.Linq;
using VisualStudioToolboxEFCPart1.Data;
using VisualStudioToolboxEFCPart1.Models;


//https://docs.microsoft.com/en-us/shows/entity-framework-core-101/getting-started-with-entity-framework-core

namespace VisualStudioToolboxEFCPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context context = new Context();

            var squeakyBone = context.Products.Where(x => x.Name == "Squeky Dog Bone").FirstOrDefault();

            if (squeakyBone is Product)
            {
                squeakyBone.Name = "Squeaky Dog Bone";
                squeakyBone.Price = 7.99m;

                //context.Remove(squeakyBone);
            }
            context.SaveChanges();



            var products = context.Products.Where(x => x.Price >= 5).OrderBy(x => x.Name);

            foreach (var e in products)
            {
                Console.WriteLine($"Id:     {e.Id}");
                Console.WriteLine($"Name:   {e.Name}");
                Console.WriteLine($"Price:  {e.Price}");
                Console.WriteLine(new string('-',70));

            }


            //Product squekyBone = new Product()
            //{
            //    Name = "Squeky Dog Bone",
            //    Price = 4.99m
            //};
            //context.Add(squekyBone);

            //Product tennisBalls = new Product()
            //{
            //    Name = "Tennis Ball 3-Pack",
            //    Price = 9.99m
            //};
            //context.Add(tennisBalls);


            //context.SaveChanges();

        }
    }
}
