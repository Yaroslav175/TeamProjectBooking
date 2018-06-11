using System;
using System.Windows;
using System.Windows.Input;
using ClassLibrary;
using ClassLibrary.Interfaces;
using System.Windows.Controls;

namespace Booking
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IRepository _repository = Factory.Instance.GetRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
