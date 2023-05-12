using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateApp : MonoBehaviour
{
    public void OnClickRateUs()
    {
        Application.OpenURL("market://details?id=" + Application.identifier);
    }
    public void OnClickPrivacy()
    {
        Application.OpenURL("https://sites.google.com/view/savemypigi/trang-ch%E1%BB%A7");
    }
}
