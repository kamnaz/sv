﻿using System;
using System.Reflection;
using System.Windows;


namespace SimuVault
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            txtAppName.Text = "SimuVault";
            txtVersion.Text = "Version: " + myAssembly.GetName().Version.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
