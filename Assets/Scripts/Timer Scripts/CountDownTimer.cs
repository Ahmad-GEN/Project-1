using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public Text remainingTime;
    public Text countDown;
    public GameObject gameoverPanel;
    public GameObject gamePlayPanel;

    float seconds = 3f;
    public static float timeLeft = 10f;

    // Start is called before the first frame update
    void Start()
    {
        countDown.text = seconds.ToString();
        remainingTime.text = timeLeft.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        RemainingTime();
    }

    void Timer()
    {
        if (seconds > 0)
        {
            seconds -= 1 * Time.deltaTime;
            countDown.text = Mathf.Round(seconds).ToString();
        }

        if (seconds <= 0)
            countDown.text = "";
    }
    void RemainingTime()
    {
        if (timeLeft > 0)
        {
            timeLeft -= 1 * Time.deltaTime;
            remainingTime.text = Mathf.Round(timeLeft).ToString();
        }
        if (timeLeft <= 0)
        {
            remainingTime.text = "";
            gamePlayPanel.SetActive(false);
            gameoverPanel.SetActive(true);
        }
    }
}
