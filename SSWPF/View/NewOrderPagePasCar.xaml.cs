using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;

namespace SSWPF.View
{
    // 
    // появление информационного окна с данными о заказе и его стоимости и переход на главную страницу
    public partial class NewOrderPagePasCar : Page
    {
               
        public NewOrderPagePasCar()
        {
            
        }               

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void Button_Click_Submit_NewOrderPagePasCar(object sender, RoutedEventArgs e)
        {                      
            

        }
    }
}
