using DiplomAnswerProject.Pages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiplomAnswerProject
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ClassTestContext())
            {
                var teacher = context.Teachers.FirstOrDefault(t => t.Login.Equals(LoginBox.Text));

                if(teacher != null && teacher.Parol.Equals(PasswordBox.Password))
                {
                    Global.TeacherLoggedIn = teacher;
                    var page = new SubjectsPage(this);
                    NavigationService.Navigate(page);
                }
            }
        }
    }
}
