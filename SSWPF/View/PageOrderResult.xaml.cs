using SSWPF.Model;
using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{    

    public partial class PageOrderResult : Page
    {
        public PageOrderResult(Order o)
        {
            InitializeComponent();           
            GridPageOrderResult.DataContext = o;
        }        

        private void ButtonWindowOrderResultOk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Content = new MainPage();         
        }
    }
}
