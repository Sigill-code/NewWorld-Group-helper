
namespace NewWorld_Group_helper
{
    class Player
    {
        private string ingameName;
        private string role;
        private string mainWeapon;
        private string secondaryWeapon;

        public string IngameName { get => ingameName; set => ingameName = value; }
        public string Role { get => role; set => role = value; }
        public string MainWeapon { get => mainWeapon; set => mainWeapon = value; }
        public string SecondaryWeapon { get => secondaryWeapon; set => secondaryWeapon = value; }
        
        public Player(string ingameName, string role, string mainWeapon, string secondaryWeapon)
        {
            this.IngameName = ingameName;
            this.Role = role;
            this.MainWeapon = mainWeapon;
            this.SecondaryWeapon = secondaryWeapon;
        }
        public Player(string role, string mainWeapon, string secondaryWeapon)
        {
            this.Role = role;
            this.MainWeapon = mainWeapon;
            this.SecondaryWeapon = secondaryWeapon;
        }
        public Player()
        {

        }
    }
}
