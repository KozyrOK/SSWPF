using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using SSWPF.Model;

namespace SSWPF.View
{
    
    public partial class PagePricelist : Page
    {
       
        public PagePricelist()
        {
            InitializeComponent();            
        }
      
        private void Button_Click_Back_Pricelist(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void Button_Click_Edit_Pricelist(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EditPricelist());
        }
                
    }
}
