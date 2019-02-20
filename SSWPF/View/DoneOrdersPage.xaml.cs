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
            OrderDB order = new OrderDB();
            doneOrders = order.GetDoneOrders();
            DataGridDoneOrders.ItemsSource = doneOrders;
        }
    }
}
