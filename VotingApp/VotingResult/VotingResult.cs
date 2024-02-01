using VotingApp; // VotingApp namespace'ini kullanıyoruz. (We are using the VotingApp namespace.)

public class VotingResult
{
    public int TotalVotes { get; set; } // Toplam oy sayısı. (Total number of votes)
    public Dictionary<Category, int> CategoryVotes { get; set; } // Her kategori için oy sayısını tutan sözlük. (Dictionary to store votes for each category)

    public VotingResult()
    {
        CategoryVotes = new Dictionary<Category, int>(); // CategoryVotes sözlüğünü başlatma. (Initializing the CategoryVotes dictionary)
    }
}
