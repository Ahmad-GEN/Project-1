using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public Slider slider;
    IEnumerator LoadScreen()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadSceneAsync(ScenesContainer.SceneNames.MainMenu.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScreen());
    }


}
