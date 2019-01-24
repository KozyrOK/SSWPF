using System.Windows;
using System.Windows.Controls;
using SSWPF.Model;

namespace SSWPF.View
{
    
    public partial class PagePricelist : Page
    {
        Price currentPrice;

        public PagePricelist()
        {            
            InitializeComponent();
            Loaded += PagePricelist_Loaded;            
        }

        private void PagePricelist_Loaded(object sender, RoutedEventArgs e)
        {
            Price forId = new Price(); 
            int id = forId.LastPriceId();            
            if (id > 0)
            {                
                currentPrice = new Price(id);
            }
            else
            {
                currentPrice = new Price();
                currentPrice.AddFirstPriceDB();
            }
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
