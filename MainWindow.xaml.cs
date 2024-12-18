using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Product
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Products = new ObservableCollection<Product>()
            {
                new Product { Image = "Фото", Name = "Название", Description = "Описание", Manufacturer = "Производитель", Price = "Цена", StockQuantity = "Наличие на складе"},
                new Product { Image = "Фото", Name = "Название", Description = "Описание", Manufacturer = "Производитель", Price = "Цена", StockQuantity = "Наличие на складе"},
                new Product { Image = "Фото", Name = "Название", Description = "Описание", Manufacturer = "Производитель", Price = "Цена", StockQuantity = "Наличие на складе"},
                new Product { Image = "Фото", Name = "Название", Description = "Описание", Manufacturer = "Производитель", Price = "Цена", StockQuantity = "Наличие на складе"},
                new Product { Image = "Фото", Name = "Название", Description = "Описание", Manufacturer = "Производитель", Price = "Цена", StockQuantity = "Наличие на складе"},
                new Product { Image = "Фото", Name = "Название", Description = "Описание", Manufacturer = "Производитель", Price = "Цена", StockQuantity = "Наличие на складе"},
                new Product { Image = "Фото", Name = "Название", Description = "Описание", Manufacturer = "Производитель", Price = "Цена", StockQuantity = "Наличие на складе"}
            };
        }
    }
}