using System;
using System.Windows;
using SSWPF.Model;

namespace SSWPF
{
    public partial class MainWindow : Window
    {
        // Создание (извлечение из базы данных) переменной Price (актуальная цена) для страниц.
        // Передача переменной для других страницы (страница с прайс-листом, и страница для заполнения нового заказа)  
        // Возможно, данная логика может быть отображена в файле App.xaml.cs        
        
    public MainWindow()
        {
            InitializeComponent();
            MainWindowFrame.Content = new View.MainPage();

            //Price currentPrice = new Price();
            //Price.InitializationDataPrice(currentPrice);
            //Price.AddNewPrice(currentPrice);
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
