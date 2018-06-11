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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

        IRepository _repo = Factory.Instance.GetRepository();

        public event Action RegistrationFinished;

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            var user = new User
            {
                Name = textBoxName.Text,                
                Login = textBoxLogin.Text,
                Password = Password.GetHash(passwordBox.Password)
            };
            try
            {
                _repo.RegisterUser(user);
                RegistrationFinished?.Invoke();
                Close();
            }
            catch
            {
                MessageBox.Show("An error occured trying to save new user");
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            RegistrationFinished?.Invoke();
            Close();
        }
    }
}
