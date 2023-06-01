using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HmsPlugin;
using HuaweiMobileServices.IAP;


public class OpeningScene : MonoBehaviour
{
    public void TransitionScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void onNoAdsClick()
    {

        //HMSIAPManager.Instance.BuyProduct(HMSIAPConstants.AdsRemove);
    }
}
