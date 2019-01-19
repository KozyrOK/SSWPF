using System.Windows;
using System.Windows.Controls;
using SSWPF.Model;

namespace SSWPF.View
{
    
    public partial class PagePricelist : Page
    {

        Price currentPrice = new Price();
        
        public PagePricelist()
        {            
            InitializeComponent();
            this.Loaded += PagePricelist_Loaded;            
            PagePricelistGrid.DataContext = currentPrice;
        }

        private void PagePricelist_Loaded(object sender, RoutedEventArgs e)
        {
            currentPrice.GetCurrentValuePrice();
        }

        private void Button_Click_Back_Pricelist(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void Button_Click_Edit_Pricelist(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPricelist(currentPrice));
        }                
    }
}
