using UnityEngine;
public class SoundManager : MonoBehaviour
{
    public AudioClip[] musicClips;
    public AudioClip[] soundClips;
    public AudioSource musicAudioSource;
    public AudioSource soundAudioSource;

    public static SoundManager instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

    public void PlaySound(Constants.SoundEffects effect)
    {
        soundAudioSource.PlayOneShot(soundClips[(int)effect]);
    }

    public void SoundOnClick()
    {
        PlaySound(Constants.SoundEffects.ButtonSound);
    }

    public void PlayMusic(Constants.BackgroundMusic music)
    {
        musicAudioSource.Stop();
        musicAudioSource.clip = musicClips[(int)music];
        musicAudioSource.Play();
    }
    
    public void PauseMusic()
    {
        musicAudioSource.mute = true;
    }

    public void ResumeMusic()
    {
        musicAudioSource.mute = false;
    }

    public void PauseSound()
    {
        soundAudioSource.mute = true;
    }

    public void ResumeSound()
    {
        soundAudioSource.mute = false;
    }
}
