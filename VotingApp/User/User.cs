namespace VotingApp // VotingApp namespace'ini kullanıyoruz. (We are using the VotingApp namespace.)
{
    public class User
    {
        public string userName { get; set; } // Kullanıcının kullanıcı adını tutan özellik. (Property to store the user's username)

        public User(string username)
        {
            userName = username; // Kullanıcı adını belirten kurucu metod. (Constructor to set the username)
        }
    }
}
