using Praktika.Model;
using Praktika.View;
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

namespace Praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static class Globals //класс для разгранечения ролей
        {
            public static int UserRoles;
            public static Users userinfo { get; set; }
        }

        private void Login_Click(object sender, RoutedEventArgs e) // кнопка входа
        {
            var CurrentUser = AppData.db.Users.FirstOrDefault(u => u.FirstName == TxbUsername.Text && u.Password == TxbPass.Text); //проверка логина и пароля
            if (CurrentUser != null)
            {
                Globals.UserRoles = CurrentUser.RoleID;
                Globals.userinfo = CurrentUser;
                AMONIC_Airlines_Automation_System aMONIC_win = new AMONIC_Airlines_Automation_System();
                aMONIC_win.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
