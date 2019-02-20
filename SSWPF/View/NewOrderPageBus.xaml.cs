using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{
    
    public partial class NewOrderPageBus : Page
    {        
        BusCarServiceStation s = new BusCarServiceStation();        
        OrderDB o = new OrderDB();

        public NewOrderPageBus()
        {
            InitializeComponent();
            DataContext = s;
        }        
        
        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();            
        }

        private void Button_Click_Submit_NewOrderPageBus(object sender, RoutedEventArgs e)
        {
            s.FillOrder(ref o);
            o.AddNewOrderDB();
            o.GetLastOrderIdDB();
            NavigationService.Content = new PageOrderResult(o);
        }
    }
}
