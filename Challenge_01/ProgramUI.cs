using System;
using System.Collections.Generic;


namespace Challenge_01
{
    class ProgramUI
    {
        MenuRepository _menuRepo = new MenuRepository();
        int _response; //response in menu
        List<Menu> _menuList;  //declaration of this field, it is also in Repository; initialized below.

        public void Run()
        {
            _menuList = _menuRepo.GetMenuList();
            SeedData();  //get some test data


            while (_response != 4) //do until they pick 4.
            {
                PrintMenu();
                switch (_response)

                {
                    case 1:
                        //See menu meals
                        SeeAllMeals();
                        break;

                    case 2:
                        //Add meal item            
                        AddMeal();
                        break;

                    case 3:
                        //Remove meal item
                        RemoveMeal();
                        break;

                    case 4:
                        Console.WriteLine("Have a nice day everyone!");
                        break;

                    default:
                        Console.WriteLine("Please enter an appropriate choice number.");
                        break;
                }

            }
        }

        private void AddMeal()
        {
            Menu newMenu = new Menu();

            Console.WriteLine("Enter the Meal Number:");
            string numberStr = Console.ReadLine();
            int number = int.Parse(numberStr);
            newMenu.Number = number;

            Console.WriteLine("Enter the Name of the Meal item:");
            string name = Console.ReadLine();
            newMenu.Name = name;

            Console.WriteLine("Enter the corresponding number for the Meal Description:\n" +
                 "1. Sandwich\n" +
                 "2. Salad\n" +
                 "3. Dinner");
            string DInput = Console.ReadLine();
            int DescInput = int.Parse(DInput);

            MealDescription description = new MealDescription(); //first one is enum name
            switch (DescInput)
            {
                case 1:
                    description = MealDescription.Sandwich;
                    break;
                case 2:
                    description = MealDescription.Salad;
                    break;
                case 3:
                    description = MealDescription.Dinner;
                    break;
                default:
                    Console.WriteLine("Please enter an appropriate number.");
                    break;

            }
            newMenu.DescriptionOfMeal = description;

            Console.WriteLine("Enter the corresponding number for the Vegetable Side:\n" +
            "1. Corn\n" +
            "2. Beans\n" +
            "3. Brocooli");
            string VInput = Console.ReadLine();
            int VegInput = int.Parse(VInput);

            VegetableSide vegetable = new VegetableSide(); //first one is enum name
            switch (VegInput)
            {
                case 1:
                    vegetable = VegetableSide.Corn;
                    break;
                case 2:
                    vegetable = VegetableSide.Beans;
                    break;
                case 3:
                    vegetable = VegetableSide.Broccoli;
                    break;
                default:
                    Console.WriteLine("Please enter an appropriate number.");
                    break;
            }
            newMenu.SideOfVegetable = vegetable;

            Console.WriteLine("Enter the corresponding number for the Second Side:\n" +
            "1. Slaw\n" +
            "2. Bread\n" +
            "3. Fries");
            string SInput = Console.ReadLine();
            int SSInput = int.Parse(SInput);

            SecondSide side_second = new SecondSide(); //first one is enum name
            switch (SSInput)
            {
                case 1:
                    side_second = SecondSide.Slaw;
                    break;
                case 2:
                    side_second = SecondSide.Bread;
                    break;
                case 3:
                    side_second = SecondSide.Fries;
                    break;
                default:
                    Console.WriteLine("Please enter an appropriate number.");
                    break;
            }

            newMenu.Side_Second = side_second;

            Console.WriteLine("Does the meal include a Soda?Y/N:");
            string hasSodaStr = Console.ReadLine().ToLower();
            bool hasSoda;
            if (hasSodaStr.Contains("y"))
                hasSoda = true;
            else
                hasSoda = false;

            newMenu.HasSoda = hasSoda;

            Console.WriteLine("Enter the Price of the Meal item:");
            string priceStr = Console.ReadLine();
            double price = double.Parse(priceStr);

            newMenu.Price = price;

            _menuRepo.AddMealToList(newMenu);
        }

        public void RemoveMeal()
        {
            SeeAllMeals();
            Console.WriteLine("Enter the Name of the meal you would like to remove:");
            string desiredName = Console.ReadLine();
            foreach (Menu menu in _menuList)
            {
                if (menu.Name == desiredName)
                {
                    _menuRepo.RemoveMealFromList(menu);
                    break;  //so that the list is not modified
                }
            }
        }

        public void SeeAllMeals()
        {
            Console.WriteLine("Menu Number\tMeal Name\tMeal Description\tVegetable Side\tSecond Side\tIncludes Soda?\tPrice");
            foreach (Menu menu in _menuList)
            {
                Console.WriteLine($"{menu.Number}\t\t{menu.Name}\t{menu.DescriptionOfMeal}\t\t\t{menu.SideOfVegetable}\t\t{menu.Side_Second}\t{menu.HasSoda}\t{menu.Price}");
            }

        }

        public void PrintMenu()
        {
            Console.WriteLine(
              "What would you like to do? Please type a number and press Enter.\n\t" +
                  "1. See menu\n\t" +
                  "2. Add new meal item to menu\n\t" +
                  "3. Remove meal item from menu\n\t" +
                  "4. Exit");

            string responseStr = Console.ReadLine();
            _response = int.Parse(responseStr);
        }

        public void SeedData()
        {
            _menuRepo.AddMealToList(new Menu(1, "Grand Slam", MealDescription.Dinner, VegetableSide.Beans, SecondSide.Slaw, true, 14.50));
            _menuRepo.AddMealToList(new Menu(2, "Biggie Salad", MealDescription.Salad, VegetableSide.Broccoli, SecondSide.Bread, false, 11.00));
            _menuRepo.AddMealToList(new Menu(3, "Double Decker", MealDescription.Sandwich, VegetableSide.Corn, SecondSide.Fries, true, 9.75));
        }






    }
}




















