using Praktika.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
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
using static System.Net.Mime.MediaTypeNames;

namespace Praktika.View
{
    /// <summary>
    /// Логика взаимодействия для AMONIC_Airlines_Automation_System.xaml
    /// </summary>
    public partial class AMONIC_Airlines_Automation_System : Window
    {

        Session1_XXEntities db = new Session1_XXEntities();
        public AMONIC_Airlines_Automation_System()
        {
            InitializeComponent();
            CmbOffice.ItemsSource = AppData.db.Offices.ToList();
            if (MainWindow.Globals.UserRoles == 1) //разгранечение ролей
            {
                Add_Btn.Visibility = Visibility.Visible;

            }
            else
            {
                Add_Btn.Visibility = Visibility.Collapsed;
                Change_Btn.Visibility = Visibility.Collapsed;
            }
            var officesese = Session1_XXEntities.GetContext().Offices.ToList();
            officesese.Insert(0, new Offices
            {
                Title = "All offices"
            });
            CmbOffice.SelectedIndex = 0;
            CmbOffice.ItemsSource = officesese;
            UpdateTable();
        }
        public void UpdateTable()
        {
            var thisUsers = db.Users.ToList();
            if (CmbOffice.SelectedIndex > 0 && CmbOffice.SelectedIndex != 1)
            {
                thisUsers = thisUsers.Where(p => p.OfficeID ==CmbOffice.SelectedIndex + 1).ToList();
            }
            else if (CmbOffice.SelectedIndex == 1)
            {
                thisUsers = thisUsers.Where(p => p.Offices.Title == "Abu dhabi").ToList();
            }
            UsersGrid.ItemsSource = thisUsers;
        }
        private void Add_Btn_Click(object sender, RoutedEventArgs e) 
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void Exit_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UsersGrid.ItemsSource = AppData.db.Users.ToList(); 
        }

        private void Change_Btn_Click(object sender, RoutedEventArgs e) //кнопка смены ролей
        {
            Users user = UsersGrid.SelectedItem as Users;
            if (user.RoleID == 1)
            {
                user.RoleID = 2;
                MessageBox.Show("Роль изменена на " + "User");
            }
            else
            {
                user.RoleID = 1;
                MessageBox.Show("Роль изменена на " + "Administrator");
            }
            Session1_XXEntities.GetContext().SaveChanges();
            UpdateTable();
           
        }

        private void Enable_Click(object sender, RoutedEventArgs e) //кнопка включения логина
        {
            Users user = UsersGrid.SelectedItem as Users;
            if (user.Active == true)
            {
                user.Active = false;
                MessageBox.Show("Off");
                UsersGrid.Items.Refresh();
            }
            else
            {
                user.Active = true;
                MessageBox.Show("On");
                UsersGrid.Items.Refresh();
            }
            Session1_XXEntities.GetContext().SaveChanges();
            AppData.db.SaveChanges();
        }
        private void Refresh_Click(object sender, RoutedEventArgs e) //кнопка обновления
        {
            UsersGrid.ItemsSource = AppData.db.Users.ToList();
        }

        private void All_offices(object sender, SelectionChangedEventArgs e)
        {
            UpdateTable();
        }

    }
}
