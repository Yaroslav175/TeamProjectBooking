using ClassLibrary;
using ClassLibrary.Interfaces;
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
using System.Windows.Shapes;

namespace Booking
{
    /// <summary>
    /// Логика взаимодействия для DataSelectWindow.xaml
    /// </summary>
    public partial class DataSelectWindow : Window
    {
        IRepository _repo = Factory.Instance.GetRepository();
        DataViewModel _data = new DataViewModel();
        public DataSelectWindow()
        {
            InitializeComponent();
            BuildAddress();
        }
       public void BuildAddress()
        {
            var buildings = _repo.Buildings.OrderBy(b => b.Address).ToList();
        }

        private void ComboboxAddress_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = ComboboxAddress.SelectedItem as DataViewModel;
            
        }

        private void ComboboxDay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = ComboboxDay.SelectedItem as DataViewModel;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            if(Comp.IsChecked ?? false)
            {
                Comp.Content = _data;
            }
        }

        private void Results_Click(object sender, RoutedEventArgs e)
        {
            var showDataWindow = new ShowDataWindow();

        }
    }
}
