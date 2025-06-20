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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            MaterialsGrid.ItemsSource = Vars.Materials;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddPage());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var selected = (AllMaterials)MaterialsGrid.SelectedItem;
            if (selected != null)
                NavigationService?.Navigate(new EditPage(selected));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selected = (AllMaterials)MaterialsGrid.SelectedItem;
            if (selected != null)
            {
                Vars.Materials.Remove(selected);
                MaterialsGrid.Items.Refresh();
            }
        }

        /*
         можно ещё вот так с попапом
        private void Delete_Click(object sender, RoutedEventArgs e)
{
    var selected = (AllMaterials)MaterialsGrid.SelectedItem;
    if (selected != null)
    {
        var result = MessageBox.Show(
            $"Вы уверены, что хотите удалить \"{selected.Name}\"?",
            "Удаление",
            MessageBoxButton.YesNo,
            MessageBoxImage.Warning);

        if (result == MessageBoxResult.Yes)
        {
            Vars.Materials.Remove(selected);
            MaterialsGrid.Items.Refresh(); // Обновление таблицы
        }
    }
    else
    {
        MessageBox.Show("Выберите элемент для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}

         */
    }
}
