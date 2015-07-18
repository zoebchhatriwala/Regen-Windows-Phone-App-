using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WACC.Resources;


namespace WACC
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }
       
        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show("I Generate Password Based on RE");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text += "w";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tb1.Text += "W";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tb1.Text += "S";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tb1.Text += "N";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tb1.Text += "A";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (tb1.Text.Length >= 1)
            {
                string temp = tb1.Text.Remove(tb1.Text.Length - 1);
                tb1.Text = temp;
            }
            }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            op.Text = "";
            char[] special = { '!', '@', '#', '$', '&', '*', '?', '+', '-', '/', '%', '.' };
            if (tb1.Text.Length >= 1)
            {
                int x = 0;
                Random rand = new Random(DateTime.Now.Millisecond);
                while (x != tb1.Text.Length)
                {
                    char temp = tb1.Text.ElementAt(x);
                    x++;
                re:
                    if (temp == 'S')
                    {
                        op.Text += special[rand.Next(0, 12)];
                        
                    }
                    else if(temp=='w')
                    {
                        op.Text += (char)rand.Next(97,123);
                    }
                    else if (temp == 'W')
                    {
                        op.Text += (char)rand.Next(65,91);
                    }
                    else if (temp == 'N')
                    {
                        op.Text += (char)rand.Next(48,58);
                    }
                    else if (temp == 'A')
                    {
                        char[] any = {'S','w','W','N'};
                        temp = any[rand.Next(0,4)];
                        goto re;
                    }
                }
            }
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Regen is a Regular Expression based Text/Password Generator\nDeveloped by: Zoeb Chhatriwala\nInspiration: Microsoft Student Partner");
        }

        private void cpy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(op.Text);
        }
        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}