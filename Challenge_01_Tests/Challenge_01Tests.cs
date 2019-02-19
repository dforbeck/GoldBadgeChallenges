using System;
using System.Collections.Generic;
using Challenge_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_01_Tests
{
    [TestClass]
    public class Challenge_01Tests
    {
        MenuRepository _menuRepoTest = new MenuRepository();
        
        //testing gettign menu list
        [TestMethod]
        public void MenuRepository_GetMenuList_ShouldReturnCorrectCount()
        {
            //Arrange
            var _menuList = _menuRepoTest.GetMenuList();  //when do you use var vs. the list of menu "Type"

            //Act
            var actual = _menuList.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]// testing adding a menu item
        public void MenuRepository_AddMealToList_ShouldReturnCorrectCount()
        {
            //Arrange
            List<Menu> _menuList = _menuRepoTest.GetMenuList();
            Menu menu = new Menu();

            //Act
            _menuRepoTest.AddMealToList(menu);
            var actual = _menuList.Count;
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]// testing removing a menu item after adding one
        public void MenuRepository_RemoveMealFromList_ShouldReturnCorrectCount()
        {
            //Arrange
            List<Menu> _menuList = _menuRepoTest.GetMenuList();
            Menu menu = new Menu();

            //Act
            _menuRepoTest.AddMealToList(menu);
            _menuRepoTest.RemoveMealFromList(menu);
            var actual = _menuList.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);

        }









    }
}
