using SSWPF.Model;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{
    
    public partial class EditPricelist : Page
    {
        private Price e;
                
        public EditPricelist(Price p)
        {
            InitializeComponent();
            e = p;
            EditPricelistGrid.DataContext = p;
        }

        private void Button_Click_Back_EditPricelist(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void Button_Click_Save_Pricelist(object sender, RoutedEventArgs e)
        {
            Price.AddNewPrice(this.e);
        }
    }
}
