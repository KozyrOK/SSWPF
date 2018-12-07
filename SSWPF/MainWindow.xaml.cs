using System.Data.Entity;
using System.Windows;
using SSWPF.Model;
using System.Linq;
using System.Collections.Generic;

namespace SSWPF
{
    public partial class MainWindow : Window
    {       
        //Инициализация базы данных цены ремонта
        public MainWindow()
        {
            InitializeComponent();
            MainWindowFrame.Content = new View.MainPage();         
            
        }
            private void Info_Click(object sender, RoutedEventArgs e)
            {
                MainWindowFrame.Content = new SSWPF.View.PageInfo();
            }

            private void MainMenu_Click(object sender, RoutedEventArgs e)
            {
                MainWindowFrame.Content = new SSWPF.View.MainPage();
            }

            private void Pricelist_Click(object sender, RoutedEventArgs e)
            {
                MainWindowFrame.Content = new SSWPF.View.PagePricelist();
            }
        
    }
}
