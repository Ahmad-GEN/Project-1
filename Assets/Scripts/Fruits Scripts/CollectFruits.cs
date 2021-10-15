using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectFruits : MonoBehaviour
{
    public Text ScoreText;
    public static string winText;
    public static int score;
    public static int highscore;
    public Text HighScoreText;
    private CollectFruits instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            Debug.Log("Collect Fruits Instance created");
        }
        if (PlayerPrefs.HasKey(Constants.PlayerPrefsNames.HighScore.ToString()))
        {
            highscore = PlayerPrefs.GetInt(Constants.PlayerPrefsNames.HighScore.ToString());
            HighScoreText.text = highscore.ToString();
        }
    }
    public void SetScore()
    {
        score += 20;
        SetHighScore();
        ScoreText.text = score.ToString();
        if (score >= 1000)
        {
            winText = "YOU WIN!";
        }
        else
        {
            winText = "YOU LOSE!";
        }


        for (int i = 0; i < ScoreManagement.instance.scoreData.scores.Count; i++)
        {
            if (ScoreManagement.instance.scoreData.scores[i].PlayerName.Equals(SavePlayerRecord.instance.currentPlayerName)
                && ScoreManagement.instance.scoreData.scores[i].PlayerScore <= score)
            {
                ScoreManagement.instance.scoreData.scores[i].PlayerScore = score;
                ScoreManagement.instance.SaveScore();
                return;
            }
        }

        ScoreManagement.instance.AddScore(new Score(SavePlayerRecord.instance.currentPlayerName, score));
    }

    public void SetHighScore()
    {
        if (score > highscore)
        {
            highscore = score;
            HighScoreText.text = highscore.ToString();
            PlayerPrefs.SetInt(Constants.PlayerPrefsNames.HighScore.ToString(), highscore);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick up"))
        {
            other.gameObject.SetActive(false);
            SetScore();
        }
    }

    public void DoubleScore()
    {
        score *= 2;
    }
}
