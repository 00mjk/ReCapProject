using Entities.Concrete;
using System.Collections.Generic;

namespace ConsoleUI
{
    public interface IConsoleService
    {
        void GetMenus(string[] menus);
        void GetAllBrands(List<Brand> brands);
    }
}
