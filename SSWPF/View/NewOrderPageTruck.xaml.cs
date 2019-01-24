using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{
    
    public partial class NewOrderPageTruck : Page
    {       
        TruckCarCondition c = new TruckCarCondition();
        TruckCarService s = new TruckCarService();
        Order o = new Order();

        public NewOrderPageTruck()
        {
            InitializeComponent();
            DataContext = c;
        }

        private void FillTruckCarService(TruckCarService s)
        {
            if (CarBodyCheckBox.IsChecked == true) { s.CarBody = true; }
            if (CarWheelsCheckBox.IsChecked == true) { s.CarWheels = true; }
            if (CarEngineCheckBox.IsChecked == true) { s.CarEngine = true; }
            if (CarBrakesCheckBox.IsChecked == true) { s.CarBrakes = true; }
            if (CarUndercarriageCheckBox.IsChecked == true) { s.CarUndercarriage = true; }
            if (TruckHydraulicsCheckBox.IsChecked == true) { s.TruckHydraulics = true; }
        }

        private decimal CalculateCostOrder(TruckCarService s, TruckCarCondition c)
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
                carBrakes = p.CarBrakes / 100 * (100 - c.CarEngine);
                cost += carBrakes;
            }
            if (s.CarUndercarriage)
            {
                decimal carUndercarriage = 0;
                carUndercarriage = p.CarUndercarriage / 100 * (100 - c.CarUndercarriage);
                cost += carUndercarriage;
            }            
            if (s.TruckHydraulics)
            {
                decimal truckHydraulics = 0;
                truckHydraulics = p.TruckHydraulics / 100 * (100 - c.TruckHydraulics);
                cost += truckHydraulics;
            }
            return cost;
        }

        private void NewOrderPageTruckCarFillOrder()
        {
            FillTruckCarService(s);

            o.ModelCar = NewOrderPageTruckTextBoxCarModel.Text;
            o.NumberCar = NewOrderPageTruckTextBoxCarNumber.Text;
            o.CostOrder = CalculateCostOrder(s, c);
            o.ConditionCar = c.TotalCondition();
            
            o.AddNewOrder();
        }        

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();            
        }

        private void Button_Click_Submit_NewOrderPageTruck(object sender, RoutedEventArgs e)
        {
            NewOrderPageTruckCarFillOrder();
                        
            o.LastOrderId();
            NavigationService.Content = new PageOrderResult(o);
        }
    }
}
