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

namespace DeskHubSharp
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {

        private Request _request;

        public SearchWindow()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_query.Text == "")
            {
                ErrorWindow err = new ErrorWindow();
                err.txtblk_error.Text = "Please enter a username!";
                err.ShowDialog();
            }
            else
            {
                _request = new Request(txtbox_query.Text);
                _request.PerformSearchRequest();
                _request.PerformUserRequest();
                this.Close();
            }

        }
    }
}
