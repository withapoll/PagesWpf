using PagesWpf.DTO;
using PagesWpf.GlobalVariables;
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
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Vars.Materials.Add(new AllMaterials
            {
                Id = Vars.Materials.Count + 1,
                Name = NameBox.Text,
                Price = int.TryParse(PriceBox.Text, out var price) ? price : 0
            });
            NavigationService.GoBack();
        }
    }
}
