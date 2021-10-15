using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    static bool IsDebugMode = false;
    public InputField field;
    public static MainMenuManager instance;
    private void Awake()
    {
        instance = this;
        field.text = PlayerPrefs.GetString(Constants.PlayerPrefsNames.playerName.ToString());
        SavePlayerRecord.instance.SetCurrentPlayerName(field.text);
        field.onValueChanged.AddListener(delegate { CallSetCurrentPlayer(); });
    }
    public void CallSetCurrentPlayer()
    {
        if (IsDebugMode)
        {
            Debug.Log("in call set current player");
        }
        PlayerPrefs.SetString(Constants.PlayerPrefsNames.playerName.ToString(), field.text);
        SavePlayerRecord.instance.SetCurrentPlayerName(field.text);
        Debug.Log(SavePlayerRecord.instance.currentPlayerName);
    }
}
