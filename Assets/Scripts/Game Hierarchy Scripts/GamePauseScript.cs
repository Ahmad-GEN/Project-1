using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauseScript : MonoBehaviour
{
    public void StopTime()
    {
        Time.timeScale = 0;
    }
    public void ResumeTime()
    {
        Time.timeScale = 1;
    }
}
