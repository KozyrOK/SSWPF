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
            DataContext = c;
        }

        private void NewOrderPageBusFillCar()
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

            if (BusHandsrailsCheckBox.IsChecked == true)
            {
                c.BusHandsrails = 100;
            }

            if (BusSalonCheckBox.IsChecked == true)
            {
                c.BusSalon = 100;
            }

            if (BusSeatsUpholsteryCheckBox.IsChecked == true)
            {
                c.PasCarwheelBalancing = 100;
            }
        }

        private void NewOrderPageBusFillOrder()
        {
            o.ModelCar = NewOrderPageBusTextBoxCarModel.Text;
            o.NumberCar = NewOrderPagePasBusTextBoxCarNumber.Text;

            o.CostOrderSet();
            o.AddNewOrder();
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();            
        }
        private void Button_Click_Submit_NewOrderPageBus(object sender, RoutedEventArgs e)
        {            

            NewOrderPageBusFillCar();
            NewOrderPageBusFillOrder();

            Order lo = new Order();
            lo.GetLastOrder();
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}
