using System.Windows;

namespace SSWPF
{
    public partial class MainWindow : Window
    {               
        
    public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;                                   
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new View.MainPage();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
            {
                MainWindowFrame.Content = new View.PageInfo();
            }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
            {
                MainWindowFrame.Content = new View.MainPage();
            }

        private void Pricelist_Click(object sender, RoutedEventArgs e)
            {
                MainWindowFrame.Content = new View.PagePricelist();
            }
        
    }
}
