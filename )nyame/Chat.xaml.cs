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

namespace _nyame
{
    public partial class Chat : Window
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void autorization_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConectChat connect = new ConectChat();
                connect.Show();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void new_chat_Click(object sender, RoutedEventArgs e)
        {
            chatik.Content = new serv();
        }
    }
}
