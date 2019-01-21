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

            if (TruckHydraulicsCheckBox.IsChecked == true)
            {
                c.TruckHydraulics = 100;
            }
        }

        private void NewOrderPageTruckFillOrder()
        {
            o.ModelCar = NewOrderPageTruckTextBoxCarModel.Text;
            o.NumberCar = NewOrderPageTruckTextBoxCarNumber.Text;
            o.CostOrderSet();
            o.AddNewOrder();
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();            
        }

        private void Button_Click_Submit_NewOrderPageTruck(object sender, RoutedEventArgs e)
        {

            NewOrderPageTruckFillCar();
            NewOrderPageTruckFillOrder();

            Order lo = new Order();
            lo.GetLastOrder();
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}
