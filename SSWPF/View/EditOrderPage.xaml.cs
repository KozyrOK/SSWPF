using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{    
    public partial class EditOrderPage : Page
    {
        Order idOrderEdit = new Order();

        public EditOrderPage(Order idOrder)
        {            
            InitializeComponent();
            idOrderEdit = idOrder;
            EditOrderPageGrid.DataContext = idOrder;            
        }       

        private void Button_Click_Back_EditOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_OK_EditOrderPage(object sender, RoutedEventArgs e)
        {
            idOrderEdit.EditOrder();
            NavigationService.Navigate(new MainPage());
        }
    }
}
