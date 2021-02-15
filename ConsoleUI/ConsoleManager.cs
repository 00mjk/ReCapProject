using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class ConsoleManager : IConsoleService
    {
        public void GetAllBrands(List<Brand> brands)
        {
            Console.WriteLine("================================================");
            foreach (var brand in brands)
            {
                Console.WriteLine($"{brand.BrandId} {brand.BrandName}");
            }
        }

        public void GetMenus(string[] menus)
        {
            for (int i = 0; i < menus.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menus[i]}");
            }
        }
    }
}
