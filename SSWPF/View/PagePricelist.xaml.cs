using System.Windows;
using System.Windows.Controls;
using SSWPF.Model;

namespace SSWPF.View
{    
    public partial class PagePricelist : Page
    {
        public Price currentPrice;

        public PagePricelist()
        {            
            InitializeComponent();
            Loaded += PagePricelist_Loaded;            
        }

        private void PagePricelist_Loaded(object sender, RoutedEventArgs e)
        {
            Price price = new Price(1);
            currentPrice = price;
            PagePricelistGrid.DataContext = currentPrice;
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
