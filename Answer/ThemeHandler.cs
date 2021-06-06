using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DiplomAnswerProject
{
    internal static class ThemeHandler
    {
        public static string CurrentTheme { get; private set; }
        public static string CurrentSkin { get; private set; }

        public static void ChangeThemeAndSkin(string theme, string skin)
        {
            // Locating resource dictionaries.
            var themeUri = new Uri(@"Themes\" + theme + "ThemeDictionary.xaml", UriKind.Relative);
            var skinUri = new Uri(@"Skins\" + skin + "SkinDictionary.xaml", UriKind.Relative);

            // Converting to RDs.
            ResourceDictionary themeRD = Application.LoadComponent(themeUri) as ResourceDictionary;
            ResourceDictionary skinRD = Application.LoadComponent(skinUri) as ResourceDictionary;
            
            // Clearing existing RDs.
            Application.Current.Resources.Clear();

            // Adding the RDs we need.
            Application.Current.Resources.MergedDictionaries.Add(themeRD);
            Application.Current.Resources.MergedDictionaries.Add(skinRD);

            // Saving which themes are currently used.
            CurrentTheme = theme;
            CurrentSkin = skin;
        }
    }
}
