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

namespace DiplomAnswerProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для SubjectsPage.xaml
    /// </summary>
    public partial class SubjectsPage : Page
    {
        private StartPage _prevPage;

        public SubjectsPage(StartPage prevPage)
        {
            _prevPage = prevPage;
            InitializeComponent();
            using (var context = new ClassTestContext())
            {
                var testsQuery = from s in context.Subjects
                        join ts in context.TeachSubs
                        on s.IdSub equals ts.IdSub
                        join t in context.Teachers
                        on ts.IdTeach equals t.IdTeach
                        join ct in context.CountTests
                        on s.IdSub equals ct.IdSub
                        where t.IdTeach == Global.TeacherLoggedIn.IdTeach
                        select new { idSub = s.IdSub, 
                            nameSub = s.NameSub, 
                            shortNameSub = s.ShortNameSub,
                            count = ct.Kol
                        };
                testDataGrid.Items.Clear();
                testDataGrid.ItemsSource = testsQuery.ToList();

                
            }
        }

        private void TestOkButton_Click(object sender, RoutedEventArgs e)
        {
            dynamic selected = testDataGrid.SelectedItem;
            if (selected == null) { return; }
            var page = new TestsPage(selected.idSub, this);
            NavigationService.Navigate(page);
        }

        private void TestBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(_prevPage);
        }
    }
}
