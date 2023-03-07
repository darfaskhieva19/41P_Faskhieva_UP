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
using System.Windows.Threading;

namespace УП_Мухина
{
    /// <summary>
    /// Логика взаимодействия для PageAuto.xaml
    /// </summary>
    public partial class PageAuto : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        int time = 10;

        public PageAuto()
        {
            InitializeComponent();
            tbPassword.Focus();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time--;
            
        }

        private void tbAuto_Click(object sender, RoutedEventArgs e)
        {
            User user = DataBase.Base.User.FirstOrDefault(z => z.UserLogin == tbLogin.Text && z.UserPassword == tbPassword.Password);
            if (user != null)
            {
                ClassFrame.frameL.Navigate(new pages.ListOfTovar());
               // MessageBox.Show("Пользователя не существует!", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

            }
        }

        private void tbGuest_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.frameL.Navigate(new pages.ListOfTovar());
        }

        private void tbCaptcha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
