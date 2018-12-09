using System.Windows;
using SSWPF.Model;

namespace SSWPF
{
    public partial class MainWindow : Window
    {
        // Создание переменной Price (актуальная цена) для страниц.  
        //Price CurrentPrice;
        //CurrentPrice = Price.GetCurrentValuePrice();            
        //if (CurrentPrice == null)
        //CurrentPrice = new Price {DataTimePrice = DateTime.Now,
        //                                  CarBody = 0, 
        //                                  CarWheels = 0,   
        //                                  CarEngine = 0,
        //                                  CarBrakes = 0,
        //                                  CarUndercarriage = 0,
        //                                  BusSalon = 0,
        //                                  BusHandsrails = 0,
        //                                  BusUpholstery = 0,
        //                                  PasCarwheelBalancing = 0,
        //                                  TruckHydraulics = 0};
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
