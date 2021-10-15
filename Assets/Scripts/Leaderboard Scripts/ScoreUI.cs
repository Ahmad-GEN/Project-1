using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowui;

    // Start is called before the first frame update
    void Start()
    {
        var scores = ScoreManagement.instance.GetHighScore().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowui, transform).GetComponent<RowUI>();
            row.Rank.text = (i + 1).ToString();
            row.playerName.text = scores[i].PlayerName;
            row.playerScore.text = scores[i].PlayerScore.ToString();
        }
    }
}
