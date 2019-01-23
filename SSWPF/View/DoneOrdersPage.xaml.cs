using SSWPF.Model;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{    
    public partial class DoneOrdersPage : Page
    {
        private IEnumerable doneOrders;

        public DoneOrdersPage()
        {
            InitializeComponent();
            Loaded += DoneOrdersPage_Loaded;            
        }

        private void DoneOrdersPage_Loaded(object sender, RoutedEventArgs e)
        {
            doneOrders = Order.GetDoneOrders();
            DataGridDoneOrders.ItemsSource = doneOrders;
        }
    }
}
