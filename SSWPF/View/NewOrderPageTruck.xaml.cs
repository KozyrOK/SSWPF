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
            p.CurrentValuePrice();
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
            Order o = new Order();
            o.ModelCar = NewOrderPageTruckTextBoxCarModel.Text;
            o.NumberCar = NewOrderPageTruckTextBoxCarNumber.Text;

            FillTruckCarService(s);

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

            NewOrderPageTruckCarFillOrder(); // add lock database

            Order lo = new Order();
            lo.LastOrderValue();
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}
