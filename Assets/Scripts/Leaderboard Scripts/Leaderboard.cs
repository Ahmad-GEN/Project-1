using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    public static Leaderboard instance;
    //public Text playerName;
    public GameObject prefab;
    public Transform prefabParent;
    //public Text fnameText;
    //public string fname = GameConstants.fPlayerName;
    private string showLeaderBoard;
    private int showLeaderBoardScore;
    [SerializeField] List<Score> namescore = new List<Score>();
    int totalScoreValues;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        totalScoreValues = PlayerPrefs.GetInt(Constants.PlayerPrefsNames.totalScoreValues.ToString(), 0);
        //fnameText.text = fname;
        LeaderBoardLoad();
    }

    public void LeaderBoardLoad()
    {
        //Debug.Log("total Score values: " + totalScoreValues);
        for (int i = 0; i < totalScoreValues; i++)
        {
            if (PlayerPrefs.HasKey(Constants.PlayerPrefsNames.playerName.ToString() + i))
            {
                showLeaderBoard = PlayerPrefs.GetString(Constants.PlayerPrefsNames.playerName.ToString() + i);
            }

            if (PlayerPrefs.HasKey(Constants.PlayerPrefsNames.playerScore.ToString() + i))
                showLeaderBoardScore = PlayerPrefs.GetInt(Constants.PlayerPrefsNames.playerScore.ToString() + i);

            namescore.Add(new Score(showLeaderBoard, showLeaderBoardScore));
            GameObject go = Instantiate(prefab, prefabParent);
            GameObject childGameObject1 = go.transform.GetChild(0).gameObject;
            GameObject childGameObject2 = go.transform.GetChild(1).gameObject;
            Text Name = childGameObject1.GetComponent<Text>();
            Text Score = childGameObject2.GetComponent<Text>();
            Name.text = showLeaderBoard;
            Score.text = showLeaderBoardScore.ToString();
            Debug.Log(showLeaderBoard + showLeaderBoardScore);

        }
    }

    public void LeaderBoardShow()
    {
        namescore.Add(new Score(Constants.PlayerPrefsNames.playerName.ToString(), CollectFruits.score));
        for (int i = 0; i < namescore.Count; i++)
        {
            Score n = namescore[i];
            //playerName.text = n.name + n.score.ToString();
            PlayerPrefs.SetString(Constants.PlayerPrefsNames.playerName.ToString() + i, n.PlayerName);
            PlayerPrefs.SetInt(Constants.PlayerPrefsNames.playerScore.ToString() + i, n.PlayerScore);
            PlayerPrefs.SetInt(Constants.PlayerPrefsNames.totalScoreValues.ToString(), i + 1);

            Debug.Log(n.PlayerName + "::::" + n.PlayerScore);
        }
    }
}

