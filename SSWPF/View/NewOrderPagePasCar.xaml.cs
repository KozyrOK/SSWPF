using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;

namespace SSWPF.View
{
    // Форма для заполнения данных для нового заказа, его занесения в базу данных
    // Появление информационного окна с данными о заказе и его стоимости (WindowOrderResult.xaml)
    // и последующий переход на главную страницу 

    public partial class NewOrderPagePasCar : Page
    {
               
        public NewOrderPagePasCar(Price p)
        {
            InitializeComponent();
        }               

        private void Button_Click_Back_NewOrderPage(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void Button_Click_Submit_NewOrderPagePasCar(object sender, RoutedEventArgs e)
        {
            // Логика записи введенных данных и подсчета общей стоимости заказа. 
            // Появление всплывающего окна (WindowOrderResult.xaml) с частью введенных данных 
            // и общей стоимостью заказа.
        }
    }
}
