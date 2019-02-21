using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{
    
    public partial class NewOrderPagePasCar : Page
    {       
        PasCarServiceStation s = new PasCarServiceStation();
        Order o = new Order();

        public NewOrderPagePasCar()
        {
            InitializeComponent();
            DataContext = s;            
        }        

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Submit_NewOrderPagePasCar(object sender, RoutedEventArgs e)
        {
            s.FillOrder(ref o);
            o.AddNewOrder();
            o.GetLastOrderId();
            NavigationService.Content = new PageOrderResult(o);
        }
    }
}

