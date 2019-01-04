using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using SSWPF.Model;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace SSWPF.View
{
    // Логика извлечения и отображения актуального прайслиста (последний объект Price в 
    // соответствующей таблице базы данных) и передача данных из прайслиста в EditPricelist()  

    public partial class PagePricelist : Page
    {
        Price currentPrice = new Price();
        
        public PagePricelist()
        {            
            InitializeComponent();
            Price.GetCurrentValuePrice(currentPrice);
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
