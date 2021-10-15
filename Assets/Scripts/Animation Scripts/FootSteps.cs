using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public void step()
    {
        source.PlayOneShot(clip);
    }
}
