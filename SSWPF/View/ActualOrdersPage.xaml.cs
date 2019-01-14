using System.Windows.Controls;
using SSWPF.Model;

namespace SSWPF.View
{ 
            
    public partial class ActualOrdersPage : Page
    {        
        public ActualOrdersPage()
        {
            InitializeComponent();
            var actualOrders = Order.GetActualOrders();
            DataGridActualOrders.ItemsSource = actualOrders;
        }
    }
}
