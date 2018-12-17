using SSWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SSWPF.View
{
    // Oкно с данными о заказе и его стоимости и переход на главную страницу

    public partial class WindowOrderResult : Window
    {
        public WindowOrderResult(Order o)
        {
            InitializeComponent();
            //GridWindowOrderResult.DataSource = o;
        }

        private void ButtonWindowOrderResultOk_Click(object sender, RoutedEventArgs e)
        {
            Close();            
        }
    }
}
