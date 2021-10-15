using UnityEngine.SceneManagement;
using Unity;
using UnityEngine;
public class ChangeScreen : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject GamePlayPanel;
    public void MenuButton()
    {
        SceneManager.LoadScene(ScenesContainer.SceneNames.MainMenu.ToString());
    }

    public void RestartButton()
    {
        GameOverPanel.SetActive(false);
        GamePlayPanel.SetActive(true);
        //SceneManager.LoadScene(ScenesContainer.SceneNames.GamePlay.ToString());
    }

    public  static void ConfirmButton()
    {
        SceneManager.LoadScene(ScenesContainer.SceneNames.GamePlay.ToString());
    }
}