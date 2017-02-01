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
using System.Windows.Shapes;

namespace Client.View
{
    public partial class AdminOrdersPageWindow : Window
    {
        public AdminOrdersPageWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FindOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var client = new WcfService.ServiceClient("BasicHttpBinding_IService");
            TextBox.Text = Convert.ToString(client.GetData());
            client.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}