using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject totalPoints;
    public GameObject highScore;
    public GameObject winText;
    CollectFruits instance;
    // Start is called before the first frame update
    void Start()
    {
        totalPoints.GetComponent<Text>().text = "SCORE : " + CollectFruits.score.ToString();
        highScore.GetComponent<Text>().text = "HIGH SCORE : " + CollectFruits.highscore.ToString();
        Debug.Log(CollectFruits.winText);
        winText.GetComponent<Text>().text = CollectFruits.winText;
    }

    public void ResetTimer()
    {
        CountDownTimer.timeLeft = 10;
        CollectFruits.score = 0;
        instance.ScoreText.text = CollectFruits.score.ToString();
    }
}
