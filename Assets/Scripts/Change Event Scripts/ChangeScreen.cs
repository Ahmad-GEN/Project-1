using UnityEngine.SceneManagement;
using Unity;
using UnityEngine;
public class ChangeScreen : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject GamePlayPanel;
    private CollectFruits instance;
    public Joystick jstick;
    public void MenuButton()
    {
        SceneManager.LoadScene(ScenesContainer.SceneNames.MainMenu.ToString());
        SoundManager.instance.PlayMusic(Constants.BackgroundMusic.MainMenu);
    }

    public void RestartButton()
    {
        //GameOverPanel.SetActive(false);
        //GamePlayPanel.SetActive(true);
        SceneManager.LoadScene(ScenesContainer.SceneNames.GamePlay.ToString());
    }

    public  static void ConfirmButton()
    {
        SceneManager.LoadScene(ScenesContainer.SceneNames.GamePlay.ToString());
        SoundManager.instance.PlayMusic(Constants.BackgroundMusic.GamePlay);
    }
}