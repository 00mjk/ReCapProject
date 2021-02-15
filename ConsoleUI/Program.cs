using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.CarContext;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            UserManager userManager = new UserManager(new EfUserDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            IConsoleService consoleService = new ConsoleManager();
            IBrandService brandService = new BrandManager(new EfBrandDal());
            ICarService carService = new CarManager(new EfCarDal());


            var menus = new string[]{
               "Marka ekle" ,"Markaları Listele"
            };
            string input;
            while (true)
            {
                consoleService.GetMenus(menus);
                Console.Write("Seçiminiz.");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Lütfen Marka adını girin:");
                        brandManager.Add(new Brand
                        {
                            BrandName = Console.ReadLine()

                        });

                        break;
                        //case "2":
                        //    Console.Clear();
                        //    foreach (var car in )
                        //    {
                        //        Console.WriteLine();
                        //    }
                        //    break;



                }

            }

















            //var result = carManager.GetCarDetails();

            //if (result.Success==true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.Id +
            //            " - " + car.BrandName + " / " + car.ColorName
            //            + " / " + car.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}





        }


    }
}

