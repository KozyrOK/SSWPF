using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{
    
    public partial class NewOrderPageTruck : Page
    {
        Order o = new Order();
        Car c = new Car();

        public NewOrderPageTruck()
        {
            InitializeComponent();
            this.DataContext = c;
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();            
        }

        private void Button_Click_Submit_NewOrderPageTruck(object sender, RoutedEventArgs e)
        {
            o.ModelCar = NewOrderPageTruckTextBoxCarModel.Text;
            o.NumberCar = NewOrderPageTruckTextBoxCarNumber.Text;

            o.CostOrderSet();
            o.AddNewOrder();

            Order lo = new Order();
            lo.GetLastOrder();
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}
