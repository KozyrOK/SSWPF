using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{
    
    public partial class NewOrderPageBus : Page
    {        
        BusCarCondition c = new BusCarCondition();
        BusCarService s = new BusCarService();
        Order o = new Order();

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
            if (BusSeatsUpholsteryCheckBox.IsChecked == true) { s.BusUpholstery = true; }
        }

        private decimal CalculateCostOrder(BusCarService s, BusCarCondition c)
        {
            Price p = new Price();
            p.LastPriceId();
            if (p.PriceId > 0)
            {
                int id = p.PriceId;
                p = new Price(id);
            }

            decimal cost = 0;
            if (s.CarBody)
            {
                decimal carBody = 0;
                carBody = p.CarBody / 100 * (100 - c.CarBody);
                cost += carBody;
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
                carBrakes = p.CarBrakes / 100 * (100 - c.CarBrakes);
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
                busSalon = p.BusSalon / 100 * (100 - c.BusSalon);
                cost += busSalon;
            }
            if (s.BusUpholstery)
            {
                decimal busUpholstery = 0;
                busUpholstery = p.BusUpholstery;
                cost += busUpholstery;
            }
            return cost;
        }

        private void NewOrderPageBusCarFillOrder()
        {
            FillBusCarService(s);

            o.ModelCar = NewOrderPageBusTextBoxCarModel.Text;
            o.NumberCar = NewOrderPagePasBusTextBoxCarNumber.Text;
            o.CostOrder = CalculateCostOrder(s, c);
            o.ConditionCar = c.TotalCondition();           

            o.AddNewOrder();
        }
        
        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();            
        }

        private void Button_Click_Submit_NewOrderPageBus(object sender, RoutedEventArgs e)
        {
            NewOrderPageBusCarFillOrder(); 
            
            o.LastOrderId();
            NavigationService.Content = new PageOrderResult(o);
        }
    }
}
