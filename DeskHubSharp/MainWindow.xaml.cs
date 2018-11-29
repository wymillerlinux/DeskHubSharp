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
using System.Collections.ObjectModel;

namespace DeskHubSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SearchWindow search = new SearchWindow();

        public MainWindow()
        {
            InitializeComponent();
            ShowDataGridItems();
        }

        private void btn_detail_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detail = new DetailWindow();
            detail.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_about_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog();
        }

        private void btn_feedback_Click(object sender, RoutedEventArgs e)
        {
            FeedbackWindow feedback = new FeedbackWindow();
            feedback.ShowDialog();
        }

        private void btn_help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.ShowDialog();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            search.ShowDialog();
            ObservableCollection<RepoDetail> test = RepoList.repoDetail;
            DataGrid.ItemsSource = test;

            RepoDetail rp = new RepoDetail();
            rp.Owner.avatar_url
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void ShowDataGridItems()
        {
            DataGrid.ItemsSource = RepoList.repoDetail;
        }

    }
}
