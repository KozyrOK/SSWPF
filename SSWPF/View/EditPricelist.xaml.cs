using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{
    public partial class EditPricelist : Page
    {

        Price newp = new Price();
                
        public EditPricelist(Price p)
        {
            InitializeComponent();
            newp = p;
            EditPricelistGrid.DataContext = p;
        }

        private void Button_Click_Back_EditPricelist(object sender, RoutedEventArgs e)
        {            
            NavigationService.GoBack();            
        }

        private void Button_Click_Save_Pricelist(object sender, RoutedEventArgs e)
        {
            newp.AddNewPrice();
            NavigationService.GoBack();
        }
    }
}
