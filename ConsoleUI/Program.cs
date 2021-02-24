using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.CarContext;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {


            //CarManager carManager = new CarManager(new EfCarDal());
            //UserManager userManager = new UserManager(new EfUserDal());
            //CarDetailDto carDetail = new CarDetailDto();
            //IConsoleService consoleService = new ConsoleManager();
            //IBrandService brandService = new BrandManager(new EfBrandDal());
            //ICarService carService = new CarManager(new EfCarDal());


            //var menus = new string[]{
            //   "Marka ekle" ,"Arabaları Listele" ,"Araba sil"
            //};
            //string input;
            //int inputId;
            //while (true)
            //{
            //    consoleService.GetMenus(menus);
            //    Console.Write("Seçiminiz.");
            //    input = Console.ReadLine();
            //    switch (input)
            //    {
            //        case "1":
            //            Console.Clear();
            //            Console.Write("Lütfen Marka adını girin:");
            //            brandService.Add(new Brand
            //            {
            //                BrandName = Console.ReadLine()
            //            });

            //            break;

            //        case "2":
            //            Console.WriteLine("---------------------------------------------------");
            //            consoleService.GetAllBrands(brandService.GetAll().Data);
            //            break;
            //        case "3":
            //            Console.Clear();
            //            Console.WriteLine("---------------------------------------------------");
            //            foreach (var car in brandService.GetAll().Data)
            //            {
            //                Console.WriteLine(car.BrandId + " - " + car.BrandName);
            //            }
            //            Console.WriteLine("Lütfen araba id sini giriniz  : ");
            //            inputId = int.Parse(Console.ReadLine());
            //            brandService.DeleteById(inputId);
            //            break;




            //            

            //    }

            //}

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



