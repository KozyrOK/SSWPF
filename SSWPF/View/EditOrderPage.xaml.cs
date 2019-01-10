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
    public partial class EditOrderPage : Page
    {
        private Order idOrderEdit;

        public EditOrderPage(Order idOrder)
        {            
            InitializeComponent();
            this.idOrderEdit = idOrder;
            EditOrderPageGrid.DataContext = idOrder;            
        }

        private void Button_Click_Back_EditOrderPage(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_OK_EditOrderPage(object sender, RoutedEventArgs e)
        {            
            Order.EditOrder(this.idOrderEdit);
            NavigationService.Navigate(new MainPage());
        }
    }
}
