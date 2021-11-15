using System.Windows;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace NewWorld_Group_helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "g6Y1chItUAr1RMGfpWuJpktITi2DRfJDHfAC4IbX",
            BasePath = "https://nwgh-player-db-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            // Makes "Add Player" tab visible and the other tabs invisible.
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
        
        private async void btnAddPlayerToDB_Click(object sender, RoutedEventArgs e)
        {
            // Add player info to database
            Player player = new Player(txtBoxIGN.Text, PlayerRole.Text, PlayerMainWeapon.Text, PlayerSecondaryWeapon.Text);

            Player TestPlayer = new Player { Role = PlayerRole.Text, MainWeapon = PlayerMainWeapon.Text, SecondaryWeapon = PlayerSecondaryWeapon.Text };

            await client.SetAsync($"Players/{player.IngameName}", TestPlayer);
        }

        private void btnSearchPlayer_Click(object sender, RoutedEventArgs e)
        {
            // Makes "Search Player" tab visible and the other tabs invisible.
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

        private async void btnPlayerSearch_Click(object sender, RoutedEventArgs e)
        {
            // Search database for player info and print
            Player player = new Player(txtBoxIGNSearch.Text, "", "", "");
            FirebaseResponse response = await client.GetAsync($"Players/{player.IngameName}");
            player = response.ResultAs<Player>();

            if (response != null)
            {
                RoleOutput.Text = player.Role;
                MainWeaponOutput.Text = player.MainWeapon;
                SecondaryWeaponOutput.Text = player.SecondaryWeapon;   
            }
            else
            {
                MessageBox.Show("Item does not exist");
            }
        }
        
        private void btnSearchRole_Click(object sender, RoutedEventArgs e)
        {
            // Makes "Search Role" tab visible and the other tabs invisible.
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

        private void btnRoleSearch_Click(object sender, RoutedEventArgs e)
        {
            // Search database for the input (role) and displays a list of players with that input.
        }

        private void DBAccessBtn_Click(object sender, RoutedEventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client!=null)
            {
                MessageBox.Show("Connection is established.");
            }

        }
    }
}
