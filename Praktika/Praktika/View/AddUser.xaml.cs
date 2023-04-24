using Praktika.Model;
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

namespace Praktika.View
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            CmbAddUser.ItemsSource = AppData.db.Offices.ToList();
            CmbRole.ItemsSource = AppData.db.Roles.ToList();
            this.CmbRole.SelectedIndex = 1;

        }

        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {
            Users people = new Users();
            people.Email = EmailTB.Text;
            people.FirstName = FnameTB.Text;
            people.LastName = LnameTB.Text;

            var CurrentOffice = CmbAddUser.SelectedItem as Offices;
            people.OfficeID = CurrentOffice.ID;

            var CurrentDate = Calendar.SelectedDate.Value;
            people.Birthdate = CurrentDate;

            people.Password = PassTB.Text;

            var CurrentRole = CmbRole.SelectedItem as Roles;
            people.RoleID = CurrentRole.ID;

            AppData.db.Users.Add(people);
            AppData.db.SaveChanges();
            AMONIC_Airlines_Automation_System aMONIC = new AMONIC_Airlines_Automation_System();
            aMONIC.UsersGrid.Items.Refresh();
            MessageBox.Show("Add complete!");
            this.Close();
        }

        private void Exit_Btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
