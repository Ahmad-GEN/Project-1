using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform mainMenuPanel, leaderboardPanel, settingsPanel, episodeSelectionPanel, animalSelectionPanel;
    private float time = 0.02f;

    public void SettingsButton()
    {
        mainMenuPanel.DOAnchorPos(new Vector2(0, -720), time);
        settingsPanel.DOAnchorPos(new Vector2(0, 0), time);
    }

    public void CloseSettingsButton()
    {
        mainMenuPanel.DOAnchorPos(new Vector2(0, 0), time);
        settingsPanel.DOAnchorPos(new Vector2(0, 720), time);
    }

    public void LevelsButton()
    {
        mainMenuPanel.DOAnchorPos(new Vector2(-1283, 0), time);
        episodeSelectionPanel.DOAnchorPos(new Vector2(0, 0), time);
    }

    public void CloseLevelsButton()
    {
        mainMenuPanel.DOAnchorPos(new Vector2(0, 0), time);
        episodeSelectionPanel.DOAnchorPos(new Vector2(1283, 0), time);
    }

    public void LeaderBoardButton()
    {
        mainMenuPanel.DOAnchorPos(new Vector2(0, 720), time);
        leaderboardPanel.DOAnchorPos(new Vector2(0, 0), time);
    }

    public void CloseLeaderBoardButton()
    {
        mainMenuPanel.DOAnchorPos(new Vector2(0, 0), time);
        leaderboardPanel.DOAnchorPos(new Vector2(0, -720), time);
    }

    public void AnimalSelectionButton()
    {
        mainMenuPanel.DOAnchorPos(new Vector2(1283, 0), time);
        animalSelectionPanel.DOAnchorPos(new Vector2(0, 0), time);
    }

    public void CloseAnimalSelectionButton()
    {
        episodeSelectionPanel.DOAnchorPos(new Vector2(0, 0), time);
        animalSelectionPanel.DOAnchorPos(new Vector2(-1283, 0), time);
    }
}
