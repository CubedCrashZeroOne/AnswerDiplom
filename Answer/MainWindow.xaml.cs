﻿using System;
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

namespace DiplomAnswerProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ThemeHandler.ChangeThemeAndSkin("Light", "Blue");
            MainFrame.Content = new StartPage();
            using (var context = new ClassTestContext())
            {
                context.Answers.ToList();
            }
        }

        private void ChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            var window = new StyleWindow();
            window.ShowDialog();
        }
    }
}
