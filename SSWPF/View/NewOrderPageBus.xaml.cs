using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{
    
    public partial class NewOrderPageBus : Page
    {
        Order o = new Order();
        Car c = new Car();

        public NewOrderPageBus()
        {
            InitializeComponent();
            this.DataContext = c;
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();            
        }
        private void Button_Click_Submit_NewOrderPageBus(object sender, RoutedEventArgs e)
        {
            if (BusSeatsUpholsteryCheckBox.IsChecked == true)
            {
                c.PasCarwheelBalancing = 100;
            }
            o.ModelCar = NewOrderPageBusTextBoxCarModel.Text;
            o.NumberCar = NewOrderPagePasBusTextBoxCarNumber.Text;
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
