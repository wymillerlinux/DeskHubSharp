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
using System.Windows.Shapes;

namespace DeskHubSharp
{
    /// <summary>
    /// Interaction logic for FeedbackWindow.xaml
    /// </summary>
    public partial class FeedbackWindow : Window
    {
        public FeedbackWindow()
        {
            InitializeComponent();
        }

        private void btn_discard_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_send_Click(object sender, RoutedEventArgs e)
        {
            Email email = new Email(txtbox_name, txtbox_feedbackmessage);
            email.CreateMessage();
        }
    }
}
