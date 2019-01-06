using SSWPF.Model;
using System;
using System.Collections.Generic;
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

namespace SSWPF.View
{
    
    public partial class NewOrderPageTruck : Page
    {
        private Order o;
        private Car c;

        public NewOrderPageTruck()
        {
            InitializeComponent();
            NewOrderPageTruckGrid.DataContext = c;
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void Button_Click_Submit_NewOrderPageTruck(object sender, RoutedEventArgs e)
        {
            o.ModelCar = NewOrderPageTruckTextBoxCarModel.Text;
            o.NumberCar = NewOrderPageTruckTextBoxCarNumber.Text;
            Price p = new Price();
            Price.GetCurrentValuePrice(p);
            o.CostOrder = Order.CostFixBus(p, c);
            Order.AddNewOrder(o);
            Order lo = new Order();
            Order.GetLastOrder(lo);
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}
