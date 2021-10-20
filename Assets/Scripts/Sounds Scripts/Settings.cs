using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    private bool IsSoundMuted = false;
    private bool IsMusicMuted = false;
    public Button MusicButton;
    public Sprite MusicOnSprite;
    public Sprite MusicOffSprite;
    public Sprite SoundOnSprite;
    public Sprite SoundOffSprite;
    public Button SoundButton;

    private void Start()
    {
        if (!PlayerPrefs.HasKey(Constants.PlayerPrefsNames.Music.ToString())
            && !PlayerPrefs.HasKey(Constants.PlayerPrefsNames.Sound.ToString()))
        {
            PlayerPrefs.SetInt(Constants.PlayerPrefsNames.Music.ToString(), 0);
            PlayerPrefs.SetInt(Constants.PlayerPrefsNames.Sound.ToString(), 0);
            LoadMusic();
            LoadSound();
        }
        else
        {
            LoadMusic();
            LoadSound();
        }
        UpdateMusicButtonSprite();
        UpdateSoundButtonSprite();
        //AudioListener.pause = IsMusicMuted;
    }

    private void UpdateMusicButtonSprite()
    {
        if (IsMusicMuted)
        {
            MusicButton.image.sprite = MusicOffSprite;
        }
        else
        {
            MusicButton.image.sprite = MusicOnSprite;
        }
    }

    public void OnMusicButtonPressed()
    {
        if (!IsMusicMuted)
        {
            IsMusicMuted = true;
            SoundManager.instance.PauseMusic();
        }
        else
        {
            IsMusicMuted = false;
            SoundManager.instance.ResumeMusic();
        }
        SaveMusic();
        UpdateMusicButtonSprite();
    }

    private void UpdateSoundButtonSprite()
    {
        if (IsSoundMuted)
        {
            SoundButton.image.sprite = SoundOffSprite;
        }
        else
        {
            SoundButton.image.sprite = SoundOnSprite;
        }
    }

    public void OnSoundButtonPressed()
    {
        if (!IsSoundMuted)
        {
            IsSoundMuted = true;
            SoundManager.instance.PauseSound();
        }
        else
        {
            IsSoundMuted = false;
            SoundManager.instance.ResumeSound();
        }
        SaveSound();
        UpdateSoundButtonSprite();
    }

    public void LoadMusic()
    {
        IsMusicMuted = PlayerPrefs.GetInt(Constants.PlayerPrefsNames.Music.ToString()) == 1;
    }

    public void SaveMusic()
    {
        PlayerPrefs.SetInt(Constants.PlayerPrefsNames.Music.ToString(), IsMusicMuted ? 1 : 0);
    }

    public void LoadSound()
    {
        IsSoundMuted = PlayerPrefs.GetInt(Constants.PlayerPrefsNames.Sound.ToString()) == 1;
    }

    public void SaveSound()
    {
        PlayerPrefs.SetInt(Constants.PlayerPrefsNames.Sound.ToString(), IsSoundMuted ? 1 : 0);
    }
}
