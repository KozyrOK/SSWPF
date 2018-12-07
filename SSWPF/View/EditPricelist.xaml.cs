using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{
    
    public partial class EditPricelist : Page
    {     

        public EditPricelist()
        {
            InitializeComponent();            
        }
        
        private void Button_Click_Back_EditPricelist(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void Button_Click_Save_Pricelist(object sender, RoutedEventArgs e)
        {
                  
        }
    }
}
