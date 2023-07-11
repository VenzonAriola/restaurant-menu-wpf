using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using DataBinding_Lab3.Model;


namespace DataBinding_Lab3.ViewModel
{
    public class MainViewModel
    {
        public List<MenuItems> Appetizer { get; set; }
        public List<MenuItems> MainCourse { get; set; }
        public List<MenuItems> Beverages { get; set; }
        public List<MenuItems> Desserts { get; set; }

        
        public MainViewModel()
        {
            //Appetizer
            Appetizer = new List<MenuItems>
            {
                new MenuItems
                {
                    Name="Buffalo Wings",
                    Category= "Appetizer",
                    Price = 5.95,
                },
                new MenuItems
                {
                    Name="Buffalo Fingers",
                    Category= "Appetizer",
                    Price = 6.95,
                },

                new MenuItems
                {
                    Name="Potato Skins",
                    Category= "Appetizer",
                    Price = 8.95,
                },

                new MenuItems
                {
                    Name="Nachos",
                    Category= "Appetizer",
                    Price = 8.95,
                },
                new MenuItems
                {
                    Name="Mushroom Caps",
                    Category= "Appetizer",
                    Price = 10.95,
                },
                new MenuItems
                {
                    Name="Shrimp Cocktail",
                    Category= "Appetizer",
                    Price = 12.95,
                },
                new MenuItems
                {
                    Name="Chips and Salsa",
                    Category= "Appetizer",
                    Price = 10.95,
                },

            };
            //Main Course
            MainCourse = new List<MenuItems>
            {
                new MenuItems
                {
                    Name="Seafod Alfredo",
                    Category= "Main Course",
                    Price = 15.95,
                },
                new MenuItems
                {
                    Name="Chicken Alfredo",
                    Category= "Main Course",
                    Price = 13.95,
                },
                 new MenuItems
                {
                    Name="Chicken Piccata",
                    Category= "Main Course",
                    Price = 13.95,
                },
                 new MenuItems
                {
                    Name="Turkey Club",
                    Category= "Main Course",
                    Price = 11.95,
                },
                  new MenuItems
                {
                    Name="Lobster Pie",
                    Category= "Main Course",
                    Price = 19.95,
                },
                 new MenuItems
                {
                    Name="Prime Rib",
                    Category= "Main Course",
                    Price = 20.95,
                },
                 new MenuItems
                {
                    Name="Shrimp Scampi",
                    Category= "Main Course",
                    Price = 18.95,
                },
                  new MenuItems
                {
                    Name="Turkey Dinner",
                    Category= "Main Course",
                    Price = 13.95,
                },
                  new MenuItems
                {
                    Name="Stuffed Chicked",
                    Category= "Main Course",
                    Price = 14.95,
                },
            };
           // cmbMainCourse.ItemSource = MainCourse;

            Beverages = new List<MenuItems>
            {
                new MenuItems
                {
                    Name= "Soda",
                    Category="Beverage",
                    Price =1.95,
                },
                 new MenuItems
                {
                    Name= "Tea",
                    Category="Beverage",
                    Price =1.50,
                },
                 new MenuItems
                {
                    Name= "Coffee",
                    Category="Beverage",
                    Price =1.25,
                },
                 new MenuItems
                {
                    Name= "Mineral Water",
                    Category="Beverage",
                    Price =2.95,
                },
                 new MenuItems
                {
                    Name= "Juice",
                    Category="Beverage",
                    Price =2.50,
                },
                 new MenuItems
                {
                    Name= "Milk",
                    Category="Beverage",
                    Price =1.50,
                },
            };

            Desserts = new List<MenuItems>
            {
                new MenuItems
                {
                    Name="Apple Pie",
                    Category="Desserts",
                    Price= 5.95
                },
                new MenuItems
                {
                    Name="Sundae",
                    Category="Desserts",
                    Price= 3.95
                },
                new MenuItems
                {
                    Name="Carrot Cake",
                    Category="Desserts",
                    Price= 5.95
                },
                new MenuItems
                {
                    Name="Mud Pie",
                    Category="Desserts",
                    Price= 4.95
                },
                new MenuItems
                {
                    Name="Apple Crisp",
                    Category="Desserts",
                    Price= 5.95
                },
            };

            // Initialize the SelectedItems collection
          // SelectedItems = new ObservableCollection<MenuItems>();

            // Initialize the command to add selected items
            //AddSelectedItemCommand = new DelegateCommand<MenuItems>(AddSelectedItem);
        }

        //private void AddSelectedItem(MenuItems item)
        //{
        //    // Add the selected item to the collection
        //    SelectedItems.Add(item);
        //}

    }
}
