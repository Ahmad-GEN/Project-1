[System.Serializable]
public class Score
{
    public string PlayerName;
    public int PlayerScore;

    public Score(string Name, int score)
    {
        this.PlayerName = Name;
        this.PlayerScore = score;
    }
}
