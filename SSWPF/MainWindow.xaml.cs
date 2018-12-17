using System;
using System.Windows;
using SSWPF.Model;

namespace SSWPF
{
    public partial class MainWindow : Window
    {               
        
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
