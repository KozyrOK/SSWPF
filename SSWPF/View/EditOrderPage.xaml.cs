﻿using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{    
    public partial class EditOrderPage : Page
    {
        OrderDB idOrderEdit = new OrderDB();

        public EditOrderPage(OrderDB idOrder)
        {            
            InitializeComponent();
            idOrderEdit = idOrder;
            EditOrderPageGrid.DataContext = idOrder;            
        }       

        private void Button_Click_Back_EditOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_OK_EditOrderPage(object sender, RoutedEventArgs e)
        {
            idOrderEdit.EditOrderDB();
            NavigationService.Navigate(new MainPage());
        }
    }
}
