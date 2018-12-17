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
    // код аналогичный сранице с заполнением данных по авто 
    public partial class NewOrderPageBus : Page
    {
        public NewOrderPageBus()
        {
            InitializeComponent();
        }

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
        private void Button_Click_Submit_NewOrderPageBus(object sender, RoutedEventArgs e)
        {
            Window WindowOrderResult = new WindowOrderResult();
            WindowOrderResult.Show();            
        }
    }
}
