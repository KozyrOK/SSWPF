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
            this.Loaded += DoneOrdersPage_Loaded;
            DataGridDoneOrders.ItemsSource = doneOrders;
        }

        private void DoneOrdersPage_Loaded(object sender, RoutedEventArgs e)
        {
            doneOrders = Order.GetDoneOrders();
        }
    }
}
