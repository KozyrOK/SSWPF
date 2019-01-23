using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SSWPF.View
{       
    public partial class SearchOrderPage : Page
    {        
        public SearchOrderPage()
        {            
            InitializeComponent();                       
        }

        private void Button_Click_Cancel_SearchOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();            
        }

        private void Button_Click_OK_SearchOrderPage(object sender, RoutedEventArgs e)
        {            
            var content = InputOrderIdButton.Text;           

            bool success = int.TryParse(content, out int id);

            if (success)
            {                
                Order o = new Order(id);          

                if (o.OrderId != null)
                    NavigationService.Navigate(new EditOrderPage(o));
                else
                    NavigationService.GoBack();
            }                       
        }
    }
}
