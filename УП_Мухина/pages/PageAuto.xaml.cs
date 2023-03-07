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
        string str = String.Empty;
        public PageAuto()
        {
            InitializeComponent();
            tbLogin.Focus();
            btAuto.IsEnabled = false;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            tbTime.Visibility = Visibility.Visible;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time--;
            tbTime.Text = " " + time + " секунд";
            if (time < 0)
            {
                timer.Stop();
                btAuto.IsEnabled = true;
                tbTime.Visibility = Visibility.Collapsed;
            }
        }

        private void tbAuto_Click(object sender, RoutedEventArgs e)
        {
            User user = DataBase.Base.User.FirstOrDefault(z => z.UserLogin == tbLogin.Text && z.UserPassword == tbPassword.Password);
            if (user==null)
            {
                MessageBox.Show("Вы вели данные неверно!");
                spCaptcha.Visibility = Visibility.Visible;
            }
            else
            {
                ClassFrame.frameL.Navigate(new pages.ListOfTovar());
            }
        }

        private void tbGuest_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.frameL.Navigate(new pages.ListOfTovar());
        }

        private void tbCaptcha_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbCaptcha.Text.Length == str.Length)
            {
                if (tbCaptcha.Text == str)
                {

                }
            }
        }
    }
}
