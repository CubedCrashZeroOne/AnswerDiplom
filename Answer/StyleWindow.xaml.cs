using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DiplomAnswerProject
{
    /// <summary>
    /// Логика взаимодействия для StyleWindow.xaml
    /// </summary>
    public partial class StyleWindow : Window
    {
        public StyleWindow()
        {
            InitializeComponent();
            RadioInitialCheck();
        }

        private void RadioInitialCheck()
        {
            switch (ThemeHandler.CurrentTheme)
            {
                case "Light":
                    RadioLight.IsChecked = true;
                    break;
                case "Dark":
                    RadioDark.IsChecked = true;
                    break;
            }
            switch (ThemeHandler.CurrentSkin)
            {
                case "Blue":
                    RadioBlue.IsChecked = true;
                    break;
                case "Green":
                    RadioGreen.IsChecked = true;
                    break;
                case "Purple":
                    RadioPurple.IsChecked = true;
                    break;
                case "Yellow":
                    RadioYellow.IsChecked = true;
                    break;
                case "Magenta":
                    RadioMagenta.IsChecked = true;
                    break;
            }
        }

        private void RadioLight_Checked(object sender, RoutedEventArgs e)
        {
            ThemeHandler.ChangeThemeAndSkin("Light", ThemeHandler.CurrentSkin);
        }

        private void RadioDark_Checked(object sender, RoutedEventArgs e)
        {
            ThemeHandler.ChangeThemeAndSkin("Dark", ThemeHandler.CurrentSkin);
        }

        private void RadioBlue_Checked(object sender, RoutedEventArgs e)
        {
            ThemeHandler.ChangeThemeAndSkin(ThemeHandler.CurrentTheme, "Blue");
        }

        private void RadioGreen_Checked(object sender, RoutedEventArgs e)
        {
            ThemeHandler.ChangeThemeAndSkin(ThemeHandler.CurrentTheme, "Green");
        }

        private void RadioPurple_Checked(object sender, RoutedEventArgs e)
        {
            ThemeHandler.ChangeThemeAndSkin(ThemeHandler.CurrentTheme, "Purple");
        }

        private void RadioYellow_Checked(object sender, RoutedEventArgs e)
        {
            ThemeHandler.ChangeThemeAndSkin(ThemeHandler.CurrentTheme, "Yellow");
        }

        private void RadioMagenta_Checked(object sender, RoutedEventArgs e)
        {
            ThemeHandler.ChangeThemeAndSkin(ThemeHandler.CurrentTheme, "Magenta");
        }
    }
}
