using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{
    public partial class EditPricelist : Page
    {
        Price newP = new Price();        

        public EditPricelist(Price currentPrice)
        {
            InitializeComponent();
            newP = currentPrice;
            EditPricelistGrid.DataContext = newP;                     
        }        

        private void Button_Click_Back_EditPricelist(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Save_Pricelist(object sender, RoutedEventArgs e)
        {            
            newP.AddNewPriceDB();
            NavigationService.GoBack();
        }
    }
}
