using SSWPF.Model;
using System.Windows.Controls;

namespace SSWPF.View
{    
    public partial class DoneOrdersPage : Page
    {
        public DoneOrdersPage()
        {
            InitializeComponent();
            var doneOrders = Order.GetDoneOrders();
            DataGridDoneOrders.ItemsSource = doneOrders;
        }
               
    }
}
