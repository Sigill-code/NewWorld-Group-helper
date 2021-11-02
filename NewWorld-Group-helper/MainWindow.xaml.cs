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

namespace NewWorld_Group_helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (Grid_New_Player.Visibility == Visibility.Visible)
            {
                Grid_Search_Player.Visibility = Visibility.Hidden;
                Grid_New_Player.Visibility = Visibility.Hidden;
                Grid_Search_Role.Visibility = Visibility.Hidden;
            }
            else
            {
                Grid_New_Player.Visibility = Visibility.Visible;
                Grid_Search_Player.Visibility = Visibility.Hidden;
                Grid_Search_Role.Visibility = Visibility.Hidden;
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            // add player info to db
        }

        private void btnSearchPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (Grid_Search_Player.Visibility == Visibility.Visible)
            {
                Grid_New_Player.Visibility = Visibility.Hidden;
                Grid_Search_Player.Visibility = Visibility.Hidden;
                Grid_Search_Role.Visibility = Visibility.Hidden;
            }
            else
            {
                Grid_New_Player.Visibility = Visibility.Hidden;
                Grid_Search_Player.Visibility = Visibility.Visible;
                Grid_Search_Role.Visibility = Visibility.Hidden;
            }
        }

        private void btnPlayerSearch_Click(object sender, RoutedEventArgs e)
        {
            // Search db for player info and print
        }
        
        private void btnSearchRole_Click(object sender, RoutedEventArgs e)
        {
            if (Grid_Search_Role.Visibility == Visibility.Visible)
            {
                Grid_New_Player.Visibility = Visibility.Hidden;
                Grid_Search_Player.Visibility = Visibility.Hidden;
                Grid_Search_Role.Visibility = Visibility.Hidden;
            }
            else
            {
                Grid_New_Player.Visibility = Visibility.Hidden;
                Grid_Search_Player.Visibility = Visibility.Hidden;
                Grid_Search_Role.Visibility = Visibility.Visible;
            }
        }

    }
}
