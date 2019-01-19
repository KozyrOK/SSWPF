using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{

    public partial class NewOrderPageSelect : Page
    {
        public NewOrderPageSelect()
        {
            InitializeComponent();
        }
                
        private void Button_Click_Cancel_NewOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click_Ok_NewOrderPage(object sender, RoutedEventArgs e)
        {
            if (Truck_RadioButton.IsChecked == true)
                NavigationService.Navigate(new NewOrderPageTruck());           
            else if (Bus_RadioButton.IsChecked == true)
                NavigationService.Navigate(new NewOrderPageBus());           
            else
                NavigationService.Navigate(new NewOrderPagePasCar());           
        }
    }
}
