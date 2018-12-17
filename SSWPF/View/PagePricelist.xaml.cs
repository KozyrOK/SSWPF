using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using SSWPF.Model;

namespace SSWPF.View
{
    // Логика извлечения и отображения актуального прайслиста (последний объект Price в 
    // соответствующей таблицы базы данных) и передача данных из прайслиста в EditPricelist()  

    public partial class PagePricelist : Page
    {
       
        public PagePricelist()
        {
            InitializeComponent();            
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
            NavigationService.Navigate(new EditPricelist());
        }                
    }
}
