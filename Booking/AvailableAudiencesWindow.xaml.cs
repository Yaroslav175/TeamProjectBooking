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
    /// Логика взаимодействия для AvailableAudiencesWindow.xaml
    /// </summary>
    public partial class AvailableAudiencesWindow : Window
    {
        private IRepository _repository = Factory.Instance.GetRepository();

        public AvailableAudiencesWindow()
        {
            InitializeComponent();
        }

        private void comboBoxBuldings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBoxFloors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGridSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonFavourites_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
