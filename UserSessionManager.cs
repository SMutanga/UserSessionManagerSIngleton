namespace UserSessionManagerSIngleton
{
    public class UserSessionManager
    {
        private static UserSessionManager _instance;


        private UserSessionManager()
        {
            IsLoggedIn = false;
            Username = string.Empty;
            Role = string.Empty;
        }

  
        public static UserSessionManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserSessionManager();
                return _instance;
            }
        }

 
        public string Username { get; private set; }
        public string Role { get; private set; }
        public bool IsLoggedIn { get; private set; }

  
        public void Login(string username, string role)
        {
            Username = username;
            Role = role;
            IsLoggedIn = true;
        }

        public void Logout()
        {
            Username = string.Empty;
            Role = string.Empty;
            IsLoggedIn = false;
        }
    }
}