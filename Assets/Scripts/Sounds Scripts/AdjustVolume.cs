using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustVolume : MonoBehaviour
{
    [SerializeField] private Slider VolumeSlider;

    private void Start()
    {
        if(!PlayerPrefs.HasKey(Constants.PlayerPrefsNames.MusicVolume.ToString()))
        {
            PlayerPrefs.SetFloat(Constants.PlayerPrefsNames.MusicVolume.ToString(), 1);
            Load();
        }
        else
        {
            Load();
        }    
    }
    public void ChangeVolume()
    {
        AudioListener.volume = VolumeSlider.value;
        Save();
    }

    private void Save()
    {
        PlayerPrefs.SetFloat(Constants.PlayerPrefsNames.MusicVolume.ToString(), VolumeSlider.value);
    }

    private void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat(Constants.PlayerPrefsNames.MusicVolume.ToString());
    }
}
