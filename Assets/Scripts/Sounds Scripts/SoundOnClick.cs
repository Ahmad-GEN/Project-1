using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnClick : MonoBehaviour
{
    public void OnClickSound()
    {
        SoundManager.instance.PlaySound(Constants.SoundEffects.ButtonSound);
    }
}
