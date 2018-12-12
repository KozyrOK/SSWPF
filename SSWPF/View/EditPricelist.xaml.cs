using SSWPF.Model;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SSWPF.View
{
    
    public partial class EditPricelist : Page
    {
        // Логика редактирования прайслиста и записи изменений

        //public Price EditPricelistVariable { get; set; }
        public EditPricelist()
        {
            InitializeComponent();

            //EditPricelistVariable = new Price
            //{
            //    PriceId = 1,
            //    DataTimePrice = DateTime.Now,
            //    CarBody = 0,
            //    CarWheels = 0,
            //    CarEngine = 0,
            //    CarBrakes = 0,
            //    CarUndercarriage = 0,
            //    BusSalon = 0,
            //    BusHandsrails = 0,
            //    BusUpholstery = 0,
            //    PasCarwheelBalancing = 0,
            //    TruckHydraulics = 0
            //};

            //EditPricelistGrid.DataContext = this;
        }

        private void Button_Click_Back_EditPricelist(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void Button_Click_Save_Pricelist(object sender, RoutedEventArgs e)
        {
                  
        }
    }
}
