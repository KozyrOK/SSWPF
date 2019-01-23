using System.Collections;
using System.Windows;
using System.Windows.Controls;
using SSWPF.Model;

namespace SSWPF.View
{ 
            
    public partial class ActualOrdersPage : Page
    {
        private IEnumerable actualOrders;

        public ActualOrdersPage()
        {
            InitializeComponent();           
            Loaded += ActualOrdersPage_Loaded;           
        }

        private void ActualOrdersPage_Loaded(object sender, RoutedEventArgs e)
        {
            actualOrders = Order.GetActualOrders();
            DataGridActualOrders.ItemsSource = actualOrders;
        }
    }
}
