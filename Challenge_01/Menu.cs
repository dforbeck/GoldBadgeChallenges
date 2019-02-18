using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_01
{
    public enum MealDescription { Sandwich, Salad, Dinner }
    public enum VegetableSide { Corn, Beans, Broccoli }
    public enum SecondSide { Slaw, Bread, Fries  }

    public class Menu
    {

        // this is where we will define our properties
        public int Number { get; set; }
        public string Name { get; set; }
        public MealDescription DescriptionOfMeal { get; set; }
        public VegetableSide SideOfVegetable { get; set; }
        public SecondSide Side_Second { get; set; }
        public bool HasSoda { get; set; }
        public double Price { get; set; }

        //empty constructor for UI
        public Menu()
        {
        }

        //"overloaed" constructor
        public Menu(int number, string name, MealDescription description, VegetableSide vegetable, SecondSide side_second, bool hasSoda, double price)
        {
            Number = number;
            Name = name;
            DescriptionOfMeal = description;
            SideOfVegetable = vegetable;
            Side_Second = side_second;
            HasSoda = hasSoda;
            Price = price;
        }
    }

          
}
