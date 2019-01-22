using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{
    
    public partial class NewOrderPageBus : Page
    {
        Order o = new Order();
        BusCarCondition c = new BusCarCondition();
        BusCarService s = new BusCarService();
        Price p = new Price();

        public NewOrderPageBus()
        {
            InitializeComponent();
            DataContext = c;
        }

        private void FillBusCarService(BusCarService s)
        {
            if (CarBodyCheckBox.IsChecked == true) { s.CarBody = true; }
            if (CarWheelsCheckBox.IsChecked == true) { s.CarWheels = true; }
            if (CarEngineCheckBox.IsChecked == true) { s.CarEngine = true; }
            if (CarBrakesCheckBox.IsChecked == true) { s.CarBrakes = true; }
            if (CarUndercarriageCheckBox.IsChecked == true) { s.CarUndercarriage = true; }
            if (BusHandsrailsCheckBox.IsChecked == true) { s.BusHandsrails = true; }
            if (BusSalonCheckBox.IsChecked == true) { s.BusSalon = true; }            
        }

        private decimal CalculateCostOrder(BusCarService s, BusCarCondition c, Price p)
        {
            p.GetCurrentValuePrice();
            decimal cost = 0;
            if (s.CarBody)
            {
                decimal carbody = 0;
                carbody = p.CarBody / 100 * (100 - c.CarBody);
                cost += carbody;
            }

            if (s.CarWheels)
            {
                decimal carWheels = 0;
                carWheels = p.CarWheels / 100 * (100 - c.CarWheels);
                cost += carWheels;
            }

            if (s.CarEngine)
            {
                decimal carEngine = 0;
                carEngine = p.CarEngine / 100 * (100 - c.CarEngine);
                cost += carEngine;
            }

            if (s.CarBrakes)
            {
                decimal carBrakes = 0;
                carBrakes = p.CarBrakes / 100 * (100 - c.CarEngine);
                cost += carBrakes;
            }

            if (s.CarUndercarriage)
            {
                decimal carUndercarriage = 0;
                carUndercarriage = p.CarUndercarriage / 100 * (100 - c.CarUndercarriage);
                cost += carUndercarriage;
            }
            
            if (s.BusHandsrails)
            {
                decimal busHandsrails = 0;
                busHandsrails = p.BusHandsrails / 100 * (100 - c.BusHandsrails);
                cost += busHandsrails;
            }

            if (s.BusSalon)
            {
                decimal busSalon = 0;
                busSalon = p.BusSalon;
                cost += busSalon;
            }

            return cost;
        }

        private void NewOrderPageBusCarFillOrder()
        {
            o.ModelCar = NewOrderPageBusTextBoxCarModel.Text;
            o.NumberCar = NewOrderPagePasBusTextBoxCarNumber.Text;

            FillBusCarService(s);

            o.CostOrder = CalculateCostOrder(s, c, p);
            o.ConditionCar = c.GetTotalCondition;
            o.AddNewOrder();
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();            
        }
        private void Button_Click_Submit_NewOrderPageBus(object sender, RoutedEventArgs e)
        {
            NewOrderPageBusCarFillOrder(); // add lock database

            Order lo = new Order();
            lo.GetLastOrder();
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}
