using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SavePlayerRecord : MonoBehaviour
{
    public string currentPlayerName;
    public static SavePlayerRecord instance;
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
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetCurrentPlayerName(string text)
    {
        currentPlayerName = text;
    }

    public string GetCurrentPlayerName()
    {
        return currentPlayerName;
    }
}

