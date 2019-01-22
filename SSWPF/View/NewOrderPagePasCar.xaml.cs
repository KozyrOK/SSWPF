using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{
    
    public partial class NewOrderPagePasCar : Page
    {
        Order o = new Order();
        PasCarCondition c = new PasCarCondition();
        PasCarService s = new PasCarService();
        Price p = new Price();          

        public NewOrderPagePasCar()
        {
            InitializeComponent();
            DataContext = c;
        }

        private void FillPasCarService(PasCarService s)
        {
            if (CarBodyCheckBox.IsChecked == true) { s.CarBody = true; }
            if (CarWheelsCheckBox.IsChecked == true) { s.CarWheels = true; }
            if (CarEngineCheckBox.IsChecked == true) { s.CarEngine = true; }
            if (CarBrakesCheckBox.IsChecked == true) { s.CarBrakes = true; }
            if (CarUndercarriageCheckBox.IsChecked == true) { s.CarUndercarriage = true; }
            if (CarWheelsBalancingCheckBox.IsChecked == true) { s.PasCarwheelBalancing = true; }            
        }

        private decimal CalculateCostOrder(PasCarService s, PasCarCondition c, Price p)
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

            if (s.PasCarwheelBalancing)
            {
                decimal pasCarwheelBalancing = 0;
                pasCarwheelBalancing = p.PasCarwheelBalancing;
                cost += pasCarwheelBalancing;
            }

            return cost;
        }        

        private void NewOrderPagePasCarFillOrder()
        {
            o.ModelCar = NewOrderPagePasCarTextBoxCarModel.Text;
            o.NumberCar = NewOrderPagePasCarTextBoxCarNumber.Text;

            FillPasCarService(s);
            
            o.CostOrder = CalculateCostOrder(s, c, p);
            o.ConditionCar = c.GetTotalCondition;
            o.AddNewOrder();
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Submit_NewOrderPagePasCar(object sender, RoutedEventArgs e)
        {
            NewOrderPagePasCarFillOrder(); // add lock database
            
            Order lo = new Order();
            lo.GetLastOrder();
            NavigationService.Content = new PageOrderResult(lo);
        }
    }
}

