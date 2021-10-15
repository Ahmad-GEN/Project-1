using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnClick : MonoBehaviour
{
    public AudioSource SoundSource;
    public AudioClip SoundClip;

    public void OnClickSound()
    {
        SoundSource.PlayOneShot(SoundClip);
    }
}
