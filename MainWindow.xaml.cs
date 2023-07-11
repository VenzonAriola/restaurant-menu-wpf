using DataBinding_Lab3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBinding_Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>  /// 
   

    public partial class MainWindow : Window
    {
       
        ObservableCollection<MenuItems> menuData = new ObservableCollection<MenuItems>();
        public double subTotal;
        public double tax;
        public double total;

        public MainWindow()
        {
            InitializeComponent();
            

        }

        //private void loginControl_LoginButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string username = loginControl.Username;
        //    string password = loginControl.Password;

        //    // Perform login validation here
        //    if (username == "admin" && password == "password")
        //    {
        //        loginControl.Visibility = Visibility.Collapsed;
        //        this.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid username or password");
        //    }
        //}


        public void addMenuItem(MenuItems item)
        {
            int index;
            if (menuData.Contains(item))
            {
                index = menuData.IndexOf(item);
                menuData[index].quantity++;
                menuData.Remove(item);
                menuData.Insert(index, item);
                SelectedMenuItems.ItemsSource = menuData;
                subTotal += menuData[index].Price;
                TBoxSubTotal.Text = $"{subTotal:c}";
                tax = subTotal * 0.13;
                TBoxTax.Text = $"{tax:c}";
                total = subTotal + tax;
                TBoxTotally.Text = $"{total:c}";
            }
            else
            {
                menuData.Add(item);
                index = menuData.IndexOf(item);
                menuData[index].quantity++;
                SelectedMenuItems.ItemsSource = menuData;
                subTotal += menuData[index].Price;
                TBoxSubTotal.Text = $"{subTotal:c}";
                tax = subTotal * 0.13;
                TBoxTax.Text = $"{tax:c}";
                total = subTotal + tax;
                TBoxTotally.Text = $"{total:c}";
            }
        }
        public void RemoveMenuItem(MenuItems item)
        {
            int index = SelectedMenuItems.SelectedIndex;
            subTotal -= item.Price * item.quantity;
            TBoxSubTotal.Text = $"{subTotal:c}";
            tax = subTotal * 0.13;
            TBoxTax.Text = $"{tax:c}";
            total = subTotal + tax;
            TBoxTotally.Text = $"{total:c}";
            item.quantity = 0;
            menuData.Remove(item);
        }


        private void cmbMainCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbMainCourse.SelectedItem != null)
            {
                MenuItems item = (MenuItems)cmbMainCourse.SelectedItem;
                addMenuItem(item);
            }
        }

        private void cmbBeverages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbBeverages.SelectedItem != null)
            {
                MenuItems item = (MenuItems)cmbBeverages.SelectedItem;
                addMenuItem(item);
            }
        }

        private void cmbDesserts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbDesserts.SelectedItem != null)
            {
                MenuItems item = (MenuItems)cmbDesserts.SelectedItem;
                addMenuItem(item);
            }
        }

        private void SelectedMenuItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            subTotal = 0;
            foreach (MenuItems item in menuData)
            {
                double newPrice = item.Price * item.quantity;
                subTotal += newPrice;
            }
            TBoxSubTotal.Text = $"{subTotal:c}";
            tax = subTotal * 0.13;
            TBoxTax.Text = $"{tax:c}";
            total = subTotal + tax;
            TBoxTotally.Text = $"{total:c}";
        }

        private void cmbAppetizer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbAppetizer.SelectedItem != null)
            {
                MenuItems item = (MenuItems)cmbAppetizer.SelectedItem;
                addMenuItem(item);
            }
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://www.centennialcollege.ca/", UseShellExecute = true });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
            TBoxSubTotal.Text = "";
            TBoxTotally.Text = "";
            TBoxTax.Text = "";
            cmbAppetizer.SelectedItem = null;
            cmbMainCourse.SelectedItem = null;
            cmbBeverages.SelectedItem = null;
            cmbDesserts.SelectedItem = null;
            SelectedMenuItems.ItemsSource = null;
            SelectedMenuItems.Items.Clear();
            


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Get the selected item from the DataGrid
            MenuItems selectedItem = (MenuItems)SelectedMenuItems.SelectedItem;

            // Call the RemoveMenuItem method with the selected item
            RemoveMenuItem(selectedItem);
        }
    }




}


