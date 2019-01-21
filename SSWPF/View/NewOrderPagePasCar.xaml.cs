using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
        
        private void NewOrderPagePasCarFillCar()
        {           
            if (CarBodyCheckBox.IsChecked == true)
            {
                c.CarBody = 100;
            }

            if (CarWheelsCheckBox.IsChecked == true)
            {
                c.CarWheels = 100;
            }

            if (CarEngineCheckBox.IsChecked == true)
            {
                c.CarEngine = 100;
            }

            if (CarBrakesCheckBox.IsChecked == true)
            {
                c.CarBrakes = 100;
            }

            if (CarUndercarriageCheckBox.IsChecked == true)
            {
                c.CarUndercarriage = 100;
            }
            
            if (CarWheelsBalancingCheckBox.IsChecked == true)
            {
                c.PasCarwheelBalancing = 100;
            }
        }

        private void NewOrderPagePasCarFillOrder()
        {
            o.ModelCar = NewOrderPagePasCarTextBoxCarModel.Text;
            o.NumberCar = NewOrderPagePasCarTextBoxCarNumber.Text;
            o.CostOrderSet();
            o.AddNewOrder();
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Submit_NewOrderPagePasCar(object sender, RoutedEventArgs e)
        {
            NewOrderPagePasCarFillCar();
            NewOrderPagePasCarFillOrder();
            
            Order lo = new Order();
            lo.GetLastOrder();
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}

