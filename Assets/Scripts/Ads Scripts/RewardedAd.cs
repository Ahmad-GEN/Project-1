using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RewardedAd : MonoBehaviour, IUnityAdsListener
{
    public string _adUnitId = "4382659";
    private bool testmode = true;
    public string adStatus;
    public bool adStarted;
    public bool adCompleted;
    public string videoPlacement = "Rewarded_Android";
    public GameObject gameoverPanel;
    public GameObject gameplayPanel;
    public GameObject gamepausePanel;

    ShowOptions options = new ShowOptions();

   
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(_adUnitId, testmode);
    }
    public void OnUnityAdsDidError(string message)
    {
        adStatus = message;
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        adStarted = true;
    }
    public void OnUnityAdsReady(string placementId)
    {

    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        adCompleted = showResult == ShowResult.Finished;
        CountDownTimer.timeLeft += 20;
        //gameoverPanel.SetActive(false);
        //gameplayPanel.SetActive(true);
    }

    public void ShowRewardedAd()
    {
        Advertisement.Show(videoPlacement);
    }
}