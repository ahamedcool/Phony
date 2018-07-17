﻿using MahApps.Metro.Controls;
using System.Windows.Controls;

namespace Phony.Views
{
    /// <summary>
    /// Interaction logic for Users.xaml
    /// </summary>
    public partial class Users : MetroWindow
    {
        public Users()
        {
            InitializeComponent();
        }

        private void p1_PasswordChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                ((ViewModels.UsersViewModel)this.DataContext).Password1 = ((PasswordBox)sender).SecurePassword;
            }
        }

        private void p2_PasswordChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                ((ViewModels.UsersViewModel)this.DataContext).Password2 = ((PasswordBox)sender).SecurePassword;
            }
        }
    }
}