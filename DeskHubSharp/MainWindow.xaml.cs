using System;
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
        private ObservableCollection<RepoDetail> _repoDetail;
        private User _userDetail;
        private Request _request;
        private RepoInfo _repoInfo;

        public MainWindow()
        {
            InitializeComponent();
            //ShowDataGridItems();
        }

        private void btn_detail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _repoDetail = RequestList.repoDetail;
                RepoDetail repo = _repoDetail[ListBox.SelectedIndex];
                DetailWindow detail = new DetailWindow(repo);
                detail.Show();
            }
            catch (IndexOutOfRangeException)
            {
                ShowErrorMessage("Please pick a repository!");
            }
            catch (NullReferenceException)
            {
                ShowErrorMessage("Please search for a user with the Search button!");
            }
            catch (ArgumentOutOfRangeException)
            {
                ShowErrorMessage("MEME REVIEW!");
            }

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
            SearchWindow search = new SearchWindow();
            search.ShowDialog();
            RepoInfo info = new RepoInfo();

            var stuff = info.GetRepoInfoList();

            if (stuff.Count == 0)
            {
                txtblk_username.Text = txtblk_username.Text;
                txtblk_url.Text = txtblk_url.Text;
                txtblk_bio.Text = txtblk_bio.Text;
                txtblk_email.Text = txtblk_email.Text;
                txtblk_realname.Text = txtblk_realname.Text;
            }
            else
            {
                _userDetail = RequestList.userDetail;
                ListBox.ItemsSource = stuff;
                txtblk_username.Text = _userDetail.login;
                txtblk_url.Text = _userDetail.html_url;
                txtblk_bio.Text = _userDetail.bio;
                txtblk_email.Text = _userDetail.blog;
                txtblk_realname.Text = _userDetail.name;
                txtblk_repocount.Text = $"{_userDetail.login} has {_userDetail.public_repos} public repositories.";
            }
        }

        public void ShowErrorMessage(string message)
        {
            ErrorWindow err = new ErrorWindow();
            err.txtblk_error.Text = message;
            err.ShowDialog();
        }
    }
}
