using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreManagement : MonoBehaviour
{
    public static ScoreManagement instance;
    public ScoreData scoreData;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

        scoreData = new ScoreData();
        var json = PlayerPrefs.GetString("scores", "{}");
        scoreData = JsonUtility.FromJson<ScoreData>(json);
        Debug.Log(scoreData);
    }

    public IEnumerable<Score> GetHighScore()
    {
        
        return scoreData.scores.OrderByDescending(x => x.PlayerScore);
    }

    public void AddScore(Score score)
    {
        scoreData.scores.Add(score);
        SaveScore();
    }

    private void OnDestroy()
    {
        SaveScore();
    }

    public void SaveScore()
    {
        var json = JsonUtility.ToJson(scoreData);
        PlayerPrefs.SetString("scores", json);
    }
}
