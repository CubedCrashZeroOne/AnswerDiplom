using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
    /// Логика взаимодействия для TestsPage.xaml
    /// </summary>
    public partial class TestsPage : Page
    {
        SubjectsPage _prevPage;
        public TestsPage(int subjectId, SubjectsPage prevPage)
        {
            _prevPage = prevPage;
            InitializeComponent();
            using (var context = new ClassTestContext())
            {

                var testsQuery = from t in context.Tests
                                 where (t.IdSub == subjectId)
                                 select new
                                 {
                                     idTest = t.IdTest,
                                     nameTest = t.NameTest,
                                 };
                testDataGrid.Items.Clear();
                testDataGrid.ItemsSource = testsQuery.ToList();

            }
        }

        private void TestBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(_prevPage);
        }

        private void TestOkButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
