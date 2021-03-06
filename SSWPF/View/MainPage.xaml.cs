﻿using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void New_order_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewOrderPageSelect());
        }

        private void Edit_order_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchOrderPage());
        }

        private void Actual_orders_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActualOrdersPage());            
        }        

        private void Done_orders_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DoneOrdersPage());            
        }

    }
}
