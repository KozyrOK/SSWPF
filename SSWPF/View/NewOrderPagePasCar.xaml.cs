using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;

namespace SSWPF.View
{
    
    public partial class NewOrderPagePasCar : Page
    {
        Order o = new Order();
        Car c = new Car();                         
               
        public NewOrderPagePasCar()
        {
            InitializeComponent();
            this.DataContext = c;
        }               

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();            
        }

        private void Button_Click_Submit_NewOrderPagePasCar(object sender, RoutedEventArgs e)
        {            
            if (CarWheelsBalancingCheckBox.IsChecked==false)
            {
                c.PasCarwheelBalancing = 0;
            }
            o.ModelCar = NewOrderPagePasCarTextBoxCarModel.Text;
            o.NumberCar = NewOrderPagePasCarTextBoxCarNumber.Text;
            Price p = new Price();
            Price.GetCurrentValuePrice(p);
            o.CostOrder = Order.CostFixPasCar(p, c);
            Order.AddNewOrder(o);
            Order lo = new Order();
            Order.GetLastOrder(lo);
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}

