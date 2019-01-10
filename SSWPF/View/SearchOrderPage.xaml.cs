using SSWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            Order o = new Order();

            if (int.TryParse(content, out int id))
            {
                id = Int32.Parse(content);
                o.FindOrder(id);
                if (o.OrderId != null)
                    NavigationService.Navigate(new EditOrderPage(o));
                else
                    NavigationService.GoBack();
            }
        }

    }
}
