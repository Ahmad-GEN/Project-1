using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    private bool IsMuted = false;
    public Button MusicButton;
    public Sprite MusicOnSprite;
    public Sprite MusicOffSprite;
    public Sprite SoundOnSprite;
    public Sprite SoundOffSprite;
    public Button SoundButton;
    public AudioSource audioSource;
    private void Start()
    {
        if(!PlayerPrefs.HasKey(Constants.PlayerPrefsNames.muted.ToString()))
        {
            PlayerPrefs.SetInt(Constants.PlayerPrefsNames.muted.ToString(), 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateMusicButtonSprite();
        UpdateSoundButtonSprite();
        AudioListener.pause = IsMuted;
    }

    private void UpdateMusicButtonSprite()
    {
        if (IsMuted)
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
        if(!IsMuted)
        {
            IsMuted = true;
            AudioListener.pause = true;
        }
        else
        {
            IsMuted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateMusicButtonSprite();
    }

    private void UpdateSoundButtonSprite()
    {
        if (IsMuted)
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
        if (!IsMuted)
        {
            IsMuted = true;
            audioSource.Stop();
        }
        else
        {
            IsMuted = false;
            audioSource.Play();
        }
        Save();
        UpdateSoundButtonSprite();
    }

    public void Load()
    {
        IsMuted = PlayerPrefs.GetInt(Constants.PlayerPrefsNames.muted.ToString()) == 1;
    }

    public void Save()
    {
        PlayerPrefs.SetInt(Constants.PlayerPrefsNames.muted.ToString(), IsMuted ? 1 : 0);
    }
}
