using PagesWpf.DTO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PagesWpf.Pages
{
    /// <summary>
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private AllMaterials _item;

        public EditPage(AllMaterials item)
        {
            InitializeComponent();
            _item = item;

            NameBox.Text = item.Name;
            PriceBox.Text = item.Price.ToString();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            _item.Name = NameBox.Text;
            _item.Price = int.TryParse(PriceBox.Text, out var price) ? price : _item.Price;
            NavigationService.GoBack();
        }
    }
}
