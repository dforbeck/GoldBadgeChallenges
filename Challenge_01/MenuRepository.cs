using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_01
{
    class MenuRepository
    {
        List<Menu> _menuList; //naming the list collection type to be used in UI

        public List<Menu> GetMenuList()
        {
            _menuList = new List<Menu>();
            return _menuList;
        }

        public void AddMealToList(Menu menu)
        {
            _menuList.Add(menu);
        }

        public void RemoveMealFromList(Menu menu)
        {
            _menuList.Remove(menu);
        }






    }
}
