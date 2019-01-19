using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{
    
    public partial class NewOrderPagePasCar : Page
    {
        Order o = new Order();
        Car c = new Car();                         
               
        public NewOrderPagePasCar()
        {
            InitializeComponent();
            DataContext = c;
        }               

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();            
        }

        private void Button_Click_Submit_NewOrderPagePasCar(object sender, RoutedEventArgs e)
        {            
            if (CarWheelsBalancingCheckBox.IsChecked==true)
            {
                c.PasCarwheelBalancing = 100;
            }

            o.ModelCar = NewOrderPagePasCarTextBoxCarModel.Text;
            o.NumberCar = NewOrderPagePasCarTextBoxCarNumber.Text;

            o.CostOrderSet();
            o.AddNewOrder();

            Order lo = new Order();
            lo.GetLastOrder();
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}

